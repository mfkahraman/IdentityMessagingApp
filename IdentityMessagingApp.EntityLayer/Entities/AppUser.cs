using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessagingApp.EntityLayer.Entities
{
    public class AppUser : IdentityUser
    {
        // Gönderdiği mesajlar
        public ICollection<Messagesda> SentMessages { get; set; }

        // Aldığı mesajlar
        public ICollection<Messagesda> ReceivedMessages { get; set; }
    }
}
