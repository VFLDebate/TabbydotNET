namespace TabbydotNET.Model
{
    public class SpeakerCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? Seq { get; set; }
        public int? Limit { get; set; }
        public bool? _Public { get; set; }
        public string Url { get; set; }
        public Dictionary<string , string> Links { get; set; }
    }
}