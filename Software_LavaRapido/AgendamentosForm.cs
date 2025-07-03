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
    public partial class AgendamentosForm : Form
    {
        LimpezaDAO limpezaDAO = new LimpezaDAO();
        ClienteDAO clienteDAO = new ClienteDAO();
        VeiculoDAO veiculoDAO = new VeiculoDAO();
        Limpeza limpeza = null;

        public AgendamentosForm()
        {
            InitializeComponent();
            Application.DoEvents();

            ListarClientes_Veiculos();

            this.Name = "NOVO AGENDAMENTO";
            limpeza = new Limpeza();
        }

        public AgendamentosForm(int ID)
        {
            InitializeComponent();
            Application.DoEvents();

            ListarClientes_Veiculos();

            this.Name = "Alterar Agendamento";
            limpeza = limpezaDAO.Buscar(ID);
            ClientecomboBox.SelectedValue = limpeza.IDCliente;
            ModelocomboBox.SelectedValue = limpeza.PlacaCarro;
            DIAdateTimePicker.Text = limpeza.DiaAgendado.Date.ToString();
            HORAdateTimePicker.Text = limpeza.HorarioAgendado.TimeOfDay.ToString();
            ValornumericUpDown.Value = limpeza.Valor_Limpeza;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //Lista Clientes e carros para o combo
        public void ListarClientes_Veiculos() 
        {
            var list = veiculoDAO.ListarVeiculoParaCombo();
            ModelocomboBox.DataSource = list;
            ModelocomboBox.DisplayMember = "Placa";
            ModelocomboBox.ValueMember = "ID";

            var list2 = clienteDAO.ListarParaCombo();
            ClientecomboBox.DataSource = list2;
            ClientecomboBox.DisplayMember = "Nome";
            ClientecomboBox.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var itemSelecionado = (Veiculo)ModelocomboBox.SelectedItem; 
            limpeza.PlacaCarro = itemSelecionado.Placa;
            limpeza.IDCliente = Convert.ToInt32(ClientecomboBox.SelectedValue);
            limpeza.Valor_Limpeza = ValornumericUpDown.Value;
            limpeza.DiaAgendado = DIAdateTimePicker.Value;
            limpeza.HorarioAgendado = HORAdateTimePicker.Value;

            bool salvo = limpezaDAO.Salvar(limpeza);

            if (salvo) 
            {
                Close();
            }
        }

        private void ModelocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
