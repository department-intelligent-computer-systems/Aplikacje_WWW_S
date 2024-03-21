namespace AWWW_lab1_gr1.Models;

public class League {
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Country { get; set; }

    public required int Level { get; set; }
    public List<Team> Teams { get; set; }
}
