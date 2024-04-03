namespace AWWW_lab1_gr5.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public DateTime BirthDate { get; set; }

        public int TeamId {  get; set; }
        public virtual Team? Team {  get; set; }

        public virtual ICollection<MatchPlayer>? MatchPlayers {  get; set; }

        public virtual ICollection<Position> Positions { get; set; } = null!;
    }
}