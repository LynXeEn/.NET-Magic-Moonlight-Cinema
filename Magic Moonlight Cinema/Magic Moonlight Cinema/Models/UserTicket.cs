using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magic_Moonlight_Cinema.Models
{
    public class UserTicket
    {
        public UserTicket()
        {
            Tickets = new List<Ticket>();
        }

        public int UserId { get; set; }
        public int TicketId { get; set; }
        public User User { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}