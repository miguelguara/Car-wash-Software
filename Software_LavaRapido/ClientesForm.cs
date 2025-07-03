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
    public partial class ClientesForm : Form
    {

        public ClientesForm()
        {
            InitializeComponent();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            var list = new ClienteDAO().Listar(ClientetextBox.Text);
            ClientedataGridView.DataSource = list;
            buttonAlterar.Enabled = list.Count>0;
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            new Cadastro_ClienteForm().ShowDialog();
            PesquisarButton.PerformClick();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClientedataGridView.SelectedRows[0].Cells[0].Value);
            new Cadastro_ClienteForm(id).ShowDialog();
            PesquisarButton.PerformClick();
            
        }

        private void Excluirbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem realmente certeza que deseja Excluir?","CUIDADO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(ClientedataGridView.SelectedRows[0].Cells[0].Value);
                new ClienteDAO().excluir(id);
                PesquisarButton.PerformClick();
            }   
        }
    }
}
