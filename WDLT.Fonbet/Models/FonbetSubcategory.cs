using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Fonbet.Enums;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetSubcategory
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num")]
        public EFonbetCategory Category { get; set; }

        [JsonProperty("quotes")]
        public List<FonbetQuote> Quotes { get; set; }
    }
}