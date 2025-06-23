using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Builder
{
    public class House
    {
        public string Floor { get; set; }   
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }
        public string Doors { get; set; }

        public override string ToString()
        {
            return $"House with {Floor}, {Walls}, {Roof}, {Windows}, {Doors}";
        }


    }
}
