using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoomProject.Forms
{
    public partial class VideoShow : Form
    {
        private int parte;
        private System.Windows.Forms.Timer tmr;

        public VideoShow(int parte)
        {
            InitializeComponent();
            this.parte = parte;
            iniciarVideo();
        }

        private void iniciarVideo ()
        {
            axWindowsMediaPlayer1.stretchToFit = true;
            var strTempFile = "";
            try
            {
                tmr = new System.Windows.Forms.Timer();
                tmr.Tick += delegate {
                    this.Close();
                };
                if (this.parte == 01)
                {
                    strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "video_1.mov");
                    File.WriteAllBytes(strTempFile, Properties.Resources.video_1);
                    tmr.Interval = (int)TimeSpan.FromSeconds(13).TotalMilliseconds;
                }
                else if (this.parte == 02)
                {
                    strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "video_2.mov");
                    File.WriteAllBytes(strTempFile, Properties.Resources.video_2);
                    tmr.Interval = (int)TimeSpan.FromSeconds(17).TotalMilliseconds;
                }
                axWindowsMediaPlayer1.URL = strTempFile;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                tmr.Start();

            }
            catch (Exception ex)
            { }
        }



    }
}
