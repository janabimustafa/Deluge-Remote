using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Helpers
{
    public class RpcClient
    {
        private string host;
        private bool https;
        private ushort port;
        private HttpClient client;
        private string url;
        public RpcClient(string host, ushort port, bool https)
        {
            this.host = host;
            this.port = port;
            this.https = https;
            url = string.Format("{0}://{1}:{2}/json", https ? "https" : "http", host, port); 
            client = new HttpClient();

        }

        public string SendMessage(String methodName, params object[] param)
        {
            //TODO:Check if method exists in database.
            return null;
        }


    }
}
