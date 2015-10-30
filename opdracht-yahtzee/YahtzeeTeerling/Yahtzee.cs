using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        private List<TeerlingController> teerlingenLijst = new List<TeerlingController>();
        YahtzeeController _yahtzeeController  = new YahtzeeController();
        public int aantalTeerlingen = 5;
        int maxAantalWorpen = 3;
        int score = 0;

        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            resetBtn.Enabled = false;
            for ( int teerlingNummer = 0; teerlingNummer < aantalTeerlingen; ++teerlingNummer )
            {
                TeerlingController nieuweTeerling = new TeerlingController();
                teerlingenLijst.Add(nieuweTeerling);
            }

                for (int i = 0; i < aantalTeerlingen; ++i)
                {
                    TeerlingController huidigeTeerling = teerlingenLijst[i];
                    TeerlingView huidigeTeerlingview = huidigeTeerling.getView();
                    int xPos = (huidigeTeerlingview.Width * i);
                    huidigeTeerlingview.Location = new Point(xPos, 0);
                    Controls.Add(huidigeTeerlingview);

            Controls.Add(_yahtzeeController.getView());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_yahtzeeController._model.AantalWorpen < maxAantalWorpen)
            {
       
                for (int i = 0; i < aantalTeerlingen; ++i)
                {
                    TeerlingController huidigeTeerling = teerlingenLijst[i];
                    if (huidigeTeerling._model.Enabled)
                    {
                        huidigeTeerling.werpTeerling();
                        huidigeTeerling.update();
                    }
                }
                _yahtzeeController.WorpenUpdate();
            }

            if(_yahtzeeController._model.AantalWorpen == maxAantalWorpen)
            {
                button1.Enabled = false;
                resetBtn.Enabled = true;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          for (int i = 0; i < aantalTeerlingen; i++)
          {
            TeerlingController huidigeTeerling = teerlingenLijst[i];
            score += huidigeTeerling._model.AantalOgen;
            lblScore.Text = "Score: " + score.ToString();
          }

          _yahtzeeController._model.AantalWorpen = 3;
          resetBtn.Enabled = false;
          button1.Enabled = true;
          _yahtzeeController.ResetWorpen();

          for (int i = 0; i < aantalTeerlingen; i++)
          {
            TeerlingController huidigeTeerling = teerlingenLijst[i];
            huidigeTeerling.reset();
          }          
        }

        private void label1_Click(object sender, EventArgs e){}
    }
}
