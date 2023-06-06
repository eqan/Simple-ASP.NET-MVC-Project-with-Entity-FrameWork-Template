using Microsoft.AspNetCore.SignalR;

namespace ASP.NET.Models
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
        public List<Customer> Customers
        {
            get;
            set;
        }
    }
}
