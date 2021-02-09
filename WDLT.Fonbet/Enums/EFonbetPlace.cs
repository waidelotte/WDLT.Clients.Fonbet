using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Fonbet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EFonbetPlace
    {
        None,
        Live,
        Line
    }
}