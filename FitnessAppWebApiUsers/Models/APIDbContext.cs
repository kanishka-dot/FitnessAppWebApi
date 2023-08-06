using Microsoft.EntityFrameworkCore;

namespace FitnessAppWebApiUsers.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options) {

        }
      
        public DbSet<User> Users { get; set; }

    }
}
