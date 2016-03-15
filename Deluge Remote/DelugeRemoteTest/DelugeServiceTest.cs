using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeRemoteTest
{
    [TestClass]
    public class DelugeServiceTest
    {
        DelugeService.DelugeService service;
        DelugeService.Data.DelugeUpdateResult result;
        public DelugeServiceTest()
        {
            service = new DelugeService.DelugeService(new DelugeService.Database.Table.DelugeConnection("192.168.1.7", Password: "5546244"));            
        }

        [TestMethod]
        public async Task TestUpdateMethod()
        {            
            result = await service.Update();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.torrents.Count != 0);
        }

        [TestMethod]
        public async Task GetTorrentDetailsTest()
        {
            await TestUpdateMethod();
            var updateResult = await service.GetTorrentDetails(result.torrents[result.torrents.Keys.First()]);
            Assert.IsNotNull(updateResult);            
        }
    }
}
