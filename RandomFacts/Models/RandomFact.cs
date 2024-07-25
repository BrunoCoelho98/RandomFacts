using Newtonsoft.Json;

namespace RandomFacts.Models
{
    public class RandomFact
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("source_url")]
        public string sourceUrl { get; set; }

        [JsonProperty("language")]
        public string language { get; set; }

        [JsonProperty("permalink")]
        public string permaLink { get; set; }

    }
}
