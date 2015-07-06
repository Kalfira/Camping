using Newtonsoft.Json;

namespace RESTfulTestful
{
    public class RepoJson
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("owner")]
        public Owner Owner { get; set; }
    }

    public class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
