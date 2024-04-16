using System;
using System.ComponentModel.DataAnnotations;

namespace Magic_Moonlight_Cinema.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TicketCode { get; set; }

        public int SeatNumber { get; set; }
        public string Showtime { get; set; }
        public string BookingDate { get; set; }
        public string PaymentMethod { get; set; }

        // Add this property to store the selected movie's ID
        [Display(Name = "Movie")]
        public int film { get; set; }

        // Add this navigation property to associate the Ticket with a Movie
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}
