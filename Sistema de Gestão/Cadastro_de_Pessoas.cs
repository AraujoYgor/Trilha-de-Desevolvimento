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
    public partial class Cadastro_de_Pessoas : Form
    {
        public Cadastro_de_Pessoas()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.t_nome = tb_nome.Text;
            pessoa.t_sobrenome = tb_sobrenome.Text;
            pessoa.t_email = tb_email.Text;
            pessoa.t_sexo = cb_sexo.Text;
            pessoa.t_cpf = mtb_cpf.Text;
            pessoa.t_categoria = cb_cat.Text;
            pessoa.t_salariob = tb_salariob.Text;
            pessoa.t_cep = mtb_cep.Text;
            pessoa.t_endereco = tb_logradouro.Text;
            pessoa.t_numero = tb_num.Text;
            pessoa.t_bairro = tb_bairro.Text;
            pessoa.t_cidade = tb_cidade.Text;
            pessoa.t_uf = tb_uf.Text;
            pessoa.t_pais = tb_pais.Text;
            pessoa.b_filhos = cb_filho.Checked;

            Banco.NovaPessoa(pessoa);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
