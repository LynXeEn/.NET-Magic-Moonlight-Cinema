using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Magic_Moonlight_Cinema.Models
{
    public class User
    {
        public User()
        {
            BookedTickets = new List<Ticket>();
        }

        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        
        public string NewsletterSubscription { get; set; }
        public virtual ICollection<Ticket> BookedTickets { get; set; }
    }
}