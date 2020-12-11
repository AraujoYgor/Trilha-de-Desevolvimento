using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestão
{
    public partial class frm_TelaPrincipal : Form
    {
        public frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void pESSOASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Pessoas cadastro_De_Pessoas = new Cadastro_de_Pessoas();
            cadastro_De_Pessoas.ShowDialog();
        }

        private void fILHOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Filhos cadastro_De_Filhos = new Cadastro_de_Filhos();
            cadastro_De_Filhos.ShowDialog();
        }

        private void pESSOASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gestao_de_Pessoas gestao_De_Pessoas = new Gestao_de_Pessoas();
            gestao_De_Pessoas.ShowDialog();
        }
    }
}
