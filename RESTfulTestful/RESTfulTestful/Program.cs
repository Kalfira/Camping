using Newtonsoft.Json;
using System;

namespace RESTfulTestful
{
    class Program
    {
        static void Main(string[] args)
        {
            //RestClient client = new RestClient("https://api.github.com/users/Kalfira/repos");
            RestClient client = new RestClient("https://www.reddit.com/r/funny/about/moderators.json");
            var x = client.MakeRequest();
            var y = JsonConvert.DeserializeObject<Reddit>(x);
            foreach (RedditChildren child in y.data.children)
            {
                string perms = "";
                foreach (string permission in child.mod_permissions)
                {
                    perms += permission + " ";
                }
                Console.WriteLine(child.name + " Permissions: " + perms);
            }
            //foreach (Reddit reddit in y)
            //{
            //    Console.WriteLine(reddit.RedditData.RedditChildren.Name + " Perms: " + reddit.RedditData.RedditChildren.ModPermissions);
            //}
            //var y = JsonConvert.DeserializeObject<List<RepoJson>>(x);
            //foreach (var repoJson in y)
            //{
            //    Console.WriteLine(repoJson.Name + " " + repoJson.Owner.Login);
            //}
            Console.Read();
        }
    }
}
