using eTicket_Booking_Application.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eTicket_Booking_Application.Data
{

    // meka startup.cs eke  configure karanntha oni
    public class AppDbContext : DbContext  //  DbContext file 
    {

        // create a construstor using ctor.

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  // methana argument widihata denne DbContextOptions ekath ekka class name eka.
                                                                                      // eka  base keyword eken inherite wenna oni.
        {
            
        }


        // over ride onModelCreating 
        // this is important when creating the default authentiaction table 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne( m =>m.Movie).WithMany
                (am => am.Actors_Movies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany
               (am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }


        // define table names for each models
        public DbSet<Actor> Actors { get; set; }   // Actor kiyanne model name eka. Actors kiyanne table ekat dana name eka 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        
    }
}
