namespace eTicket_Booking_Application.Models
{
    // many to many relationship eka nisa table dekak join wel haduna aluth table eka (model) implement kranna 
    public class Actor_Movie
    {
        public int MovieId { get; set; }  // foreign key eka.movie table ekan 
        public Movie Movie { get; set; } //  relationship eka ( 1 to many)
        public int ActorId { get; set; }  // foreign key eka.actor table eken
        public Actor Actor { get; set; } // relationship eka. ( 1 to many)

    }
}
