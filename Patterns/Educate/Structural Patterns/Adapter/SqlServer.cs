using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural_Patterns
{
    public class SqlServer
    {
        //Some methods
        private readonly string _conectionString;
        public SqlServer(string conectionString)
        {
            _conectionString = conectionString;
        }

        public void ConnectToSql()
        {
            Console.WriteLine($"You were connected to {_conectionString}");
        }
    }
}
