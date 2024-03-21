using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab2_gr2.Models
{
    public class Team
    {
        public int Id {get; set;}
        public string Name {get;set;} = null!;
        public string Country {get;set;} = null!;
        public string City {get;set;} = null!;
        public DateTime FoundingDate {get;set;}

        public virtual ICollection<Match>? HomeMatches {get;set;}
         public virtual ICollection<Match>? AwayMatches {get;set;}
        public virtual League league {get; set;} = null!;
        public virtual ICollection<Player>? player {get;set;}
    }
}