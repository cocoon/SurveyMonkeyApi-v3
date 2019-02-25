using Newtonsoft.Json;
using System.Collections.Generic;

namespace SurveyMonkey.Containers
{
    [JsonConverter(typeof(TolerantJsonConverter))]
    public class ContacList : IPageableContainer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }
}