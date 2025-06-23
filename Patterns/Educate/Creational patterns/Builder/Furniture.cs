using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Furniture
    {
        public int ChairCount { get; set; }
        public string Info { get; set; }

        public int TableCount { get; set; }
        public bool HasShelf { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
    }

}
