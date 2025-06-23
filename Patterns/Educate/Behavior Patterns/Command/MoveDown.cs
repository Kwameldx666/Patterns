using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class MoveDown : Command
    {
        private readonly Keyboards _boards;

        // Fix for CS7036: Pass the 'keyboards' parameter to the base class constructor
        public MoveDown(Keyboards board) : base(board)
        {
            _boards = board;
        }

        // Fix for IDE0290: Use primary constructor
        public override void Execute() => _boards.MoveDown();
        public override void Undo() => _boards.MoveUp();
    }
}
