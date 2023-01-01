namespace TabbydotNET.Model
{
    public class Venue
    {
        public string Url { get; set; }
        public int? Id { get; set; }
        public List<string> Categories { get; set; }
        public string DisplayName { get; set; }
        public Dictionary<string , string> Links { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string ExternalUrl { get; set; }
    }
}