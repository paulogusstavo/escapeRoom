using ScapeRoomProject.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace ScapeRoomProject
{
    public partial class Home : Form
    {
        private int timeLeft;
        private Session session;

        public Home()
        {
            InitializeComponent();
            this.session = Session.Instance;
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
            }
        }

        private void exibirMensagem (int parte)
        {
            if (parte == 1)
            {
                VideoShow video = new VideoShow(parte);
                video.ShowDialog();
            } else if (parte == 2)
            {
                System.Timers.Timer aTimer = new System.Timers.Timer(500);
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                aTimer.Enabled = true;
                
                this.btMensagem.Visible = true;
            }
            
        }

        void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            btMensagem.BackColor = btMensagem.BackColor == Color.Red ? Color.Black : Color.Red;
        }


        private void iniciarAtividade(object sender, EventArgs e)
        {
            exibirMensagem(1);
            executarSom();
            setTimer();
            lbTimerBomb.Click -= iniciarAtividade;
        }


        private void desarmarModulo(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int modulo = Int32.Parse(button.Name.Split('_')[1]);

            using (InserirSenha senha = new InserirSenha(modulo))
            {
                senha.ShowDialog(this);
            }
        }

        public void mostrarResposta (int modulo)
        {
            if (modulo != 1 && modulo != 7 && modulo != 10)
            { // MODULOS SEM RESPOSTA.
                string resposta = "resposta_" + modulo;
                Label label = this.Controls.Find(resposta, true).FirstOrDefault() as Label;
                label.Text = session.getResposta(modulo);
                label.Visible = true;
            } else
            {
                MessageBox.Show(
                    "Você desarmou este módulo.\n Mas ... não há nenhuma pista por aqui …",
                    "Parabéns !!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
           
            string btName = "btDesarmar_" + modulo;
            Button btDesarme = this.Controls.Find(btName, true).FirstOrDefault() as Button;
            btDesarme.Enabled = false;

            string statusName = "lbStatus_" + modulo;
            Label labelDesarme = this.Controls.Find(statusName, true).FirstOrDefault() as Label;
            labelDesarme.Text = "Desarmado".ToUpper();
            labelDesarme.ForeColor = Color.Green;
        }

        private void setupUI ()
        {
            Color color = Color.FromArgb(150, 0, 0, 0);
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                groupBox.BackColor = color;
            }
            lbTimerBomb.BackColor = color;
        }

        private void executarSom ()
        {
            var file = $"{Path.GetTempPath()}temp.mp3";
            if (!File.Exists(file))
            {
                using (Stream output = new FileStream(file, FileMode.Create))
                {
                    output.Write(Properties.Resources.musicaFundo, 0, Properties.Resources.musicaFundo.Length);
                }
            }
            var wmp = new WindowsMediaPlayer { URL = file };
            wmp.controls.play();
        }

        private void verMensagem(object sender, EventArgs e)
        {
            VideoShow video = new VideoShow(2);
            video.ShowDialog();
            btMensagem.Visible = false;
            executarSom();
        }
    }
}
