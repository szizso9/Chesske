using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chesske.Model;

namespace Chesske.ViewModel
{
    public class GameViewModel : ViewModelBase
    {

        private GameModel _model;
        public ObservableCollection<Field> Fields { get; set; }


        public GameViewModel(GameModel model)
        {
            _model = model;
            Fields = new ObservableCollection<Field>();

            for (int i = 0; i < _model.Size; i++)
            {
                for (int j = 0; j < _model.Size; j++)
                {

                    Fields.Add(new Field
                    {
                       
                        Color = _model.Color[i,j],
                        X = i,
                        Y = j,
                        Position = i * _model.Size + j,

                        StepCommand = new DelegateCommand(param => Choose(Convert.ToInt32(param)))

                    });
                }
            }

        }

        private void Choose(int x)
        {
            
        }
    }
}
