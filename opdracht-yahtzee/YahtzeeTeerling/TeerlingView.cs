using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class TeerlingView : UserControl
    {
        TeerlingController _controller;

        // Constructor met bovenliggende controller als parameter
        public TeerlingView( TeerlingController controller)
        {
            // Vang het controller argument op zodat de rest van de view-methodes
            // de controller-methodes kunnen aanspreken
            _controller = controller;
            InitializeComponent();
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
        }

        // Wanneer er op de werpknop wordt geklikt
        private void werpButton_Click(object sender, EventArgs e)
        {
            // Smijt met de teerling 
            // (methode staat in controller)
                _controller.werpTeerling();

                // Waarde van de teerling ophalen uit het model
                teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
          toggleEnable();
        }

        public void toggleEnable()
        {
          if (_controller._model.AantalOgen != 0)
          {
            if (_controller._model.Enabled)
            {
              teerlingLabel.BackColor = System.Drawing.Color.IndianRed;
              //werpButton.Enabled = false;
              _controller._model.Enabled = false;
            }
            else
            {
              teerlingLabel.BackColor = System.Drawing.Color.Transparent;
              //werpButton.Enabled = true;
              _controller._model.Enabled = true;
            }
          }
        }

        public void update()
        {
            teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }
        public void resetLabel()
        {
          teerlingLabel.Text = "";
          teerlingLabel.BackColor = System.Drawing.Color.Transparent;
          //werpButton.Enabled = true;
          _controller._model.Enabled = true;
        }
    }
}
