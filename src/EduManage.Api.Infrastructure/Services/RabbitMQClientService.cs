using EduManage.Api.Domain.Dtos;
using EduManage.Api.Domain.Entities;
using EduManage.Api.Infrastructure.Interfaces;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Services
{
    public class RabbitMQClientService : IRabbitMQClientService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public RabbitMQClientService()
        {
            var factory = new ConnectionFactory() { HostName = "localhost", Password="root", UserName = "root" };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(queue: "messages",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
        }
        public bool SendMessage(MessageDto message)
        {
            try
            {
                var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
                _channel.BasicPublish(exchange: "",
                                     routingKey: "messages",
                                     basicProperties: null,
                                     body: body);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
