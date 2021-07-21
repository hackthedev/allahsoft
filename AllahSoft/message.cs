using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllahSoft
{
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
        }

        private void message_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);

            panel1.BackColor = Color.Transparent;

            this.Opacity = 100;

            player.Width = 0;
            player.Height = 0;
            player.URL = "xp sound.mp3";
            player.Ctlcontrols.play();

            button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
        }

        bool did = false;
        private void button3_MouseHover(object sender, EventArgs e)
        {
            if(did == false)
            {
                noharam n = new noharam();
                n.Show();

                did = true;

                timer1.Start();
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        int count = 0;
        bool did2 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            count++;

            if(count > 5)
            {
                if(did2 == false)
                {
                    smile s = new smile();
                    s.Show();

                    did2 = true;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        int count1 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(count1 == 40)
            {
                Application.Exit();
            }

            count1++;
        }
    }
}
