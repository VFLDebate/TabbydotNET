namespace TabbydotNET.Model
{
    public class TournamentInstitution
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Region { get; set; }
        public List<string> Teams { get; set; }
        public List<string> Adjudicators { get; set; }
    }
}