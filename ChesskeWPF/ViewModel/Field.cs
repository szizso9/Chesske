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

       

        public int X { get; set; }

        public int Y { get; set; }

        public int Position { get; set; }

        public DelegateCommand? StepCommand { get; set; }
    }
}
