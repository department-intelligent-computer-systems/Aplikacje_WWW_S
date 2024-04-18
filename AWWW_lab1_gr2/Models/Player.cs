using System.Collections.Generic;
using System.ComponentModel;

namespace AWWW_lab1_gr2.Models{
   public class Player{
    public int Id{get;set;}
    public string? FirstName{get;set;}
    public string? LastName{get;set;}
    public string? Country{get;set;}
    public DateTime BirthDate{get;set;}
    public Team Team{get;set;}=null!;
    public ICollection<Position> Position{get;set;}=null!;
   } 
}