using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoomProject
{
    public partial class Form1 : Form
    {
        private int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }
               
        public void setTimer ()
        {
            int hours = 1;
            int minutes = 00;
            int seconds = 00;
            timeLeft = (hours * 3600) + (minutes * 60) + seconds;

            bombTimer.Tick += new EventHandler(timer1_Tick);
            bombTimer.Start();             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                var timespan = TimeSpan.FromSeconds(timeLeft);
                lbTimerBomb.Text = timespan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                bombTimer.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Time's up!", "Time has elapsed", MessageBoxButtons.OK);
            }
        }

        private void iniciarAtividade(object sender, EventArgs e)
        {
            setTimer();
            lbTimerBomb.Click -= iniciarAtividade;
        }

        private void desarmar01(object sender, EventArgs e)
        {
            InserirSenha senha = new InserirSenha();
            senha.ShowDialog();
        }
    }
}
