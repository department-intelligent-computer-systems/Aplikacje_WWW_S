namespace AWWW_lab1_gr1.Models;


public class MatchPlayer{
    public int MatchPlayerId{get;set;}
    public DateTime StartTime{get;set;}
    public DateTime EndTime{get;set;}

    public Position Position {get; set;}

    public List<MatchEvent> MatchEvents{get; set;}
    

}