using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Repeat.Memento2
{
    public class OperationSystem
    {
        public string SystemType;
        public OperationSystem(string st) { SystemType = st; }

        public Snapshot MakeSnapshot()
        {
            return new Snapshot(SystemType);
        }

        public void Undo(Snapshot snapsh) => SystemType = snapsh.SystemType;

        public void SetGayRegim()
        {
            SystemType = "gay";
        }

    }
}
