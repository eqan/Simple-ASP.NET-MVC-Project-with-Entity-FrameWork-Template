using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, name = "John Doe" },
                new Customer { Id = 2, name = "Jane Smith" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Movie 1" },
                new Movie { Id = 2, Title = "Movie 2" }
            );
        }
    }
}
