using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using Tuns_Bianca_Lab2.Models;

namespace Tuns_Bianca_Lab2.Views.Books
{
    public class PublishedBooks
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedBook> PublishedBook { get; set; }
    }

    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publisher Publisher { get; set; }
        public Book Book { get; set; }
    }
}
