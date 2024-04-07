namespace AWWW_lab1_gr1.Models;
using Microsoft.EntityFrameworkCore;
public class League{
    public int ID{get; set;}
    public required string Name{get; set;}
    public List<Team>? Teams { get; set; }
    public required string Country{get; set;}
    public int Level{get; set;}
}