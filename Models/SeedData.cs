using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MoodyAssignment5.Models
{
    public class SeedData
    {
        //data entered for the database
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Book.Any())
            {
                context.Book.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Class = "Fiction",
                        Cat = "Classic",
                        Price = 9.95,
                        //pages added
                        Pages = 1488,
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Class = "Non-Fiction",
                        Cat = "Biography",
                        Price = 14.58,
                        Pages = 944,
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Class = "Non-Fiction",
                        Cat = "Biography",
                        Price = 21.54,
                        Pages = 832,
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Class = "Non-Fiction",
                        Cat = "Biography",
                        Price = 11.61,
                        Pages = 864,
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Class = "Non-Fiction",
                        Cat = "Historical",
                        Price = 13.33,
                        Pages = 528,
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Class = "Fiction",
                        Cat = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288,
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Class = "Non-Fiction",
                        Cat = "Self-Help",
                        Price = 14.99,
                        Pages = 304,
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Class = "Non-Fiction",
                        Cat = "Self-Help",
                        Price = 21.66,
                        Pages = 240,
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Class = "Non-Fiction",
                        Cat = "Business",
                        Price = 29.16,
                        Pages = 400,
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Class = "Fiction",
                        Cat = "Thrillers",
                        Price = 15.03,
                        Pages = 642,
                    },

                    //3 new books added
                    new Book
                    {
                        Title = "The Phantom Tollbooth",
                        AuthorFirst = "Norton",
                        AuthorLast = "Juster",
                        Publisher = "Random House",
                        ISBN = "978-0394820378",
                        Class = "Fiction",
                        Cat = "Fantasy",
                        Price = 3.88,
                        Pages = 255,
                    },

                    new Book
                    {
                        Title = "The Book Thief",
                        AuthorFirst = "Markus",
                        AuthorLast = "Zusak",
                        Publisher = "Picador",
                        ISBN = "978-0739337271",
                        Class = "Fiction",
                        Cat = "Historical Fiction",
                        Price = 6.99,
                        Pages = 584,
                    },

                    new Book
                    {
                        Title = "Disrupt Yourself",
                        AuthorFirst = "Whitney",
                        AuthorLast = "Johnson",
                        Publisher = "Bibliomotion",
                        ISBN = "978-1629560526",
                        Class = "Non-Fiction",
                        Cat = "Self-Help",
                        Price = 18.94,
                        Pages = 208,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
