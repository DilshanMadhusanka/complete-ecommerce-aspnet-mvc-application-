using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket_Booking_Application.Models
{
    public class Producer
    {
        [Key]  // Generat the primary key
        public int Id { get; set; }   // identifier 
        public String ProfilepictuerUrl { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }


        // Relationships 
        // producer can have multiple movies 

        public List<Movie> Movies { get; set; }   // 1 to many ralationship
    }
}
