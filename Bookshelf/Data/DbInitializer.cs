using Bookshelf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookshelf.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any books.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
            new Book{ISBN=7205857293729,Title="Barry Poppins",Genre="Horror",PublishDate=DateTime.Parse("2005-09-01"),AuthorId=1},
            new Book{ISBN=7205928289372,Title="Peepee the Goat",Genre="Memoir",PublishDate=DateTime.Parse("2016-04-04"),AuthorId=1},
            };
            foreach (Book b in books)
            {
                context.Book.Add(b);
            }
            context.SaveChanges();

            var authors = new Author[]
            {
            new Author{firstName="Ted",lastName="Tedderson",ApplicationUserId=1},
            new Author{firstName="Penny",lastName="Pennyman",ApplicationUserId=1},
            };
            foreach (Author a in authors)
            {
                context.Author.Add(a);
            }
            context.SaveChanges();
        }
    }
}
