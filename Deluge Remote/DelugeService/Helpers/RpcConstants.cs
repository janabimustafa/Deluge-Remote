using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Helpers
{
    //Constants mostly from https://raw.githubusercontent.com/erickok/transdroid/master/app/src/main/java/org/transdroid/daemon/Deluge/DelugeAdapter.java
    public static class RpcConstants
    {        
        public static string RPC_TORRENTS = "torrents";
        public static string RPC_FILE = "file";
        public static string RPC_FILES = "files";
        public static string RPC_SESSION_ID = "_session_id";

        public static string RPC_METHOD_LOGIN = "auth.login";
        public static string RPC_METHOD_GET = "web.update_ui";
        public static string RPC_METHOD_STATUS = "core.get_torrent_status";
        public static string RPC_METHOD_ADD = "core.add_torrent_url";
        public static string RPC_METHOD_ADD_MAGNET = "core.add_torrent_magnet";
        public static string RPC_METHOD_ADD_FILE = "web.add_torrents";
        public static string RPC_METHOD_REMOVE = "core.remove_torrent";
        public static string RPC_METHOD_PAUSE = "core.pause_torrent";
        public static string RPC_METHOD_PAUSE_ALL = "core.pause_all_torrents";
        public static string RPC_METHOD_RESUME = "core.resume_torrent";
        public static string RPC_METHOD_RESUME_ALL = "core.resume_all_torrents";
        public static string RPC_METHOD_SETCONFIG = "core.set_config";
        public static string RPC_METHOD_SETFILE = "core.set_torrent_file_priorities";
        //public static  string RPC_METHOD_SETOPTIONS = "core.set_torrent_options";
        public static string RPC_METHOD_MOVESTORAGE = "core.move_storage";
        public static string RPC_METHOD_SETTRACKERS = "core.set_torrent_trackers";
        public static string RPC_METHOD_FORCERECHECK = "core.force_recheck";
        public static string RPC_METHOD_SETLABEL = "label.set_torrent";

        public static string RPC_NAME = "name";
        public static string RPC_STATUS = "state";
        public static string RPC_MESSAGE = "message";
        public static string RPC_SAVEPATH = "save_path";
        public static string RPC_MAXDOWNLOAD = "max_download_speed";
        public static string RPC_MAXUPLOAD = "max_upload_speed";

        public static string RPC_RATEDOWNLOAD = "download_payload_rate";
        public static string RPC_RATEUPLOAD = "upload_payload_rate";
        public static string RPC_NUMSEEDS = "num_seeds";
        public static string RPC_TOTALSEEDS = "total_seeds";
        public static string RPC_NUMPEERS = "num_peers";
        public static string RPC_TOTALPEERS = "total_peers";
        public static string RPC_ETA = "eta";
        public static string RPC_TIMEADDED = "time_added";

        public static string RPC_DOWNLOADEDEVER = "total_done";
        public static string RPC_UPLOADEDEVER = "total_uploaded";
        public static string RPC_TOTALSIZE = "total_size";
        public static string RPC_PARTDONE = "progress";
        public static string RPC_LABEL = "label";
        public static string RPC_TRACKERS = "trackers";
        public static string RPC_TRACKER_STATUS = "tracker_status";
        public static string[] RPC_FIELDS_ARRAY = {RPC_NAME, RPC_STATUS, RPC_SAVEPATH, RPC_RATEDOWNLOAD, RPC_RATEUPLOAD, RPC_NUMPEERS,
                    RPC_NUMSEEDS, RPC_TOTALPEERS, RPC_TOTALSEEDS, RPC_ETA, RPC_DOWNLOADEDEVER, RPC_UPLOADEDEVER,
                    RPC_TOTALSIZE, RPC_PARTDONE, RPC_LABEL, RPC_MESSAGE, RPC_TIMEADDED, RPC_TRACKER_STATUS};
        public static string RPC_DETAILS = "files";
        public static string RPC_INDEX = "index";
        public static string RPC_PATH = "path";
        public static string RPC_SIZE = "size";
        public static string RPC_FILEPROGRESS = "file_progress";
        public static string RPC_FILEPRIORITIES = "file_priorities";

        public static string RPC_PAUSEDSTATE = "Paused";
        public static string RPC_DOWNLOADINGSTATE = "Downloading";

    }
    
}
