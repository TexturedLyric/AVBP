using System;
using System.Collections.Generic;
using System.Linq;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {

                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Books.Any())
                    {
                        List<Book> books = new List<Book>()
                        {
                            new Book()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                PublishDate = "October 25, 2017",
                                Author = "Adam Freeman",
                                Pages = 1017
                            },       
                            new Book()
                            {
                                Title = "Pro Angular 6 3rd Edition",
                                Publisher = "Apress",
                                PublishDate = "October 10, 2018",
                                Author = "Adam Freeman",
                                Pages = 776
                            },            
                            new Book()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                                Publisher = "Microsoft Press",
                                PublishDate = "May 25, 2018",
                                Author = "Haishi Bai",
                                Pages = 528
                            },                                                                                           
                        };

                        db.Books.AddRange(books);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var books = db.Books.ToList();

                        var WhereBooks = from b in db.Books
                            where b.Title.Length >= 0
                            select b.Title;

                        foreach(Book b in books){
                            Console.WriteLine(b);
                        }
                         Console.WriteLine("------------------------------------------------------------------");
                        var WhereBooks1 = from b in db.Books
                                where b.Publisher == "APress"
                                select b.Publisher;

                        foreach(Book b in books){
                            Console.WriteLine(b);
                        }
                        Console.WriteLine("------------------------------------------------------------------");
                        var WhereBooks2 = from b in db.Books
                                where b.Author.Length < 5
                                select b.Publisher;

                        foreach(Book b in books){
                            Console.WriteLine(b);
                        }
                        Console.WriteLine("------------------------------------------------------------------");
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}