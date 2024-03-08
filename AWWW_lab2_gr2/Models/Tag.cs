using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab2_gr2.Models
{
    public class Tag
    {
        public int Id { get ; set; }
        public string? Name { get; set; }

        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}