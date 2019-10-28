using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ScapeRoomProject
{
    public partial class Home : Form
    {
        private int timeLeft;

        public Home()
        {
            InitializeComponent();
            setupUI();
        }
               
        public void setTimer ()
        {
            int hours = 0;
            int minutes = 60;
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
                lbTimerBomb.Text = timespan.ToString(@"mm\:ss");

                if (timeLeft == 1800)
                    exibirMensagem(2);
            }
            else
            {
                bombTimer.Stop();
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Time's up!", "Time has elapsed", MessageBoxButtons.OK);
            }
        }

        private void exibirMensagem (int parte)
        {
            if (parte == 1) //Inicio da atividade
            {

            } else if (parte == 2) { //Meio do vídeo

            }
        }


        private void iniciarAtividade(object sender, EventArgs e)
        {
            exibirMensagem(1);
            setTimer();
            lbTimerBomb.Click -= iniciarAtividade;
        }


        private void desarmarModulo(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int modulo = Int32.Parse(button.Name.Split('_')[1]);

            InserirSenha senha = new InserirSenha(modulo);
            senha.ShowDialog();
        }

        private void setupUI ()
        {
            status_01.Image = Image.FromFile("C:\\Temp\\PauloZanese\\escapeRoom\\Assets\\red.png");

        }


        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label1.BackColor = label1.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }

        static async Task MainAsync(Object sender)
        {
            var imagem = (PictureBox)sender;
            while (true)
            {
                await Task.Delay(500);
                if (imagem.Image.Equals("red.png"))
                    imagem.Image = null;
                else
                    imagem.Image = Image.FromFile("C:\\Temp\\PauloZanese\\escapeRoom\\Assets\\red.png");
            }     

        }

      
    }
}
