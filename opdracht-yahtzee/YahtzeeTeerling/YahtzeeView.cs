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
    public partial class YahtzeeView : UserControl
    {

        YahtzeeController _controller;

        public YahtzeeView( YahtzeeController controller )
        {
            _controller = controller;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
        }

        public void UpdateView()
        {
          lblWorpen.Text = "Aantal keer geworpen: " + _controller._model.AantalWorpen.ToString() + " (max 3)";
        }
    }
}
