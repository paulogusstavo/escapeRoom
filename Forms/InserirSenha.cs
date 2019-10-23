using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeRoomProject
{
    public partial class InserirSenha : Form
    {
        private int modulo;

        public InserirSenha(int modulo)
        {
            InitializeComponent();
            this.modulo = modulo;
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void validarSenha(object sender, EventArgs e)
        {
            if (tbSenha.Text.Equals("paulo"))
            {
                this.Dispose();
            }
            else
            {
                lbStatus.Visible = true;
                tbSenha.Text = "";
            }
        }

        private void removeStatus(object sender, KeyPressEventArgs e)
        {
            lbStatus.Visible = false;
        }
    }
}
