using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SurveyMonkey.Containers;
using SurveyMonkey.RequestSettings;

namespace SurveyMonkey
{
    public partial class SurveyMonkeyApi
    {
        public Message CreateMessage(long collectorId, CreateMessageSettings settings)
        {
            string endPoint = String.Format("/collectors/{0}/messages", collectorId);
            var verb = Verb.POST;
            var requestData = Helpers.RequestSettingsHelper.GetPopulatedProperties(settings);
            JToken result = MakeApiRequest(endPoint, verb, requestData);
            DUMPFILE.Dump("JSON_CreateMessage_" + collectorId.ToString() + "-" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt", result.ToString()); // DUMP json to txt
            var message = result.ToObject<Message>();
            return message;
        }
    }
}