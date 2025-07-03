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
    public partial class VeiculosForm : Form
    {
        public VeiculoDAO veiculoDAO = new VeiculoDAO();

        public VeiculosForm()
        {
            InitializeComponent();
        }

        private void Pesquisarbutton_Click(object sender, EventArgs e)
        {
            var list = veiculoDAO.Listar(VeiculostextBox.Text);
            VeiculosdataGridView.DataSource = list;
            Alterarbutton.Enabled = list.Count > 0;
        }

        private void Novobutton_Click(object sender, EventArgs e)
        {
            new CadastroVeiculoForm().Show();
            PesquisarVeiculobutton.PerformClick();
        }

        private void Alterarbutton_Click(object sender, EventArgs e)
        {
            //Tive que selecionar a celula 2 pois de ultima hora eu adicionei um ID pra Verificação Porque não consegui resolver pela PLACA
            int id = Convert.ToInt32(VeiculosdataGridView.SelectedRows[0].Cells[2].Value);
            new CadastroVeiculoForm(id).Show();
            PesquisarVeiculobutton.PerformClick();
        }
    }
}
