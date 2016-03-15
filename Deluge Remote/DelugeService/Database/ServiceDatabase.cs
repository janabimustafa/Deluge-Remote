using DelugeService.Database.Table;
using SQLite;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DelugeService.Database
{
    public partial class ServiceDatabase
    {
        private static ServiceDatabase _instance;

        public static ServiceDatabase Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServiceDatabase();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private SQLiteConnection DbConnection
        {
            get
            {
                return new SQLiteConnection(new SQLitePlatformWinRT(),
                    Path.Combine(ApplicationData.Current.LocalFolder.Path, "service.sqlite"));
            }
        }

        public ServiceDatabase()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            using (var db = DbConnection)
            {
                db.TraceListener = new Helpers.DebugTraceListener();
                db.CreateTable<DelugeConnection>();
            }
        }        

    }
}
