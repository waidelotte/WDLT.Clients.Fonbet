using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Fonbet.Enums;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetEventBlock
    {
        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("state")]
        public EFonbetBlockState State { get; set; }

        [JsonProperty("factors")]
        public List<long> Factors { get; set; }
    }
}