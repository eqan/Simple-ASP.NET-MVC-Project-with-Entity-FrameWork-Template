using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
