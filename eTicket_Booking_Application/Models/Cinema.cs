using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket_Booking_Application.Models
{
    public class Cinema
    {
        [Key]  // uniqe identifier
        public int Id { get; set; }
        public string  Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        // Relationships 
        // cinema can have mulptiple movies 

        public List<Movie> Movies { get; set; }
    }
}
