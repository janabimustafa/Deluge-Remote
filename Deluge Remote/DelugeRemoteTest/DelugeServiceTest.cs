using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelugeService.Helpers;

namespace DelugeRemoteTest
{
    [TestClass]
    public class DelugeServiceTest
    {
        DelugeService.DelugeService service;
        DelugeService.Data.DelugeUpdateResult result;
        public DelugeServiceTest()
        {
            service = new DelugeService.DelugeService(new DelugeService.Database.Table.DelugeConnection(PrivateInfo.Host, Password: PrivateInfo.Password, Port: PrivateInfo.Port));
        }

        [TestMethod]
        public async Task TestUpdateMethod()
        {
            result = await service.Update();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.torrents.Count != 0);
        }

        [TestMethod]
        public async Task GetTorrentFilesTest()
        {
            await TestUpdateMethod();
            var torrentQuery = from torrent
                               in result.torrents.Values
                               where torrent.state == RpcConstants.RPC_DOWNLOADINGSTATE
                               select torrent;
            var updateResult = await service.GetTorrentFiles(torrentQuery.FirstOrDefault());
            Assert.IsNotNull(updateResult);
        }

        [TestMethod]
        public async Task RemoveTorrentTest()
        {
            await TestUpdateMethod();
            var torrentQuery = from torrent
                               in result.torrents.Values
                               where torrent.name.Contains("Ted")
                               select torrent;
            await service.RemoveTorrent(torrentQuery.FirstOrDefault(), false);            
        }

        [TestMethod]
        public async Task PauseTorrentTest()
        {
            await TestUpdateMethod();
            var torrentQuery = from torrent
                               in result.torrents.Values
                               where torrent.state == RpcConstants.RPC_DOWNLOADINGSTATE
                               select torrent;
            await service.PauseTorrent(torrentQuery.FirstOrDefault());            
        }
        [TestMethod]
        public async Task PauseAllTorrentsTest()
        {
            //await TestUpdateMethod();
            //var torrentQuery = from torrent
            //                   in result.torrents.Values
            //                   where torrent.state == RpcConstants.RPC_DOWNLOADINGSTATE
            //                   select torrent;
            await service.PauseAllTorrents();
        }

    }
}
