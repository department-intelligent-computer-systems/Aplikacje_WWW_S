using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public IList<SubjectGroup> SubjectGroups{get;set;}
        public int? TeacherId{get;set;}
        [ForeignKey("TeacherId")]
        public Teacher Teacher{get;set;}
        public IList<Grade>Grades{get;set;}


    }
}