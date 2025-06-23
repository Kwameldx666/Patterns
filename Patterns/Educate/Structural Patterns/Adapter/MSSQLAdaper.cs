using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Patterns
{
    class MSSQLAdaper:IDataBaseSql
    {
        private MySqlServer _server;

        public MSSQLAdaper(string connectionString)
        {
            _server = new MySqlServer(connectionString);
        }
        public void Connect()
        {
            _server.ConnectToSql();

        }
    }
}
