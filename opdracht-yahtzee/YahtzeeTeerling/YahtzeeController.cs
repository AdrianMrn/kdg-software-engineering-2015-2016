using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeController
    {
        YahtzeeView _view;
        public YahtzeeModel _model;

        public YahtzeeController()
        {
            _view = new YahtzeeView(this);
            _model = new YahtzeeModel();
        }

        public YahtzeeView getView()
        {
            return _view;
        }

        public void AantalWorpen()
        {
            int maxWorp = 3;
            _model.AantalWorpen = maxWorp;
        }

        public void WorpenUpdate()
        {
            _model.AantalWorpen++;
            _view.UpdateView();
        }
        public void ResetWorpen()
        {
          _model.AantalWorpen = 0;
          _view.UpdateView();
        }
    }
}
