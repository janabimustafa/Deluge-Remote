using DelugeService.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService
{
    public partial class DelugeService
    {
        private RpcClient client;
        public DelugeService(string host, ushort port = 8112, bool https = false)
        {            
            client = new RpcClient(host, port, https);
        }       

    }
}
