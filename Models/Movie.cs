using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        // Relationship
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}