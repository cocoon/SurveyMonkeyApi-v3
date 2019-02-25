using Newtonsoft.Json;

namespace SurveyMonkey.Enums
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public enum ContactStatus
    {
        Active,
        Optout,
        Bounced
    }
}