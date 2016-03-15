using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Helpers
{
    [JsonObject]
    public class JRequest
    {
        public string method { get; set; }
        public object[] @params { get; set; }
        public int id { get; set; }

        public JRequest()
        {
            this.id = new Random().Next();
        }
    }
}
