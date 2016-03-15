using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DelugeService.Database.Table;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;

namespace DelugeService.Helpers
{
    public class RpcClient
    {
        private HttpClient client;
        private HttpClientHandler handler;
        private DelugeConnection connection;
        private CookieContainer cookies;

        public RpcClient(DelugeConnection connection)
        {
            this.connection = connection;
            InitClient();
            
        }

        private void InitClient()
        {
            handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate, UseCookies = true };
            cookies = new CookieContainer();
            handler.CookieContainer = cookies;
            client = new HttpClient(handler);
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async Task<JResponse> SendRequest(String methodName, params object[] param)
        {
            var request = new JRequest() { method = methodName, @params = param };
            var requestString = JsonConvert.SerializeObject(request);
            var requestContent = new StringContent(requestString, System.Text.Encoding.ASCII, "application/json");           
           
            var responseMessage = await client.PostAsync(connection.RpcUrl, requestContent);
            //responseMessage.EnsureSuccessStatusCode();            
            var responseString = await responseMessage.Content.ReadAsStringAsync();
            return new JResponse(responseString);
        }

        public async Task<JResponse> SendMessage(String methodName, params object[] param)
        {
            if (cookies.Count == 0 && !string.IsNullOrEmpty(connection.Password))
                await Authenticate();
            return await SendRequest(methodName, param);
        }

        private async Task Authenticate()
        {
            var result = await SendRequest("auth.login", connection.Password);
            if(result.HasError || result.Result.ToObject<bool>() == false)
            {
                throw new Exception("Error authenticating with Deluge. Check connection information.");
            }
        }
    }
}
