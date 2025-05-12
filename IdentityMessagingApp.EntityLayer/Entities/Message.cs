using IdentityMessagingApp.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessagingApp.EntityLayer.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string SenderId { get; set; }
        public AppUser Sender { get; set; }

        public string ReceiverId { get; set; }
        public AppUser Receiver { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; } // Rich Text HTML

        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsDraft { get; set; }
        public bool IsDeletedBySender { get; set; }
        public bool IsDeletedByReceiver { get; set; }
    }
}
