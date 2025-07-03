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
    public partial class CadastrarUsuarioForm : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario usuario = null;


        public CadastrarUsuarioForm()
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Novo Usuário";
            usuario = new Usuario();
        }

        public CadastrarUsuarioForm(int id) 
        {
            InitializeComponent();
            Application.DoEvents();

            this.Text = "Altere Seus usuários";
            usuario = usuarioDAO.buscar(id);
            UserNametextBox.Text = usuario.Username;
            SenhatextBox.Text = usuario.senha;

        }

        private void Salvarbutton_Click(object sender, EventArgs e)
        {
            usuario.Username = UserNametextBox.Text;
            usuario.senha = SenhatextBox.Text;

            var verificado = usuarioDAO.Salvar(usuario);
            if(verificado)
                Close();
            else 
            {
                MessageBox.Show("Ocorreu um erro ao Tentar Cadastrar Usuario","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fecharbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
