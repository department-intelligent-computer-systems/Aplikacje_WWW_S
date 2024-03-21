using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab2_gr2.Models
{
    public class Position
    {
        public int Id {get; set;}
        public string Name {get; set;} = null!;

        public virtual ICollection<MatchPlayer>? matchPlayers {get;set;}
        public virtual ICollection<Player>? player {get;set;}
    }
}