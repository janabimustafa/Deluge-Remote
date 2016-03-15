using DelugeService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService
{
    public partial class DelugeService
    {
        public async Task<DelugeUpdateResult> Update()
        {
            string[] param = { "queue", "name", "total_wanted", "state", "progress", "num_seeds", "total_seeds", "num_peers", "total_peers", "download_payload_rate", "upload_payload_rate", "eta", "ratio", "distributed_copies", "is_auto_managed", "time_added", "tracker_host", "save_path", "total_done", "total_uploaded", "max_download_speed", "max_upload_speed", "seeds_peers_ratio" };
            var response = await client.SendMessage("web.update_ui", new object[] { param, new object() });
            DelugeUpdateResult result = response.Result.ToObject<DelugeUpdateResult>();
            return result;
        }
    }
}
