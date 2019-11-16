using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatAppwithPusher.Models
{
    public class Conversation
    {
        public Conversation()
        {
            Status = MessageStatus.Sent;
        }
        public enum MessageStatus
        {
            Sent,
            Delivered           
        }
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
        public MessageStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}