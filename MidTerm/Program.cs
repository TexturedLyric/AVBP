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

                    //db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Books.Any())
                    {
                        //CREATION OF BOOKS
                        List<Book> books = new List<Book>()
                        {
                            new Book()
                            {
                                Title = "Pro ASP.NET Core MVC 2 7th Edition",
                                Publisher = "Apress",
                                PublishDate = "October 25, 2017",
                                Author = new Author {FirstName = "Adam", LastName = "Freeman"},
                                Pages = 1017
                            },       
                            new Book()
                            {
                                Title = "Pro Angular 6 3rd Edition",
                                Publisher = "Apress",
                                PublishDate = "October 10, 2018",
                                Author = new Author {FirstName = "Adam", LastName = "Freeman"},
                                Pages = 776
                            },            
                            new Book()
                            {
                                Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                                Publisher = "Microsoft Press",
                                PublishDate = "May 25, 2018",
                                Author = new Author {FirstName = "Haishi", LastName = "Bai"},
                                Pages = 528
                            },                                                                                           
                        };

                        db.Books.AddRange(books);  

                        db.SaveChanges();                                              

                    }
                    else
                    {

//BEGINNING OF METHOD AND LINQ USE
                        var books = db.Books.ToList();
                        
                        var WhereBooks = db.Books;

                        foreach(Book b in WhereBooks){
                            Console.WriteLine(b);
                        }

                         Console.WriteLine("--------");
//========================================================================
                         
                        var WhereBooks1 = books.Where (b => b.Publisher == "Apress");

                        foreach(Book b in WhereBooks1){
                            Console.WriteLine(b);
                        }

                        Console.WriteLine("--------");

//========================================================================
                        var WhereBooks2 = from b in db.Authors
                                      where b.FirstName < FirstName;

                        for(int i = 1; i<=1; i++){
                            Console.WriteLine(WhereBooks2);
                        }
                        Console.WriteLine("--------");

//========================================================================
                        var FindBooks1 = from c in db.Authors
                                    where c.FirstName == "Adam"
                                      orderby c.FirstName descending
                                      select c;

                        Console.WriteLine(FindBooks1);

                        Console.WriteLine("--------");

//========================================================================
                        var FindBooks2 = from d in db.Books
                                    where d.Pages > 100
                                      orderby d.Pages descending
                                      select d;

                        Console.WriteLine(FindBooks2);

                        Console.WriteLine("--------");
                       
//========================================================================
                        var OrderByBooks1 = from a in db.Authors
                                      orderby a.LastName descending
                                      select a;

                        foreach(Book a in OrderByBooks1){
                            Console.WriteLine(a);
                        }

                        Console.WriteLine("--------");
//========================================================================
                        
                        var OrderByBooks2 = from a in db.Books
                                      orderby a.Title descending
                                      select a;

                        foreach(Book a in OrderByBooks2){
                            Console.WriteLine(a);
                        }
                        

                        Console.WriteLine("--------");
//========================================================================
                        
                        var GroupByBooks1 = from f in db.Books
                                        group f by f.Author.LastName;

                        foreach(Book f in GroupByBooks1){
                            Console.WriteLine(f);
                        }

                        Console.WriteLine("--------");

//========================================================================
                        
                        var GroupByBooks2 = from f in db.Books
                                        orderby f.Author.LastName
                                        group f by f.Publisher;

                        foreach(Book f in GroupByBooks2){
                            Console.WriteLine(f);
                        }
                        
                        Console.WriteLine("--------");

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