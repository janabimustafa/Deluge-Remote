using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using DelugeService.Helpers;
using System.Threading.Tasks;

namespace DelugeRemoteTest
{
    [TestClass]
    public class RpcClientTest
    {
        [TestMethod]
        public async Task TestRPCRequests()
        {
            RpcClient client = new RpcClient(new DelugeService.Database.Table.DelugeConnection(PrivateInfo.Host, Password: PrivateInfo.Password, Port: PrivateInfo.Port));
            var response = await client.SendMessage("system.listMethods");
            Assert.IsNotNull(response);
            Assert.IsFalse(response.HasError);
        }
    }
}
