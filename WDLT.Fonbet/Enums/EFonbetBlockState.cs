using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WDLT.Clients.Fonbet.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EFonbetBlockState
    {
        Partial,
        Blocked,
        Unblocked
    }
}