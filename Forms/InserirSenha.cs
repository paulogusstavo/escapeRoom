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
        private Session session;

        public InserirSenha(int modulo)
        {
            InitializeComponent();
            this.modulo = modulo;
            this.session = Session.Instance;
            setupUI();
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void validarSenha(object sender, EventArgs e)
        {
            String senha = session.getSenha(this.modulo);

            if (tbSenha.Text.Equals(senha))
            {
                Home home = (Home)this.Owner;
                home.mostrarResposta(this.modulo);
                this.Dispose();
            }
            else
            {
                lbStatus.Visible = true;
            }
        }

        private void removeStatus(object sender, KeyPressEventArgs e)
        {
            lbStatus.Visible = false;
        }

        private void setupUI ()
        {
            lbTitulo.Text = "Qual a senha do módulo ".ToUpper() + this.modulo + "?";
            btValidar.BackColor = Color.FromArgb(150, 9, 99, 12);
            btCancelar.BackColor = Color.FromArgb(150, 176, 36, 40);

        }
    }
}
