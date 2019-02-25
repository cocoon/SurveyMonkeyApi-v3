using Newtonsoft.Json;
using System.Collections.Generic;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class Contact : IPageableContainer
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, string> CustomFields { get; set; }
        public string Href { get; set; }
        public bool? UpdateExisting { get; set; }
    }
}