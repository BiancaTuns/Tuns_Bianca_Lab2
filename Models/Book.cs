using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tuns_Bianca_Lab2.Views.Books;

namespace Tuns_Bianca_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Authors? Author { get; set; }

        
        public decimal Price { get; set; }
        public ICollection<Order>? Orders { get; set; }

        
    }
}
