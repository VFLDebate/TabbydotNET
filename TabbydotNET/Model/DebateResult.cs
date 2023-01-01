using System.Runtime.InteropServices.JavaScript;

namespace TabbydotNET.Model
{
    public class DebateResult
    {
        public string Url { get; set; }
        public int? Id { get; set; }
        public Result Result { get; set; }
        public string Motion { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Version { get; set; }
        public string SubmitterType { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? ConfirmTimestamp { get; set; }
        public string IpAddress { get; set; }
        public bool? Discarded { get; set; }
        public string ParticipantSubmitter { get; set; }
        public bool? PrivateUrl { get; set; }
        public bool? SingleAdj { get; set; }
        public int? Submitter { get; set; }
        public int? Confirmer { get; set; }
    }
}