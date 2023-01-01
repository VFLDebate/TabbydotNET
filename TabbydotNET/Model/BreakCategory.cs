namespace TabbydotNET.Model
{
    public class BreakCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? Seq { get; set; }
        public int? BreakSize { get; set; }
        public bool? IsGeneral { get; set; }
        public int? Priority { get; set; }
        public int? Limit { get; set; }
        public string Rule { get; set; }
        public string Url { get; set; }
        public Dictionary<string , string> Links { get; set; }
    }
}