using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Adapter
{
    interface IThermometer { double GetCelsius(); }
    class OldThermometer { public double GetFahrenheit() => 98.6; }
    class ThermometerAdapter : IThermometer
    {
        private readonly OldThermometer _old;
        public ThermometerAdapter(OldThermometer old) => _old = old;
        public double GetCelsius() => (_old.GetFahrenheit() - 32) * 5.0 / 9.0;
    }
}




