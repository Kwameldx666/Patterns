using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Patterns
{
    class MySqlServer
    {
        private readonly string _conectionString;
        public MySqlServer(string conectionString)
        {
            _conectionString = conectionString;
        }

        public void ConnectToSql()
        {
            Console.WriteLine($"You were connected to {_conectionString} this is MSQL");
        }
    }
}
