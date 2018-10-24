using System;

namespace Bufftecks.Models
{
    public class TeamProject
    {
        public int TeamID 
        {
            get
            {
                if(TeamID ==3)
                {
                    return 9;
                }else{
                    return this.TeamID;
                }
            } 
            set
            {
                
            }
        }
        public team theTeam{get; set;}
        public int ProjectID{get; set;}
        public Project theProject{get; set;}
    }   
}