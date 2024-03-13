using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace AWWW_lab1_gr5.Controllers
{
    public class Tag
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public virtual ICollection<Article> Articles{get;set;}

    }
}