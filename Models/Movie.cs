using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public class Movie: BaseEntity
    {
        [Required]
        public string Title { get; set; }
    }
}
