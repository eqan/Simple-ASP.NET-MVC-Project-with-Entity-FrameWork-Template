using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public class Customer: BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
