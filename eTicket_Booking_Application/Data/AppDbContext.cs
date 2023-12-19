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
    }
}
