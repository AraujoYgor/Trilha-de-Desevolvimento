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
    public partial class Cadastro_de_Filhos : Form
    {
        public Cadastro_de_Filhos()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Filhos_Load(object sender, EventArgs e)
        {
            string vqueryCBpais = @"SELECT n_id_pessoa, t_nome, t_sobrenome FROM tb_pessoas WHERE b_filhos = 1 ORDER BY n_id_pessoa";
            cb_pais.Items.Clear();
            cb_pais.DataSource = Banco.dql(vqueryCBpais);
            cb_pais.DisplayMember = "t_nome";
            cb_pais.ValueMember = "n_id_pessoa";


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Filhos filhos = new Filhos();

            string vqueryFilhos = String.Format(@"
                INSERT INTO tb_filhos 
                    (t_pai, t_nome, t_idade, t_sexo)
                VALUES 
                    ('{0}','{1}','{2}','{3}')
                ",cb_pais.SelectedValue.ToString(), tb_nomefilho.Text, tb_idadefilho.Text, tb_sexofilho.Text);

            Banco.dml(vqueryFilhos);
            MessageBox.Show("O filho de, " + cb_pais.Text+ "  foi inserido, com sucesso!");

        }
    }
}
