using System;

namespace Bufftecks.Models
{
    public class team
    {
        public int teamId{get; set;}
        public string studentList{get; set;}
        public string teamName{get; set;}
        public string projectName{get; set;}//FK project
    }
}