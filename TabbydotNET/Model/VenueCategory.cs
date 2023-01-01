namespace TabbydotNET.Model
{
    public class VenueCategory
    {
        public string Url { get; set; }
        public int? Id { get; set; }
        public List<string> Venues { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayInVenueName { get; set; }
        public bool? DisplayInPublicTooltip { get; set; }
    }
}