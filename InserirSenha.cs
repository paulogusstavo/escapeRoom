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
        public InserirSenha()
        {
            InitializeComponent();
        }

        private void cancelar(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
