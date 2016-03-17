using DelugeService.Data;
using DelugeService.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService
{
    public partial class DelugeService
    {
        public async Task<TrackerResult> GetTorrentTrackers(DelugeTorrent torrent)
        {
            var response = await client.SendMessage(RpcConstants.RPC_METHOD_STATUS, torrent.unique_id, new object[] { RpcConstants.RPC_TRACKERS, RpcConstants.RPC_TRACKER_STATUS });
            TrackerResult result = response.Result.ToObject<TrackerResult>();
            return result;
        }
        public async Task<FilesResult> GetTorrentFiles(DelugeTorrent torrent)
        {
            var response = await client.SendMessage(RpcConstants.RPC_METHOD_STATUS, torrent.unique_id, new object[] { RpcConstants.RPC_DETAILS, RpcConstants.RPC_FILEPROGRESS, RpcConstants.RPC_FILEPRIORITIES });
            FilesResult result = response.Result.ToObject<FilesResult>();
            return result;
        }

        public async Task RemoveTorrent(DelugeTorrent torrent, bool removeData = false)
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_REMOVE, torrent.unique_id, removeData);            
        }

        public async Task PauseTorrent(DelugeTorrent torrent)
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_PAUSE, new object[] { new object[] { torrent.unique_id } });
            
        }
        public async Task PauseAllTorrents()
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_PAUSE_ALL);
            
        }
        public async Task ResumeTorrent(DelugeTorrent torrent)
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_RESUME, new object[] { new object[] { torrent.unique_id } });
            
        }
        public async Task ResumeAllTorrents()
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_RESUME_ALL);            
        }

        public async Task MoveTorrentLocation(DelugeTorrent torrent, string newLocation)
        {
            await client.SendMessage(RpcConstants.RPC_METHOD_MOVESTORAGE, torrent.unique_id, newLocation);
        }
    }
}
