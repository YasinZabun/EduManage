using EduManage.Api.Application.Interfaces;
using EduManage.Api.Application.Services;
using EduManage.Api.Domain.Interfaces;
using EduManage.Api.Infrastructure.Interfaces;
using EduManage.Api.Infrastructure.Repositories;
using EduManage.Api.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(ICourseRepository), typeof(CourseRepository));
        services.AddScoped(typeof(ICourseService), typeof(CourseService));
        services.AddSingleton(typeof(IRabbitMQClientService), typeof(RabbitMQClientService));

        // Register the IConnectionMultiplexer to initialize on first use rather than during service registration
        services.AddSingleton<IConnectionMultiplexer>(sp => ConnectToRedisWithRetry("localhost:6379,abortConnect=false"));

        return services;
    }
    private static IConnectionMultiplexer ConnectToRedisWithRetry(string connectionString, int maxRetries = 50)
    {
        var redis = ConnectionMultiplexer.Connect(connectionString);
        int retries = 0;

        while (!redis.IsConnected && retries < maxRetries)
        {
            Console.WriteLine("Waiting for Redis to connect...");
            Thread.Sleep(5000); // Use Thread.Sleep for simplicity in a synchronous context
            retries++;
            try
            {
                redis = ConnectionMultiplexer.Connect(connectionString);
            }
            catch (RedisConnectionException)
            {
                // Handle the exception if you need to log it or take particular actions.
            }
        }

        if (!redis.IsConnected)
        {
            // Log the final failure and consider how to handle this in your application
            Console.WriteLine("Failed to connect to Redis.");
        }

        return redis;
    }

}
