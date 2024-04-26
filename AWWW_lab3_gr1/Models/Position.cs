namespace AWWW_lab3_gr1.Models;

public class Position
{
  public int Id { get; set; }
  public string Name { get; set; }

  public ICollection<Player> Players { get; set; }
  public ICollection<MatchPlayer> MatchPlayers { get; set; }
}