namespace TabbydotNET.Model
{
    public class Tournament
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public List<string> CurrentRounds { get; set; }
        public Dictionary<string , string> Links { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? Seq { get; set; }
        public string Slug { get; set; }
        public bool? Active { get; set; }
    }
}