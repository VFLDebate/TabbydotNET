namespace TabbyAPI
{
    public class ImportReplies
    {
        // Import replies from a CSV file
        public class Replies
        {
            public static Reply[] Import(string path = "replies.csv")
            {
                string[] lines = File.ReadAllLines(path);
                Reply[] replies = new Reply[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    Reply reply = new Reply();
                    var args = lines[i].Replace("\"", string.Empty).Split(',');
                    if(args.Length < 13) throw new Exception("Invalid CSV file");
                    
                    reply.TeamName = args[1];
                    reply.TeamEmoji = args[2];
                    reply.Institution = args[3];
                    reply.InstitutionPrefix = args[4];
                    reply.Name1 = args[5];
                    reply.Email1 = args[6];
                    reply.Phone1 = args[7];
                    reply.Diet1 = args[8];
                    reply.Name2 = args[9];
                    reply.Email2 = args[10];
                    reply.Phone2 = args[11];
                    reply.Diet2 = args[12];
                    replies[i] = reply;
                }
                return replies;
            }
            public class Reply
            {
                public string TeamName { get; set; }
                public string TeamEmoji { get; set; }
                public string Institution { get; set; }
                public string InstitutionPrefix { get; set; }
                public string Name1 { get; set; }
                public string Email1 { get; set; }
                public string Phone1 { get; set; }
                public string Diet1 { get; set; }
                public string Name2 { get; set; }
                public string Email2 { get; set; }
                public string Phone2 { get; set; }
                public string Diet2 { get; set; }
            }
        }
    }
}