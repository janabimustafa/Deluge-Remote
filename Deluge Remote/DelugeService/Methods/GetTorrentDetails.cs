using DelugeService.Data;
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
        public async Task<DelugeUpdateResult> GetTorrentDetails(DelugeTorrent torrent)
        {
            var response = await client.SendMessage(RpcConstants.RPC_METHOD_STATUS, torrent.unique_id, new object[] { RpcConstants.RPC_TRACKERS, RpcConstants.RPC_TRACKER_STATUS });
            DelugeUpdateResult result = response.Result.ToObject<DelugeUpdateResult>();
            return result;
        }
    }
}
