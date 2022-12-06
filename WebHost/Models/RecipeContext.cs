using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebHost.Models
{
    public class RecipeContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Recipe> Recipes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Step> Steps { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options): base(options)
        {
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2019;Database=b3Recipe;Trusted_Connection=True;Encrypt=False;");
        }
        */
    }
}
