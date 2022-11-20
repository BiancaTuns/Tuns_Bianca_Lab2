using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Tuns_Bianca_Lab2.Models;
using static System.Reflection.Metadata.BlobBuilder;
using Tuns_Bianca_Lab2.Views.Books;

namespace Tuns_Bianca_Lab2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            {
                if (context.Books.Any())
                {
                    return; // BD a fost creata anterior
                }
                /*
                var orders = new Order[]
                 {
             new Order{BookID=1,CustomerID=1,OrderDate=DateTime.Parse("2021-02-25")},
             new Order{BookID=3,CustomerID=2,OrderDate=DateTime.Parse("2021-09-28")},
             new Order{BookID=1,CustomerID=3,OrderDate=DateTime.Parse("2021-10-28")},
             new Order{BookID=2,CustomerID=4,OrderDate=DateTime.Parse("2021-09-28")},
             new Order{BookID=4,CustomerID=5,OrderDate=DateTime.Parse("2021-09-28")},
             new Order{BookID=6,CustomerID=6,OrderDate=DateTime.Parse("2021-10-28")},
                 };
                foreach (Order e in orders)
                {
                    context.Orders.Add(e);
                }
                context.SaveChanges();
                var publishers = new Publisher[]
                {
             new Publisher{PublisherName="Humanitas",Adress="Str. Aviatorilor, nr. 40,Bucuresti"},
             new Publisher{PublisherName="Nemira",Adress="Str. Plopilor, nr. 35,Ploiesti"},
             new Publisher{PublisherName="Paralela 45",Adress="Str. Cascadelor, nr.22, Cluj-Napoca"},
                };
                foreach (Publisher p in publishers)
                {
                    context.Publishers.Add(p);
                }
                context.SaveChanges();
                var books = context.Books;
                var publishedbooks = new PublishedBook[]
                {
            new PublishedBook {
            BookID = books.Single(c => c.Title == "Maytrei" ).ID,
            PublisherID = publishers.Single(i => i.PublisherName =="Humanitas").ID
            },
            new PublishedBook
            {
                BookID = books.Single(c => c.Title == "Enigma Otiliei").ID,
                PublisherID = publishers.Single(i => i.PublisherName == "Humanitas").ID
            },
             new PublishedBook
             {
                 BookID = books.Single(c => c.Title == "Baltagul").ID,
                 PublisherID = publishers.Single(i => i.PublisherName == "Nemira").ID
             },
             new PublishedBook
             {
                 BookID = books.Single(c => c.Title == "Fata de hartie").ID,
                 PublisherID = publishers.Single(i => i.PublisherName == "Paralela45").ID
             },
             new PublishedBook
             {
                 BookID = books.Single(c => c.Title == "Panza de paianjen").ID,
                 PublisherID = publishers.Single(i => i.PublisherName == "Paralela45").ID
             },
             new PublishedBook
             {
                 BookID = books.Single(c => c.Title == "De veghe in lanul desecara").ID,
                 PublisherID = publishers.Single(i => i.PublisherName == "Paralela45").ID
             },
                 };
                foreach (PublishedBook pb in publishedbooks)
                {
                    context.PublishedBooks.Add(pb);
                }
                context.SaveChanges();
            }
        }
                /*
        /*   context.Books.AddRange(
           new Book
           {
               Title = "Baltagul",
               Author = "Mihail Sadoveanu",
               Price=Decimal.Parse("22")},

           new Book
           {
               Title = "Enigma Otiliei",
               Author = "George Calinescu",
               Price=Decimal.Parse("18")},

           new Book
           {
               Title = "Maytrei",
               Author = "Mircea Eliade",
               Price=Decimal.Parse("27")}

           );
        */

        context.Customers.AddRange(
                new Customer
                {
                    Name = "Popescu Marcela",
                    Adress = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.Parse("1979-09-01")
                },
                new Customer
                {
                    Name = "Mihailescu Cornel",
                    Adress = "Str. Bucuresti, nr.45,ap. 2",BirthDate=DateTime.Parse("1969 - 07 - 08")}
               
               );


                context.SaveChanges();
            }
            
        }
    }
}
