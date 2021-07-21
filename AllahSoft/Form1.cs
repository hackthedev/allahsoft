using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllahSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread soundPlayThread;
        private BlockingCollection<string> speakQueue = new BlockingCollection<string>();
        private CancellationTokenSource cancelSoundPlay;
        private int soundPlayCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Width = 0;
            player.Height = 0;

            player.URL = "start.mp3";
            player.Ctlcontrols.play();
        }

        bool did = false;
        bool played = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (did == false && played == true)
            {
                message m = new message();
                m.Show();

                did = true;
            }

            if (played == false)
            {

                this.Hide();
                player.URL = "login.mp3";
                player.Ctlcontrols.play();

                played = true;
            }

        }
    }
}
