namespace TabbydotNET.Model
{
    public class TeamStandings
    {
        public List<TeamStanding> Standings { get; set; }

        public abstract class TeamStanding
        {
            public int? Rank { get; set; }
            public bool? Tied { get; set; }
            public List<Object> Metrics { get; set; }
            public string Team { get; set; }
        }
    }
}