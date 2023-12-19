using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket_Booking_Application.Models
{
    public class Actor
    {
        [Key]  // Generat the primary key
        public int Id { get; set; }   // identifier 
        public String ProfilepictuerUrl { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }

        // Relationships 
        // movies and actors athara many to many ralationship ekak thiyennne.
        // many to many ralationship wenama  model ekak hadanw table join karala 
        // ehema hadapu table eka Actor_Movie.
        // Actor_Movie table eka ha actor athara thiyenne one to many raltionship ekak 

        public List<Actor_Movie> Actors_Movies { get; set; }





    }
}
