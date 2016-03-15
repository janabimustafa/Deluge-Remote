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
        public DelugeConnection() { }
        public DelugeConnection(string Host, ushort Port, bool Https)
        {
            this.Host = Host;
            this.Port = Port;
            this.Https = Https;
        }
    }
}
