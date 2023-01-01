namespace TabbydotNET.Model
{
    public class Checkin
    {
        public string _Object { get; set; }
        public int? Barcode { get; set; }
        public bool? _Checked { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}