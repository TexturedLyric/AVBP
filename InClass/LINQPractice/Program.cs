using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
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
                                    FirstName = "Michael",
                                    LastName = "Matthews",
                                    Phone = "000-000-0001",
                                    Email = "MM@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Laith",
                                    LastName = "Alfaloujeh",
                                    Phone = "000-000-0002",
                                    Email = "LA@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Jeffry",
                                    LastName = "Babb",
                                    Phone = "000-000-0003",
                                    Email = "JB@Buffs.edu",
                                    Role = "Professor",
                                },
                                new Student()
                                {
                                    FirstName = "Mekkala",
                                    LastName = "Bourapa",
                                    Phone = "000-000-0004",
                                    Email = "MB@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Charles",
                                    LastName = "Coufal",
                                    Phone = "000-000-0005",
                                    Email = "CC@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "John",
                                    LastName = "Cunningham",
                                    Phone = "000-000-0006",
                                    Email = "JC@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Michael",
                                    LastName = "Hayes",
                                    Phone = "000-000-0007",
                                    Email = "MH@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Aaron",
                                    LastName = "Hebert",
                                    Phone = "000-000-0008",
                                    Email = "AH@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "YiFu",
                                    LastName = "Ji",
                                    Phone = "000-000-0009",
                                    Email = "YFJ@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Todd",
                                    LastName = "Kile",
                                    Phone = "000-000-0010",
                                    Email = "TK@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Mara",
                                    LastName = "Kinoff",
                                    Phone = "000-000-0011",
                                    Email = "MK@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Cesareo",
                                    LastName = "Lona",
                                    Phone = "000-000-0012",
                                    Email = "CL@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Mason",
                                    LastName = "McCollum",
                                    Phone = "000-000-0013",
                                    Email = "MMC@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Alexander",
                                    LastName = "McDonald",
                                    Phone = "000-000-0014",
                                    Email = "AM@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Catherine",
                                    LastName = "McGovern",
                                    Phone = "000-000-0015",
                                    Email = "CM@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Phelps",
                                    LastName = "Merrell",
                                    Phone = "000-000-0016",
                                    Email = "PM@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Quan",
                                    LastName = "Nguyen",
                                    Phone = "000-000-0017",
                                    Email = "QN@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Alexander",
                                    LastName = "Roder",
                                    Phone = "000-000-0018",
                                    Email = "AR@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Amy",
                                    LastName = "Saysouriyosack",
                                    Phone = "000-000-0019",
                                    Email = "AS@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Claudia",
                                    LastName = "Silva",
                                    Phone = "000-000-0020",
                                    Email = "CS@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Gabriela",
                                    LastName = "Valenzuela",
                                    Phone = "000-000-0021",
                                    Email = "GV@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Kayla",
                                    LastName = "Washington",
                                    Phone = "000-000-0022",
                                    Email = "KW@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Matthew",
                                    LastName = "Webb",
                                    Phone = "000-000-0023",
                                    Email = "MW@Buffs.edu",
                                    Role = "student",
                                },
                                new Student()
                                {
                                    FirstName = "Cory",
                                    LastName = "Williams",
                                    Phone = "000-000-0024",
                                    Email = "CW@Buffs.edu",
                                    Role = "student",
                                }
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
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
