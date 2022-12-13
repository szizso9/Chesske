using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.Model
{
    public class GameModel
    {
        private string[,] _color;
        private const int _size = 8;

        public int Size { get { return _size; } }
        public string[,] Color { get { return _color; } }

        public GameModel()
        {
            _color = new string[8, 8];
            GenerateMap();
        }

        private void GenerateMap()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (j%2 == 0)
                    {
                        _color[i, j] = "White";
                    }
                    else
                    {
                        _color[i, j] = "Black";
                    }
                }
            }
        }
    }
}
