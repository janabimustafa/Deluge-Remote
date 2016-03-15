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

        [TestMethod]
        public async Task TestUpdateMethod()
        {
            DelugeService.DelugeService service = new DelugeService.DelugeService(new DelugeService.Database.Table.DelugeConnection("192.168.1.7", Password: "5546244"));
            var result = await service.Update();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.torrents.Count != 0);
        }
    }
}
