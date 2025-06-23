using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Memento2
{
    public class Snapshot
    {
        public string SystemType { get; private set; }

        public Snapshot(string s) { SystemType = s; }
    }
}
