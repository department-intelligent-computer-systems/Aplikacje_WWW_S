using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr5.Models
{
    public class Comment
    {
        public int Id {get; set;}
        public string Title {get; set;}=null!;
        public string Content {get; set;}=null!;
    }
}