using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestão.Views
{
    public partial class Calcular_Salario : Form
    {
        public Calcular_Salario()
        {
            InitializeComponent();
        }

        private void Calcular_Salario_Load(object sender, EventArgs e)
        {
            string vqueryCBpessoa = @"SELECT n_id_pessoa, t_nome, t_categoria FROM tb_pessoas ORDER BY n_id_pessoa";
            cb_pessoa.Items.Clear();
            cb_pessoa.DataSource = Controller.Banco.dql("");
            cb_pessoa.DisplayMember = "t_nome";
            cb_pessoa.ValueMember = "n_id_pessoa";

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

        }
    }
}
