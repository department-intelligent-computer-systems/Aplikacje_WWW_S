namespace AWWW_lab1_gr1.Models;


public class Team {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public DateTime FoundingDate { get; set; } 
    public List<Player>? Players { get; set; }
    public League League { get; set; }
    public virtual ICollection<Match>? HomeMatches { get; set; }
    public virtual ICollection<Match>? AwayMatches { get; set; }
}                                                   