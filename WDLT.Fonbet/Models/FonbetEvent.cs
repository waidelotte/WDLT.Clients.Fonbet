using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WDLT.Clients.Fonbet.Enums;

namespace WDLT.Clients.Fonbet.Models
{
    public class FonbetEvent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kind")]
        public EFonbetKind Kind { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("sportId")]
        public long TournamentId { get; set; }

        [JsonProperty("sportName")]
        public string Tournament { get; set; }

        [JsonProperty("skId")]
        public EFonbetSport Sport { get; set; }

        [JsonProperty("skName")]
        public string SportName { get; set; }

        [JsonProperty("place")]
        public EFonbetPlace Place { get; set; }

        [JsonProperty("team1Id")]
        public long Team1Id { get; set; }

        [JsonProperty("team2Id")]
        public long Team2Id { get; set; }

        [JsonProperty("team1")]
        public string Team1 { get; set; }

        [JsonProperty("team2")]
        public string Team2 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startTimeTimestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTimeOffset StartTimeTimestamp { get; set; }

        [JsonProperty("subcategories")]
        public List<FonbetSubcategory> Subcategories { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Team1) && !string.IsNullOrEmpty(Team2);
        }
    }
}