using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetEventResult
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("startTime")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }
}