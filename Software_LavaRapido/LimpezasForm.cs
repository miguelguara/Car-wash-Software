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
    public partial class LimpezasForm : Form
    {
        public LimpezasForm()
        {
            InitializeComponent();
        }

        private void Limpezasbutton_Click(object sender, EventArgs e)
        {
            var list = new LimpezaDAO().Listar();
            LimpezasdataGridView.DataSource = list;
            AlterarAgebutton.Enabled = list.Count > 0;
        }

        private void ExcluirAGEbutton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem realmente certeza que deseja Excluir?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                int id = Convert.ToInt32(LimpezasdataGridView.SelectedRows[0].Cells[0].Value);
                bool feito = new LimpezaDAO().EXCLUIR(id);
            }   
            Limpezasbutton.PerformClick();
        }

        private void NovoAGEbutton_Click(object sender, EventArgs e)
        {
           new AgendamentosForm().ShowDialog();
            Limpezasbutton.PerformClick(); 
        }

        private void AlterarAgebutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(LimpezasdataGridView.SelectedRows[0].Cells[0].Value);
            new AgendamentosForm(ID).ShowDialog();
            Limpezasbutton.PerformClick();
        }
    }
}
