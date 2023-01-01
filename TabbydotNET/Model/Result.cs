namespace TabbydotNET.Model
{
    public class Result
    {
        public List<ResultSheets> Sheets { get; set; }

        public abstract class ResultSheets
        {
            public string Adjudicator { get; set; }
            public List<ResultTeams> Teams { get; set; }

            public abstract class ResultTeams
            {
                public string Side { get; set; }
                public int? Points { get; set; }
                public bool? Win { get; set; }
                public decimal? Score { get; set; }
                public string Team { get; set; }
                public List<ResultSpeeches> Speeches { get; set; }
                
                public abstract class ResultSpeeches
                {
                    public bool? Ghost { get; set; }
                    public decimal? Score { get; set; }
                    public string Speaker { get; set; }
                }
            }
        }
    }
}