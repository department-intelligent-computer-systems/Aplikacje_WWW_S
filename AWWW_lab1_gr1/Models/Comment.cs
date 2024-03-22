using System.Net.NetworkInformation;

namespace AWWW_lab1_gr1.Models
{
    public class Comment{
        public int ID{get; set;}
        public required string Title{get;set;}
        public required string Content{get;set;}

        public int ArticleID {get; set;}

        public virtual Article Article{get; set;}
    }
}