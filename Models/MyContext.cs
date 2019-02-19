using Microsoft.EntityFrameworkCore;
 
namespace wedding_planner.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<User> users {get;set;}
        public DbSet<Wedding> weddings {get;set;} 
        public DbSet<RSVP> rsvps {get; set;}
    }
}