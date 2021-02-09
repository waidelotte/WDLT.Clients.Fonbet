using System.Collections.Generic;
using Newtonsoft.Json;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetUpdate
    {
        [JsonProperty("packetVersion")]
        public long PacketVersion { get; set; }

        [JsonProperty("fromVersion")]
        public long FromVersion { get; set; }

        [JsonProperty("eventBlocks")]
        public List<FonbetEventBlock> EventBlocks { get; set; }
    }
}