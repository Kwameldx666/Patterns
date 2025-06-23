using Patterns.Repeat.Abstract_Factory_2_.Abstract_Product;
using Patterns.Repeat.Abstract_Factory_2_.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Repeat.Abstract_Factory_2_
{
    public class Game
    {
        private readonly ISword sword;
        private readonly IOnion onion;

        public Game(IFactory factory)
        {
            {
                this.sword = factory.CreateSword();
                this.onion = factory.CreateOnion();
            }
        }

        public void Play()
        {
            sword.Attack();
            sword.ShowInfo();
            onion.Attack();
            onion.ShowInfo();
        }
    }
}

