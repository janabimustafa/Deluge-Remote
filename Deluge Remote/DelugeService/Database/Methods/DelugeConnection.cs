using DelugeService.Database.Helpers;
using DelugeService.Database.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelugeService.Database
{
    public partial class ServiceDatabase
    {
        public List<DelugeConnection> GetAllConnections()
        {
            List<DelugeConnection> connections;
            using (var db = DbConnection)
            {
                db.TraceListener = new DebugTraceListener();
                connections = (from connection 
                               in db.Table<DelugeConnection>()
                               select connection).ToList();                             
            }
            return connections;
        }

        public void SaveConnection(DelugeConnection connection)
        {
            using (var db = DbConnection)
            {
                db.TraceListener = new DebugTraceListener();
                if (connection.Id == 0)
                    db.Insert(connection);
                else
                    db.Update(connection);
            }
        }

        public void RemoveConnection(DelugeConnection connection)
        {
            using (var db = DbConnection)
            {
                db.TraceListener = new DebugTraceListener();
                db.Delete<DelugeConnection>(connection);
            }
        }

        public DelugeConnection GetConnection(int Id)
        {
            DelugeConnection connection;
            using (var db = DbConnection)
            {
                db.TraceListener = new DebugTraceListener();
                connection = (from conn
                             in db.Table<DelugeConnection>()                             
                             where conn.Id == Id
                             select conn).FirstOrDefault();
            }
            return connection;
        }


    }
}
