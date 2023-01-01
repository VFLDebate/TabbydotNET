namespace TabbydotNET.Model
{
    public abstract class Motion
    {
        public int? Id { get; set; }
        public string Url { get; set; }
        public List<MotionRounds> Rounds { get; set; }
        public string Text { get; set; }
        public object Reference { get; set; }
        public object InfoSlide { get; set; }

        public abstract class MotionRounds
        {
            public string Round { get; set; }
            public int? Seq { get; set; }
        }
    }
}