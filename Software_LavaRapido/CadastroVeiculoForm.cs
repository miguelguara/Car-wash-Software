using Software_LavaRapido.Mapeamento;
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
    public partial class CadastroVeiculoForm : Form
    {
        public Veiculo veiculo = null;
        public VeiculoDAO veiculoDAO = new VeiculoDAO();

        public CadastroVeiculoForm()
        {
            InitializeComponent();
            Application.DoEvents();
            veiculo = new Veiculo();
            this.Text = "Novo Veiculo";
        }

        public CadastroVeiculoForm(int id) 
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Alterar Veiculo";
            veiculo = veiculoDAO.Buscar(id);
            PlacatextBox.Text = veiculo.Placa;
            ModelotextBox.Text = veiculo.Modelo_Carro;

        }



        private void VeiculoForm_Load(object sender, EventArgs e)
        {

        }

        private void Salvarbutton_Click(object sender, EventArgs e)
        {

            veiculo.Placa = PlacatextBox.Text;
            veiculo.Modelo_Carro = ModelotextBox.Text;

            var verifica = veiculoDAO.Salvar(veiculo);
            if (verifica == true) 
            {
                Close();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao registar o veiculo!","ERROOOOO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fecharbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
