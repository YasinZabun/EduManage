using EduManage.Api.Domain.Dtos;
using EduManage.Api.Domain.Entities;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Interfaces
{
    public interface IRabbitMQClientService
    {
        public bool SendMessage(MessageDto message);
    }
}
