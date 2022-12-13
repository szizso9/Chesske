using Chesske.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesske.ViewModel
{
    public class Field : ViewModelBase
    {

        
        private string _color;
        private Figure _figure;
        private string _name;


        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }


        public string Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    _color = value;
                    OnPropertyChanged();
                }
            }
        }

        public Figure Figure
        {
            get { return _figure; }
            set
            {
                if (_figure != value)
                {
                    _figure = value;
                    OnPropertyChanged();
                }
            }
        }



        public int X { get; set; }

        public int Y { get; set; }

        public int Position { get; set; }

        public DelegateCommand? StepCommand { get; set; }
    }
}
