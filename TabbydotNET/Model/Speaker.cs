namespace TabbydotNET.Model
{
    public class Speaker
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Anonymous { get; set; }
        public string Pronoun { get; set; }
        public List<string> Categories { get; set; }
        public string UrlKey { get; set; }
        public Dictionary<string , string> Links { get; set; }
    }
}