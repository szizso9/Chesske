using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.Model
{
    public abstract class Figure
    {
        protected string _name;
        protected Color _color;

        public string Name { get { return _name; } }

        public Color Color { get { return _color; } }

        public abstract bool CanMove(Point from, Point to);

        protected Figure(Color color)
        {
            _color = color;
        }

        

    }
}
