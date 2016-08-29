using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class User
    {
        string name = "Adrian";

        public override string ToString() => this.name;

        public static Task<string> GetShit()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            return client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
        }
    }
}