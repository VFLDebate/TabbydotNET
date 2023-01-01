namespace TabbydotNET.Model
{
    public class Debate
    {
        public string Url { get; set; }
        public int? Id { get; set; }
        public string Venue { get; set; }
        public List<DebateTeams> Teams { get; set; }
        public Adjudicators Adjudicators { get; set; }
        public decimal? Bracket { get; set; }
        public int? RoomRank { get; set; }
        public int? Importance { get; set; }
        public string ResultStatus { get; set; }
        public bool? SidesConfirmed { get; set; }
    }
}