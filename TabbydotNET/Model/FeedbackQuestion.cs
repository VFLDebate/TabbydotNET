namespace TabbydotNET.Model
{
    public class FeedbackQuestion
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public List<string> Choices { get; set; }
        public int? Seq { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
        public bool? FromAdj { get; set; }
        public string AnswerType { get; set; }
        public bool? Required { get; set; }
        public object MinValue { get; set; }
        public object MaxValue { get; set; }
    }
}