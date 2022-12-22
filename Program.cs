using System.Net.Http;
using static TabbyAPI.Configuration;
using static TabbyAPI.ApiOps;

namespace TabbyAPI
{
    public class Program
    {
        static async Task RunAsync()
        {
            var client = new HttpClient();
            Config config = ImportConfig.FromFile();
            
            client.BaseAddress = new Uri(config.Url);
            client.DefaultRequestHeaders.Add("Authorization", $"Token {config.Token}");
            
            Operations.client = client;
            Operations.config = config;
        }
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}

