using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DelugeService.Helpers
{
    public class JResponse : JObject
    {
        public JResponse(string data)
        {
            JObject r = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Include });
            foreach (KeyValuePair<string, JToken> kvp in r)
            {
                this.Add(kvp.Key, kvp.Value);
            }
        }
        public JToken Result => this["result"];

        public string ErrorString => this["error"]["message"].ToString();

        public bool HasError => this["error"].HasValues;
    }
}
