using System;

namespace MidTerm
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            string output = $"{this.AuthorID}";
            return output;
        }
    }
}