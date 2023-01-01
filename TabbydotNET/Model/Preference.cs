namespace TabbydotNET.Model
{
    public class Preference
    {
        public string Section { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string _Default { get; set; }
        public string Value { get; set; }
        public string VerboseName { get; set; }
        public string HelpText { get; set; }
        public string AdditionalData { get; set; }
        public string Field { get; set; }
    }
}