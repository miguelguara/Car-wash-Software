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
    public partial class Cadastro_ClienteForm : Form
    {
        Cliente cliente = null;
        ClienteDAO clienteDAO = new ClienteDAO();
        //OS construtores!!!!
        public Cadastro_ClienteForm()
        { //Inicia o Construtor
            InitializeComponent();
            Application.DoEvents();
            
            this.Text = "Novo Cliente";
            cliente = new Cliente();
        }
        public Cadastro_ClienteForm(int id)
        { //Inicia o Construtor
            InitializeComponent();
            Application.DoEvents();
            cliente = clienteDAO.Buscar(id);
            NometextBox.Text = cliente.Nome;
            EnderecotextBox.Text = cliente.Endereco;
            CPFtextBox.Text = cliente.CPF;
            this.Text = "Alterar";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fecharbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salvarbutton_Click(object sender, EventArgs e)
        {
            cliente.Nome = NometextBox.Text;
            cliente.Endereco = EnderecotextBox.Text;
            cliente.CPF = CPFtextBox.Text;

            var resposta = clienteDAO.Salvar(cliente);

            if(resposta)
                Close();
            else
            {
                MessageBox.Show("Erro ao Salvar"); 
            }
        }

        private void Cadastro_ClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
