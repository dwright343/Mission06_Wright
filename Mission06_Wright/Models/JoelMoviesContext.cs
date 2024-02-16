using Microsoft.EntityFrameworkCore;

namespace Mission06_Wright.Models
{
    public class JoelMoviesContext : DbContext
    {
        // Constructor
        public JoelMoviesContext(DbContextOptions<JoelMoviesContext> options) : base(options) // We're creating a class called DbContextOptions. The <> brackets tells that its going to be "of type" JoelMoviesContext which is the name of the class.
        {
        }

        public DbSet<MovieRec> MovieRecommendations { get; set; } // MovieRecommendations is the name of the db table
    }
}