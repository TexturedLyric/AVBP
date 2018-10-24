using System;

namespace LINQPractice
{
    public class Student
    {
        public int  StudentID{get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Phone {get; set;}
        public string Email {get; set;}
        public string Role {get; set;}

        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName}";
            return output;
        }
    }
}