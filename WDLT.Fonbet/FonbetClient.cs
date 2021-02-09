using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using WDLT.Clients.Base;
using WDLT.Clients.Fonbet.Enums;
using WDLT.Clients.Fonbet.Models;

namespace WDLT.Clients.Fonbet
{
    public class FonbetClient : BaseClient
    {
        public FonbetClient(string host, string userAgent) : base(host, userAgent) {  }

        public Task<FonbetEventList> Events(IEnumerable<EFonbetSport> sports, bool live, EFonbetLang lang = EFonbetLang.En)
        {
            var request = new RestRequest("/line/mobile/showEvents");

            request.AddQueryParameter("lang", lang.ToString().ToLower());
            request.AddQueryParameter("lineType", live ? "live" : "line");

            foreach (var sport in sports)
            {
                request.AddQueryParameter("skId", ((int) sport).ToString());
            }

            return RequestAsync<FonbetEventList>(request);
        }

        public Task<FonbetEventList> Event(long eventId, EFonbetLang lang = EFonbetLang.En)
        {
            var request = new RestRequest("/line/eventView");

            request.AddQueryParameter("lang", lang.ToString().ToLower());
            request.AddQueryParameter("eventId", eventId.ToString());

            return RequestAsync<FonbetEventList>(request);
        }

        public Task<FonbetUpdate> UpdatesFromVersion(bool live, long? fromVersion = null, EFonbetLang lang = EFonbetLang.En)
        {
            var lineString = live ? "live" : "line";
            var fromString = fromVersion == null ? "currentLine" : $"updatesFromVersion/{fromVersion}";

            return RequestAsync<FonbetUpdate>(new RestRequest($"/{lineString}/{fromString}/{lang.ToString().ToLower()}"));
        }

        public Task<FonbetResults> Results(DateTimeOffset date, int timeoutMs = 60000, EFonbetLang lang = EFonbetLang.En)
        {
            var request = new RestRequest("/results/results.json.php");

            request.AddQueryParameter("locale", lang.ToString().ToLower());
            request.AddQueryParameter("lastUpdate", "0");
            request.AddQueryParameter("lineDate", date.ToString("yyyy-MM-dd"));

            request.Timeout = timeoutMs;

            return RequestAsync<FonbetResults>(request);
        }
    }
}
