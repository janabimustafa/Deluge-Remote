using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Data
{
    public class DelugeTorrent
    {
        public int max_download_speed { get; set; }
        public int upload_payload_rate { get; set; }
        public int download_payload_rate { get; set; }
        public int num_peers { get; set; }
        public float ratio { get; set; }
        public int total_peers { get; set; }
        public string state { get; set; }
        public int max_upload_speed { get; set; }
        public int eta { get; set; }
        public string save_path { get; set; }
        public float progress { get; set; }
        public float time_added { get; set; }
        public string tracker_host { get; set; }
        public long total_uploaded { get; set; }
        public long total_done { get; set; }
        public long total_wanted { get; set; }
        public int total_seeds { get; set; }
        public float seeds_peers_ratio { get; set; }
        public int num_seeds { get; set; }
        public string name { get; set; }
        public bool is_auto_managed { get; set; }
        public int queue { get; set; }
        public float distributed_copies { get; set; }
    }

    public class DelugeUpdateResult
    {
        public DelugeStats stats { get; set; }
        public bool connected { get; set; }        
        public Dictionary<string, DelugeTorrent> torrents { get; set; }
        public DelugeFilters filters { get; set; }
    }

    public class DelugeStats
    {
        public int upload_protocol_rate { get; set; }
        public float max_upload { get; set; }
        public int download_protocol_rate { get; set; }
        public int download_rate { get; set; }
        public bool has_incoming_connections { get; set; }
        public int num_connections { get; set; }
        public float max_download { get; set; }
        public int upload_rate { get; set; }
        public int dht_nodes { get; set; }
        public long free_space { get; set; }
        public int max_num_connections { get; set; }
    }
    public class DelugeFilters
    {
        public object[][] state { get; set; }
        public object[][] tracker_host { get; set; }
        public object[][] label { get; set; }
    }

}
