using System.Text.Json.Serialization;

namespace TabbyAPI
{
    public class Schemas
    {
        //Get Classes
        public class Institution
        {
            public int? Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Region { get; set; }
        }

        public class TournamentInstitution
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Region { get; set; }
            public string[] Teams { get; set; }
            public string[] Adjudicators { get; set; }
        }

        public class Tournament
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string[] CurrentRounds { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public int Sequence { get; set; }
            public string Slug { get; set; }
            public bool IsActive { get; set; }
        }

        public class Checkin
        {
            public string Object { get; set; }
            public int Barcode { get; set; }
            public bool Checked { get; set; }
            public string TimeStamp { get; set; }
        }

        public class Adjudicator
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool Anonymous { get; set; }
            public string Pronouns { get; set; }
            public string Institution { get; set; }
            public float BaseScore { get; set; }
            public bool Breaking { get; set; }
            public bool Trainee { get; set; }
            public bool Independent { get; set; }
            public bool AdjudicationCore { get; set; }
            public string[] InstitutionConflicts { get; set; }
            public string[] TeamConflicts { get; set; }
            public string[] AdjudicatorConflicts { get; set; }
            public string UrlKey { get; set; }
            public Dictionary<string, string> Links { get; set; }
        }

        public class MotionRound
        {
            public string Round { get; set; }
            public int Sequence { get; set; }
        }

        public class Motion
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public MotionRound Rounds { get; set; }
            public string Text { get; set; }
            public string Reference { get; set; }
            public string InfoSlide { get; set; }
        }

        public class RoundMotion
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Text { get; set; }
            public string Reference { get; set; }
            public string InfoSlide { get; set; }
        }

        public class Round
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string BreakCategory { get; set; }
            public RoundMotion Motions { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public int Sequence { get; set; }
            public bool IsCompleted { get; set; }
            public string Name { get; set; }
            public string Abbreviation { get; set; }
            public string[] Stage { get; set; }
            public string[] DrawType { get; set; }
            public string[] DrawStatus { get; set; }
            public float FeedbackWeight { get; set; }
            public bool IsSilent { get; set; }
            public bool IsMotionsReleased { get; set; }
            public string StartsAt { get; set; }
            public int Weight { get; set; }
        }

        public class Speaker
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool IsAnonymous { get; set; }
            public string Pronouns { get; set; }
            public string[] Categories { get; set; }
            public string UrlKey { get; set; }
            [JsonPropertyName("_links")] public Dictionary<string, string> Links { get; set; }
        }

        public class Team
        {
            public string Url { get; set; }
            public int Id { get; set; }
            public string Reference { get; set; }
            public string ShortReference { get; set; }
            public string CodeName { get; set; }
            public string Emoji { get; set; }
            public string ShortName { get; set; }
            public string LongName { get; set; }
            public string Institution { get; set; }
            public Speaker[] Speakers { get; set; }
            public bool UseInstitutionPrefix { get; set; }
            public string[] BreakCategories { get; set; }
            public string[] InstitutionConflicts { get; set; }
        }

        public class Venue
        {
            public string Url { get; set; }
            public int Id { get; set; }
            public string[] Categories { get; set; }
            public string DisplayName { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public string Name { get; set; }
            public int Priority { get; set; }
            public string ExternalUrl { get; set; }
        }

        //Post Classes
        public class PostInstitution
        {
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("code")] public string Code { get; set; }
            [JsonPropertyName("region")] public string? Region { get; set; }
        }

        public class PostTournament
        {
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("short_name")] public string ShortName { get; set; }
            [JsonPropertyName("seq")] public int? Sequence { get; set; }
            [JsonPropertyName("slug")] public string Slug { get; set; }
            [JsonPropertyName("active")] public bool IsActive { get; set; }
        }

        public class PostAdjudicator
        {
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("gender")] public string Gender { get; set; }
            [JsonPropertyName("email")] public string Email { get; set; }
            [JsonPropertyName("phone")] public string Phone { get; set; }
            [JsonPropertyName("anonymous")] public bool IsAnonymous { get; set; }
            [JsonPropertyName("pronoun")] public string Pronouns { get; set; }
            [JsonPropertyName("institution")] public string Institution { get; set; }
            [JsonPropertyName("base_score")] public float BaseScore { get; set; }
            [JsonPropertyName("breaking")] public bool IsBreaking { get; set; }
            [JsonPropertyName("trainee")] public bool IsTrainee { get; set; }
            [JsonPropertyName("independent")] public bool IsIndependent { get; set; }
            [JsonPropertyName("adj_core")] public bool IsAdjudicationCore { get; set; }

            [JsonPropertyName("institution_conflicts")]
            public string[] InstitutionConflicts { get; set; }

            [JsonPropertyName("team_conflicts")] public string[] TeamConflicts { get; set; }

            [JsonPropertyName("adjudicator_conflicts")]
            public string[] AdjudicatorConflicts { get; set; }

            [JsonPropertyName("url_key")] public string UrlKey { get; set; }
        }

        public class PostSpeaker
        {
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("gender")] public string Gender { get; set; }
            [JsonPropertyName("email")] public string Email { get; set; }
            [JsonPropertyName("phone")] public string Phone { get; set; }
            [JsonPropertyName("anonymous")] public bool IsAnonymous { get; set; }
            [JsonPropertyName("pronoun")] public string Pronouns { get; set; }
            [JsonPropertyName("categories")] public string[] Categories { get; set; }
            [JsonPropertyName("url_key")] public string UrlKey { get; set; }
        }

        public class PostTeam
        {
            [JsonPropertyName("reference")] public string Reference { get; set; }
            [JsonPropertyName("short_reference")] public string ShortReference { get; set; }
            [JsonPropertyName("code_name")] public string CodeName { get; set; }
            [JsonPropertyName("emoji")] public string Emoji { get; set; }
            [JsonPropertyName("institution")] public string Institution { get; set; }
            [JsonPropertyName("speakers")] public PostSpeaker[] Speakers { get; set; }

            [JsonPropertyName("use_institution_prefix")]
            public bool UseInstitutionPrefix { get; set; }

            [JsonPropertyName("break_categories")] public string[] BreakCategories { get; set; }

            [JsonPropertyName("institution_conflicts")]
            public string[] InstitutionConflicts { get; set; }
        }

        public class PostVenue
        {
            [JsonPropertyName("categories")] public string[] Categories { get; set; }
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("priority")] public int Priority { get; set; }
            [JsonPropertyName("external_url")] public string ExternalUrl { get; set; }
        }
    }
}