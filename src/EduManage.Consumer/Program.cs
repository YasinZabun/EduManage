using EduManage.Api.Domain.Entities;
using EduManage.Api.Domain.Interfaces;
using EduManage.Api.Infrastructure.Data;
using EduManage.Api.Infrastructure.Interfaces;
using EduManage.Api.Infrastructure.Repositories;
using EduManage.Api.Infrastructure.Services;
using EduManage.Api.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using StackExchange.Redis;
using System.Text;
using System.Text.Json;

var serviceProvider = new ServiceCollection()
    .AddScoped(typeof(IRepository<>), typeof(Repository<>))
    .AddSingleton<IConnectionMultiplexer>(provider =>
        ConnectionMultiplexer.Connect("localhost:6379"))
    .AddSingleton<IRedisCacheService, RedisCacheService>()
    .AddScoped<RedisCacheInterceptor>()
    .AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
    {
        var redisCacheService = serviceProvider.GetRequiredService<IRedisCacheService>();
        options.UseNpgsql(
            "Host=localhost;Database=EduManage;Username=root;Password=root",
            npgsqlOptions => npgsqlOptions.MigrationsAssembly("EduManage.Api.Infrastructure")
        )
        .AddInterceptors(serviceProvider.GetRequiredService<RedisCacheInterceptor>());
    })
    .BuildServiceProvider();

var factory = new ConnectionFactory() { HostName = "localhost", UserName = "root", Password = "root" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "messages",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += async (model, ea) =>
{
    // Create a new scope for each message
    using var scope = serviceProvider.CreateScope();
    var repository = scope.ServiceProvider.GetRequiredService<IRepository<Message>>();

    var body = ea.Body.ToArray();
    var jsonString = Encoding.UTF8.GetString(body);
    Message message = JsonSerializer.Deserialize<Message>(jsonString);

    if (message != null)
    {
        try
        {
            await repository.AddAsync(message);
            Console.WriteLine(" [x] Received and saved: {0}", message.MessageText);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the message: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("Failed to deserialize message.");
    }
};
channel.BasicConsume(queue: "messages",
                     autoAck: true,
                     consumer: consumer);

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();
