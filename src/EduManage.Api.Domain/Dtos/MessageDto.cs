using EduManage.Api.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Domain.Dtos
{
    public class MessageDto
    {
        public string MessageText { get; set; }
        public string? SenderId { get; set; } // Assuming SenderId is of type Guid
        public UserType SenderType { get; set; }
        public string? ReceiverId { get; set; } // Assuming ReceiverId is of type Guid
        public UserType ReceiverType { get; set; }
        public string? BaseConversationId { get; set; }
    }
}
