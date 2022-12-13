using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.Model
{
    public class GameModel
    {
        private string[,] _color;
        private const int _size = 8;
        private Figure[,] _figures;

        public Figure[,] Figures { get { return _figures; } }
        public int Size { get { return _size; } }
        public string[,] Color { get { return _color; } }

        public event EventHandler<EventArgs>? StepSuccess, StepFailure;

        public GameModel()
        {
            _figures = new Figure[_size,_size];
            _color = new string[_size,_size];
            GenerateMap();
        }

        private void GenerateMap()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (i%2==0)
                    {
                        if (j % 2 == 0)
                        {
                            _color[i, j] = "White";
                        }
                        else
                        {
                            _color[i, j] = "Black";
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            _color[i, j] = "Black";
                        }
                        else
                        {
                            _color[i, j] = "White";
                        }
                    }

                    _figures[i, j] = new Empty();
                    
                }
            }
            _figures[0, 0] = new Pawn(Model.Color.White);
        }

        public void Click(Point from, Point to)
        {
            if (_figures[from.X,from.Y].CanMove(from,to))
            {
                _figures[to.X,to.Y] = _figures[from.X,from.Y];
                StepSuccess?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
