using System;

namespace MidTerm
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }        
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string AuthorID {get; set; }
        public int Pages {get; set; }


        public override string ToString()
        {
            string output = $"{this.Title} - {this.AuthorID}";
            return output;
        }
    }
}