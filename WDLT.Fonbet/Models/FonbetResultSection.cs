using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Fonbet.Enums;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetResultSection
    {
        [JsonProperty("events")]
        public List<long> Events { get; set; }

        [JsonProperty("fonbetSportId")]
        public EFonbetSport Sport { get; set; }

        [JsonProperty("fonbetCompetitionId")]
        public long CompetitionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}