using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.Model
{
    public class Pawn : Figure
    {
        private bool _notMoved;
    
        public Pawn(Color color) : base(color)
        {
            _name = "Pawn";
            _notMoved = true;
        }

        public override bool CanMove(Point from, Point to)
        {
            if (_notMoved)
            {
                _notMoved = false;
                if (_color == Color.Black)
                {
                    if (from.X-1 == to.X && from.Y == to.Y) return true;
                    else if (from.X-2 == to.X && from.Y == to.Y) return true;
                }
                else
                {
                    if (from.X+1 == to.X && from.Y == to.Y) return true;
                    else if (from.X+2 == to.X && from.Y == to.Y) return true;
                }
                
            }
            else
            {
                if (_color == Color.Black)
                {
                    if (from.X - 1 == to.X && from.Y == to.Y) return true;
                }
                else
                {
                    if (from.X + 1 == to.X && from.Y == to.Y) return true;
                }
            }

            return false;

        }

    }
}
