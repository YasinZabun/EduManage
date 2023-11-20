using EduManage.Api.Domain.Dtos;
using EduManage.Api.Domain.Entities;
using EduManage.Api.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Channels;

namespace EduManage.Api.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Instructor,Student,Admin")]
    public class MessageController : ControllerBase
    {
        private readonly IRabbitMQClientService _rabbitmqClientService;
        public MessageController(IRabbitMQClientService rabbitmqClientService)
        {
            _rabbitmqClientService = rabbitmqClientService;
        }

        [HttpPost("sendMessage")]
        public IActionResult SendMessage([FromBody] MessageDto message)
        {
            var messageSendingResult = _rabbitmqClientService.SendMessage(message);
            if (messageSendingResult)
                return Ok(new { status = "Message sent" });
            return StatusCode(500, "An Error Occured!");
        }
    }
}
