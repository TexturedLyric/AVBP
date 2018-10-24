using System;
using System.Collections.Generic;
using System.Linq;

namespace BuffTeksFinal
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
                    if(!db.Students.Any())
                    {

                        List<Student> Students = new List<Student>()
                            {
                                new Student()
                                {
                                    StudentID = 1,
                                    FirstName = "Michael",
                                    LastName = "Matthews",
                                    Phone = "012-345-6789",
                                    Email = "blahblah@blah.blah",
                                    Role = "student",

                                },
                                new Student()
                                {
                                    StudentID = 2,
                                    FirstName = "John",
                                    LastName = "Doe",
                                    Phone = "012-345-6789",
                                    Email = "blahbl@blah.blah",
                                    Role = "student",

                                },
                                new Student()
                                {
                                    StudentID = 3,
                                    FirstName = "Jane",
                                    LastName = "Doe",
                                    Phone = "012-345-6789",
                                    Email = "blahbla@blah.blah",
                                    Role = "student",

                                },
                            };
                        

                        db.Students.AddRange(Students);

                        db.SaveChanges();

                    }else{
                        var students = db.Students.ToList();

                        var studentFiltered = from s in db.Students
                                                where s.FirstName.Length >= 5
                                                select s;

                        foreach(Student s in studentFiltered)
                        {
                            Console.WriteLine(s);
                        }
                    }

                    
                    Client cl = new Client()
                    {
                        ClientID = 1,
                        FirstName = "Jeff",
                        LastName = "Babb",
                        Phone = "123-456-7890",
                        Email = "blah@blah.blah",

                    };
                    db.client.Add(cl);

                    Project pro = new Project()
                    {
                        ProjectID = 96,
                        ProjectName = "Project",
                        ProjectContact = "Michael",
                    };
                    db.project.Add(pro);

                    Orginization Org = new Orginization()
                    {
                        OrgID = 72,
                        OrgName = "Organization",
                        Phone = "888-888-8888",
                        Email = "orgemail@email",
                    };
                    db.project.Add(pro);
                    
                    Team t = new Team()
                    {
                        TeamID = 252,
                        TeamList = "list",
                        TeamName = "BuffT",
                    };
                    db.project.Add(pro);
                    


                    db.SaveChanges();
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
