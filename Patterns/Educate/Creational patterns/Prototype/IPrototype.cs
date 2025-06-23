using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    public interface IPrototype<T>
    {
        public T Clone();
        public void Reset();
    }
}
