using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
        private Point p1;
        private Point p2;


        public GameViewModel(GameModel model)
        {

            p1 = new Point(-1, -1);
            p2 = new Point(-1, -1);


            _model = model;
            Fields = new ObservableCollection<Field>();

            _model.StepSuccess += new EventHandler<EventArgs>(ViewModel_StepSuccess);
     


            for (int i = 0; i < _model.Size; i++)
            {
                for (int j = 0; j < _model.Size; j++)
                {

                    Fields.Add(new Field
                    {
                        Figure = _model.Figures[i,j],
                        Name = _model.Figures[i,j].Name,
                        Color = _model.Color[i,j],
                        X = i,
                        Y = j,
                        Position = i * _model.Size + j,

                        StepCommand = new DelegateCommand(param => Choose(Convert.ToInt32(param)))

                    });
                }
            }

            RefreshTable();

        }

        private void ViewModel_StepSuccess(object? sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            foreach (Field f in Fields)
            {
                f.Figure = _model.Figures[f.X, f.Y];
                f.Name= _model.Figures[f.X, f.Y].Name;
            }
        }

        private void Choose(int x)
        {
            if (p1.X == -1)
            {
                Field f = Fields[x];
                p1.X = f.X;
                p1.Y = f.Y;
            }
            else
            {
                Field fa = Fields[x];
                p2.X = fa.X;
                p2.Y = fa.Y;

                if (p1 != p2)
                {
                    _model.Click(p1, p2);
                }

                p1 = new Point(-1, -1);
                p2 = new Point(-1, -1);

            }
        }
    }
}
