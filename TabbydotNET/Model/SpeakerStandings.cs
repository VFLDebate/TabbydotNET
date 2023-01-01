namespace TabbydotNET.Model
{
    public class SpeakerStandings
    {
        public List<SpeakerStanding> Standings { get; set; }
        public abstract class SpeakerStanding
        {
            public int? Rank { get; set; }
            public bool? Tied { get; set; }
            public List<Object> Metrics { get; set; }
            public string Speaker { get; set; }
        }
    }
}