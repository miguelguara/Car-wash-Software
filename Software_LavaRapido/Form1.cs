using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_LavaRapido
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
            new LoginForm().ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
            clientesForm.WindowState = FormWindowState.Maximized;
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiculosForm veiculosForm = new VeiculosForm();
            veiculosForm.MdiParent = this;
            veiculosForm.Show();
            veiculosForm.WindowState = FormWindowState.Maximized;
        }

        private void limpezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpezasForm limpezasForm = new LimpezasForm();
            limpezasForm.MdiParent = this;
            limpezasForm.Show();
            limpezasForm.WindowState = FormWindowState.Maximized;
        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioListarForm usuarioListarForm = new UsuarioListarForm();
            usuarioListarForm.MdiParent = this;
            usuarioListarForm.Show();
            usuarioListarForm.WindowState = FormWindowState.Maximized;
        }
    }
}