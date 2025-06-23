using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Memento2
{
    internal class VirtualBox
    {
        public Stack<Snapshot> snapshots = new();

        public void Push(Snapshot sn) => snapshots.Push(sn);
        public Snapshot Pop() => snapshots.Pop();

        public void ShowSnaphotsInfo()
        {
            if (snapshots.Count > 0)
            {
                foreach (Snapshot sn in snapshots)
                {

                    Console.WriteLine($"Snapshot: {sn.SystemType}");
                }
            }
        }
    }
}
