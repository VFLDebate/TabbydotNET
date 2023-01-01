namespace TabbydotNET.Model
{
    public class Feedback
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Adjudicator { get; set; }
        public string Source { get; set; }
        public string Debate { get; set; }
        public List<FeedbackAnswers> Answers { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Version { get; set; }
        public string SubmitterType { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? ConfirmedTimestamp { get; set; }
        public string IpAddress { get; set; }
        public float? Score { get; set; }
        public bool? Ignored { get; set; }
        public string ParticipantSubmitter { get; set; }
        public bool? PrivateUrl { get; set; }
        public int? Submitter { get; set; }
        public int? Confirmer { get; set; }
        
        public abstract class FeedbackAnswers
        {
            public string Question { get; set; }
            public string Answer { get; set; }
        }
    }
}