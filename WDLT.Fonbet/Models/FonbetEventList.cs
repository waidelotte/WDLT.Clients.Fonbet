using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetEventList
    {
        [JsonProperty("events")]
        public List<FonbetEvent> Events { get; set; }
    }
}