using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class Content : DbContext 
    {
        public DbSet<Login> Username { get; set; }

        public Content(DbContextOptions options) :base(options) { 
        
        }    
    }
}
