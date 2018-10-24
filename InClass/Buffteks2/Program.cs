using System;
using System.Collections.Generic;
using System.Linq;

namespace Buffteks2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    if(!db.Students.Any())
                    {
                        db.Database.EnsureCreated();
                        List<Student> students = new List<Student>()
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
                        

                        db.Students.AddRange(students);

                    }else{
                        var student = db.Students.ToList();
                    }

                    
                    client cl = new client()
                    {
                        ClientID = 1,
                        FirstName = "Jeff",
                        LastName = "Babb",
                        Phone = "123-456-7890",
                        Email = "blah@blah.blah",
                        Role = "Professor",

                    };
                    db.client.Add(cl);

                    project pro = new project()
                    {
                        projectId = 96,
                        projectName = "Project",
                        teamLead = "Michael",
                        hoursWorked = "10",
                        clientName = "Mr. Sir",
                        deadLine = "Dec. 10",

                    };
                    db.project.Add(pro);

                    Orginization Org = new Orginization()
                    {
                        Id = 72,
                        orgName = "Organization",
                        orgPhone = "888-888-8888",
                        orgEmail = "orgemail@email",
                        orgContactList = "Mr. Sir",
                    };
                    db.project.Add(pro);
                    
                    team t = new team()
                    {
                        teamId = 252,
                        studentList = "list",
                        teamName = "BuffT",
                        projectName = "10",
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
