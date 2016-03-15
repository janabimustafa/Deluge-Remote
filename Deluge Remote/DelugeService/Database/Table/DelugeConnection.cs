using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Database.Table
{
    public class DelugeConnection
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Host { get; set; }
        public ushort Port { get; set; }
        public bool Https { get; set; }
        public string Password { get; set; }

        [Ignore]
        public string Url => string.Format("{0}://{1}:{2}/json", Https ? "https" : "http", Host, Port);

        public DelugeConnection() { }
        public DelugeConnection(string Host, ushort Port = 8112, bool Https = false, string Password = null)
        {
            this.Host = Host;
            this.Port = Port;
            this.Https = Https;
            this.Password = Password;
        }
    }
}
