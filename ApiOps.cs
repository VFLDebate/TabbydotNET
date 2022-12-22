using System.Net.Http.Json;
using static TabbyAPI.Schemas;
using static TabbyAPI.Configuration;

namespace TabbyAPI
{
    public class ApiOps
    {
        public class Operations
        {
            public static HttpClient client { get; set; } = new HttpClient();
            public static Config config { get; set; } = new Config();

            public class Get
            {
                public static async Task<Institution> Institution(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Institution>($"institutions/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Institution[]> Institutions()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Institution[]>($"institutions");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<TournamentInstitution[]> TournamentInstitutions()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<TournamentInstitution[]>(
                            $"tournaments/{config.TournamentSlug}/institutions");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Tournament> Tournament(string slug)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Tournament>($"tournaments/{slug}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Tournament[]> Tournaments()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Tournament[]>($"tournaments");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Adjudicator> Adjudicator(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Adjudicator>(
                            $"tournaments/{config.TournamentSlug}/adjudicators/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Adjudicator[]> Adjudicators()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Adjudicator[]>(
                            $"tournaments/{config.TournamentSlug}/adjudicators");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Checkin> AdjudicatorCheckin(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Checkin>(
                            $"tournaments/{config.TournamentSlug}/adjudicators/{id}/checkin");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Checkin> SpeakerCheckin(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Checkin>(
                            $"tournaments/{config.TournamentSlug}/speakers/{id}/checkin");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Motion> Motion(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Motion>(
                            $"tournaments/{config.TournamentSlug}/motions/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Motion[]> Motions()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Motion[]>($"tournaments/{config.TournamentSlug}/motions");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Round> Round(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Round>($"tournaments/{config.TournamentSlug}/rounds/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Round[]> Rounds()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Round[]>($"tournaments/{config.TournamentSlug}/rounds");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Speaker> Speaker(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Speaker>(
                            $"tournaments/{config.TournamentSlug}/speaker/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Speaker[]> Speakers()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Speaker[]>(
                            $"tournaments/{config.TournamentSlug}/speakers");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Team> Team(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Team>($"tournaments/{config.TournamentSlug}/teams/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Team[]> Teams()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Team[]>($"tournaments/{config.TournamentSlug}/teams");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Venue> Venue(int id)
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Venue>($"tournaments/{config.TournamentSlug}/venues/{id}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }

                public static async Task<Venue[]> Venues()
                {
                    try
                    {
                        return await client.GetFromJsonAsync<Venue[]>($"tournaments/{config.TournamentSlug}/venues");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }
            }

            public class Post
            {
                public static async Task Institution(PostInstitution institution)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"institutions", institution);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                public static async Task Tournament(PostTournament tournament)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"tournaments", tournament);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                public static async Task Adjudicator(PostAdjudicator adjudicator)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"tournaments/{config.TournamentSlug}/adjudicators", adjudicator);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                public static async Task Speaker(PostSpeaker speaker)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"tournaments/{config.TournamentSlug}/speakers", speaker);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                public static async Task Team(PostTeam team)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"tournaments/{config.TournamentSlug}/teams", team);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                public static async Task Venue(PostVenue venue)
                {
                    try
                    {
                        await client.PostAsJsonAsync($"tournaments/{config.TournamentSlug}/venues", venue);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            //TODO: add necessary Put, Patch and Delete methods
        }
    }
}