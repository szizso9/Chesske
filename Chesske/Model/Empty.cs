using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.Model
{
    public class Empty : Figure
    {
        public Empty() : base(Color.White)
        {
            _name= string.Empty;
        }

        public override bool CanMove(Point from, Point to)
        {
            return false;
        }


    }
}
