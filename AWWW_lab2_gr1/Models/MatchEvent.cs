namespace AWWW_lab2_gr1.Models;
public class MatchEvent
{
  public int Id { get; set; }
  public int Minute { get; set; }

  public EventType EventType { get; set; }
  public Match Match { get; set; }
  public MatchPlayer MatchPlayer { get; set; }
}