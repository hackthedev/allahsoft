using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllahSoft
{
    public partial class noharam : Form
    {
        public noharam()
        {
            InitializeComponent();
        }

        private void noharam_Load(object sender, EventArgs e)
        {
            player.Width = 0;
            player.Height = 0;
            player.URL = "siren.mp3";
            player.Ctlcontrols.play();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
