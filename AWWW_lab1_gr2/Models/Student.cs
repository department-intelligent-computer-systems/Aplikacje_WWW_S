using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr2.Models
{
    public class Student
    {
        public int StudentId {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public int IndexNr {get; set;}
        public DateTime DateOfBirth {get; set;}
        public string? FieldOfStudy {get; set;}
    }
}