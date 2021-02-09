using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetResults
    {
        [JsonProperty("events")]
        public List<FonbetEventResult> Events { get; set; }

        [JsonProperty("sections")] 
        public List<FonbetResultSection> Sections { get; set; }
    }
}