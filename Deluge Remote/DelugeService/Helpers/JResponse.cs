using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Helpers
{
    public class JResponse : JObject
    {
        public JResponse(string data)
        {
            JObject r = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(data);
            foreach (KeyValuePair<string, JToken> kvp in r)
            {
                this.Add(kvp.Key, kvp.Value);
            }
        }
        public JToken Result
        {
            get
            {
                return this["result"];
            }
        }

        public string ErrorString
        {
            get
            {
                return this["error"].ToString();
            }
        }

        public bool HasError
        {
            get
            {
                return this["error"] == null;
            }
        }

    }
}
