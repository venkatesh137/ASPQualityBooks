using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QualityBooks.Models;

namespace QualityBooks.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any books.
            if (context.Books.Any())
            {
                return; //DB has been seeded
            }

            var categories = new Category[] {
                new Category {Name = "Arts & Music"},
                new Category {Name = "Business"},
                new Category {Name = "Sports"},
                new Category {Name = "Maori Culture"}
            };

            foreach (var c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var suppliers = new Supplier[]
            {
                new Supplier {Name = "Supplier A", MobilePhoneNumber = "021-111111", EmailAddress = "111111@gmail.com" },
                new Supplier {Name = "Supplier B", MobilePhoneNumber = "021-222222", EmailAddress = "222222@gmail.com" },
                new Supplier {Name = "Supplier C", MobilePhoneNumber = "021-333333", EmailAddress = "333333@gmail.com" }
            };

            foreach (var s in suppliers)
            {
                context.Suppliers.Add(s);
            }
            context.SaveChanges();

            var books = new Book[]
            {
                new Book {Name = "Book1", Description = "Description 1", Price = Convert.ToDecimal(149.95), PathOfFile = "/Images/book1.jpg", CategoryID = categories.Single( c => c.Name == "Arts & Music").CategoryID, SupplierID = suppliers.Single( s => s.Name == "Supplier A").SupplierID },
                new Book {Name = "Book2", Description = "Description 2", Price = Convert.ToDecimal(249.95), PathOfFile = "/Images/book1.jpg", CategoryID = categories.Single( c => c.Name == "Business").CategoryID, SupplierID = suppliers.Single( s => s.Name == "Supplier B").SupplierID },
                new Book {Name = "Book3", Description = "Description 3", Price = Convert.ToDecimal(349.95), PathOfFile = "/Images/book1.jpg", CategoryID = categories.Single( c => c.Name == "Sports").CategoryID, SupplierID = suppliers.Single( s => s.Name == "Supplier C").SupplierID },
                new Book {Name = "Book4", Description = "Description 4", Price = Convert.ToDecimal(449.95), PathOfFile = "/Images/book1.jpg", CategoryID = categories.Single( c => c.Name == "Maori Culture").CategoryID, SupplierID = suppliers.Single( s => s.Name == "Supplier A").SupplierID },
                
            };

            foreach (var b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();


        }
    }
}
