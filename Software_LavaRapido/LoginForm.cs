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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
          bool certo = new UsuarioDAO().Verificacao(UsuariologintextBox.Text,SenhalogintextBox.Text);
            if (certo)
                Close();
            else 
            {
                MessageBox.Show("Usuário ou senha esta incorreta!!!","INVALIDO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Sairbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
