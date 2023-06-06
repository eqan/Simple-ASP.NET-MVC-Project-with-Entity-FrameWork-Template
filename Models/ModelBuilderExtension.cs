using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // Seed data for Customer entity
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Jane Smith" }
            );

            // Seed data for Movie entity
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Movie 1", Description = "Someone", GenreId = 1 },
                new Movie { Id = 2, Title = "Movie 2", Description = "Someone", GenreId = 2 }
            );

            // Seed data for Genre entity
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" }
            );
        }
    }
}
