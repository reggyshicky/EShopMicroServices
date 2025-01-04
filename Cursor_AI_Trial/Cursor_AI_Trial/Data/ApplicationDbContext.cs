using Cursor_AI_Trial.Models;
using Microsoft.EntityFrameworkCore;

namespace Cursor_AI_Trial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Mood> Moods { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
