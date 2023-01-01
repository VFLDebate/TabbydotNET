namespace TabbydotNET.Model
{
    public class Adjudicator
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Anonymous { get; set; }
        public string Institution { get; set; }
        public float? BaseScore { get; set; }
        public bool? Breaking { get; set; }
        public bool? Trainee { get; set; }
        public bool? Independent { get; set; }
        public bool? AdjCore { get; set; }
        public List<string> InstitutionConflicts { get; set; }
        public List<string> TeamConflicts { get; set; }
        public List<string> AdjudicatorConflicts { get; set; }
        public string UrlKey { get; set; }
        public Dictionary<string, string> Links { get; set; }
    }
}