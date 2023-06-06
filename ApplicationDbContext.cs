using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Models
{
    public class ApplicationDbContext : DbContext
    {
        [Required]
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            // ModelBuilderExtension data
        }
    }
}