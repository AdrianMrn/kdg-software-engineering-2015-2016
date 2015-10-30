using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingController
    {
        static int seeder = new Random().Next();
        Random random = new Random(++seeder);
        TeerlingView _view;
        public TeerlingModel _model;

        public TeerlingController()
        {
            _view = new TeerlingView( this );
            _model = new TeerlingModel();
        }

        public TeerlingView getView()
        {
            return _view;
        }

        public void reset()
        {
          _view.resetLabel();
          _model.AantalOgen = 0;
        }

        public void werpTeerling()
        {
            int teerlingGetal = random.Next(1, 7);
            _model.AantalOgen = teerlingGetal;
        }

        public void update()
        {
            _view.update();
        }

    }
}
