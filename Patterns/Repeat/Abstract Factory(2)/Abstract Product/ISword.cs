using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_
{
    public interface ISword
    {
        public void ShowInfo();
        public void Attack();
        public void Upgrade();
        public void Enchant();
    }
}
