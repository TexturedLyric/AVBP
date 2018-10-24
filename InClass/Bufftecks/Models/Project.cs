using System;

namespace Bufftecks.Models
{
    public class Project
    {
        public int projectId {get; set;}
        public string  projectName {get; set;}
        public string teamLead {get; set;}
        public DateTime hoursWorked {get; set;}
        public string clientName {get; set;}
        public DateTime deadLine {get; set;}
    }
}