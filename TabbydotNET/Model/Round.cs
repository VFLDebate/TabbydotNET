namespace TabbydotNET.Model
{
    public class Round
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string BreakCategory { get; set; }
        public List<RoundMotions> Motions { get; set; }
        public Dictionary<string , string> Links { get; set; }
        public int? Seq { get; set; }
        public bool? Completed { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Stage { get; set; }
        public string DrawType { get; set; }
        public string DrawStatus { get; set; }
        public float? FeedbackWeight { get; set; }
        public bool? Silent { get; set; }
        public bool? MotionsReleased { get; set; }
        public string StartsAt { get; set; }
        public int? Weight { get; set; }

        public abstract class RoundMotions
        {
            public int? Id { get; set; }
            public string Url { get; set; }
            public int? Seq { get; set; }
            public string Text { get; set; }
            public object Reference { get; set; }
            public object InfoSlide { get; set; }
        }
        
    }
}