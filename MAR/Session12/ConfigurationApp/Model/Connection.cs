using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationApp.Model
{
    internal class Connection
    {
        private string _server;
        private string _database;
        public Connection(string connection)
        {
            _server = GetServer(connection);
            _database = GetDatabase(connection);
        }
        public string Server { get { return _server; } }
        public string DatabaseName { get { return _database; } }
        static string GetServer(string getServerString)
        {
            string[] stringBlocks = getServerString.Split(';');
            foreach (string block in stringBlocks)
            {
                if (block.StartsWith("server="))
                {
                    return block.Substring(7);
                }
            }
            return "ERROR: Server name not present";
        }
        static string GetDatabase(string getDatabaseString)
        {
            string[] stringBlocks = getDatabaseString.Split(';');
            foreach (string block in stringBlocks)
            {
                if (block.StartsWith("database="))
                {
                    return block.Substring(9);
                }
            }
            return "ERROR: Database name not present";
        }
    }
}
