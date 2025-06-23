using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Patterns
{
    class DatabaseAdapter:IDataBaseSql
    {
        private SqlServer _sqlServer ;
        public DatabaseAdapter(string connectionString)
        {
            _sqlServer = new SqlServer(connectionString);
        }
        public void Connect()
        {
            _sqlServer.ConnectToSql();
        }
    }
}
