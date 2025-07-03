using Software_LavaRapido.Negocio;
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
    public partial class UsuarioListarForm : Form
    {

        public UsuarioListarForm()
        {
            InitializeComponent();
        }

        private void PesquisarUsuariobutton_Click(object sender, EventArgs e)
        {
            var list = new UsuarioDAO().listar();
            UsuariodataGridView.DataSource = list;
            Alterarbutton.Enabled = list.Count>0;
        }

        private void NovoUsuariobutton_Click(object sender, EventArgs e)
        {
            new CadastrarUsuarioForm().ShowDialog();
            PesquisarUsuariobutton.PerformClick();
        }

        private void Alterarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuariodataGridView.SelectedRows[0].Cells[0].Value);
            new CadastrarUsuarioForm(id).ShowDialog();
            PesquisarUsuariobutton.PerformClick();
        }

        private void ExcluirButtons_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem realmente certeza que deseja Excluir?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(UsuariodataGridView.SelectedRows[0].Cells[0].Value);
                bool feito = new UsuarioDAO().Excluir(id);
            }
            

        }
    }
}
