using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public class Genre : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        // Relationship
        public ICollection<Movie> Movies { get; set; }
    }
}