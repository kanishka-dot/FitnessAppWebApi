using Microsoft.EntityFrameworkCore;

namespace FitnessAppWebApi.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options) {

        }
        public DbSet<Meal> Meals { get; set; }

        public DbSet<Workout> Workouts { get; set; }


    }
}
