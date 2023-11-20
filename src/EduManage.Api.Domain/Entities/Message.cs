using EduManage.Api.Domain.Entites;
using EduManage.Api.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Entities
{
    public class Message
    {
        public string MessageText { get; set; }
        public string SenderId { get; set; }
        public UserType SenderType { get; set; }
        public string ReceiverId { get; set; }
        public UserType ReceiverType { get; set; }
        public string BaseConversationId { get; set; }
        public string MessageId { get; set; }

        // Navigation properties
        public Student SenderStudent { get; set; }
        public Instructor SenderInstructor { get; set; }
        public Student ReceiverStudent { get; set; }
        public Instructor ReceiverInstructor { get; set; }

        public Message()
        {
            MessageId = Guid.NewGuid().ToString();
        }
    }
}
