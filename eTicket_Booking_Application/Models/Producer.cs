using System;
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


    }
}
