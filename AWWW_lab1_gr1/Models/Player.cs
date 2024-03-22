public class Team{
    public int ID{get; set;}
    public required string FirstName{get;set;}
    public required string LastName{get;set;}
    public required string Country{get;set;}
    public required List<Position> Positions { get; set; }

    public List<MatchPlayer>? MatchPlayers { get; set; }

    public required Team Team { get; set; }
    public DateTime BirthDate{get;set;}
}