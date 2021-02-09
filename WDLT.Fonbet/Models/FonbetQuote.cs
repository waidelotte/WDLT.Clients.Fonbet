using Newtonsoft.Json;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetQuote
    {
        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("factorId")]
        public long FactorId { get; set; }

        [JsonProperty("cartQuoteName")]
        public string CartQuoteName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }
    }
}