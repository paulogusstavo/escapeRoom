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
                if (this.parte == 01)
                {
                    strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "video_1.mp4");
                    File.WriteAllBytes(strTempFile, Properties.Resources.video_1);
                }
                else if (this.parte == 02)
                {
                    strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "video_2.mp4");
                    File.WriteAllBytes(strTempFile, Properties.Resources.video_1);
                }
                axWindowsMediaPlayer1.URL = strTempFile;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            { }
        }



    }
}
