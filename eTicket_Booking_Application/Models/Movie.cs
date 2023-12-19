using eTicket_Booking_Application.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicket_Booking_Application.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }  // enum field ekak. eka wenam thanaka hadal eka mekata import kranna 



        // Relationships 
        // movies and actors athara many to many ralationship ekak thiyennne.
        // many to many ralationship wenama  model ekak hadanw table join karala 
        // ehema hadapu table eka Actor_Movie.
        // Actor_Movie table eka ha movie athara thiyenne one to many raltionship ekak 

        public List<Actor_Movie> Actors_Movies { get; set; }



        // movie and cinema relationsnip (1 to many ) 
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]        // define the foreign key. key name ekat kamthi ekak danna 
        public Cinema Cinema { get; set; }


        // movie and producer relationship ( 1 to many) 

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]  // define the foreign key. key name ekat kamthi ekak danna 
        public Producer Producer { get; set; }  // relationship eka 

    }
}
