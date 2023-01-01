namespace TabbydotNET.Model
{
    public class Team
    {
        public string Url { get; set; }
        public int? Id { get; set; }
        public string Reference { get; set; }
        public string ShortReference { get; set; }
        public string CodeName { get; set; }
        public string Emoji { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Institution { get; set; }
        public List<Speaker> Speakers { get; set; }
        public bool? UseInstitutionPrefix { get; set; }
        public List<string> BreakCategories { get; set; }
        public List<string> InstitutionConflicts { get; set; }
    }
}