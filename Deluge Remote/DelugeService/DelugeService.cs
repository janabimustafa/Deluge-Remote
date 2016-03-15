using DelugeService.Database.Table;
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
        public DelugeService(DelugeConnection connection)
        {            
            client = new RpcClient(connection);
        }       

    }
}
