using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Gestão
{
    public partial class Cadastro_de_Pessoas : Form
    {
        public Cadastro_de_Pessoas()
        {
            InitializeComponent();
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
            pessoa.t_cep = tb_cep.Text;
            pessoa.t_endereco = tb_logradouro.Text;
            pessoa.t_numero = tb_num.Text;
            pessoa.t_bairro = tb_bairro.Text;
            pessoa.t_cidade = tb_cidade.Text;
            pessoa.t_uf = tb_uf.Text;
            pessoa.t_pais = tb_pais.Text;
            pessoa.b_filhos = cb_filho.Checked;

            Banco.NovaPessoa(pessoa);

            tb_nome.Clear();
            tb_sobrenome.Clear();
            tb_email.Clear();
            mtb_cpf.Clear();
            tb_salariob.Clear();
            tb_logradouro.Clear();
            tb_num.Clear();
            tb_bairro.Clear();
            tb_cidade.Clear();
            tb_uf.Clear();
            tb_pais.Clear();
            tb_cep.Clear();
            mtb_cpf.Clear();
            //cb_cat.Clear();
            //cb_sexo.Clear();
            //cb_sexo
            //pb_foto.Clear();
            cb_filho.Checked = false;
            tb_nome.Focus();


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void pb_foto_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            tb_sobrenome.Enabled = true;
            tb_email.Enabled = true;
            mtb_cpf.Enabled = true;
            tb_salariob.Enabled = true;
            tb_logradouro.Enabled = true;
            tb_num.Enabled = true;
            tb_bairro.Enabled = true;
            tb_cidade.Enabled = true;
            tb_uf.Enabled = true;
            tb_pais.Enabled = true;
            tb_cep.Enabled = true;
            mtb_cpf.Enabled = true;
            cb_cat.Enabled = true;
            cb_sexo.Enabled = true;
            cb_sexo.Enabled = true;
            pb_foto.Enabled = true;
            cb_filho.Enabled = true;
            btn_pes_cep.Enabled = true;
            btn_foto.Enabled = true;
            tb_nome.Clear();
            tb_sobrenome.Clear();
            tb_email.Clear();
            mtb_cpf.Clear();
            tb_salariob.Clear();
            tb_logradouro.Clear();
            tb_num.Clear();
            tb_bairro.Clear();
            tb_cidade.Clear();
            tb_uf.Clear();
            tb_pais.Clear();
            tb_cep.Clear();
            mtb_cpf.Clear();
            //cb_cat.Clear();
            //cb_sexo.Clear();
            //cb_sexo
            //pb_foto.Clear();
            cb_filho.Checked = false;
            tb_nome.Focus();
        }

        private void btn_pes_cep_Click(object sender, EventArgs e)
        {
            if (tb_cep.Text == "") {
                MessageBox.Show("Preencha o CEP");
            }
            else if (tb_cep.MaxLength.Equals(7))
            {
                MessageBox.Show("O cep deve conter 8 digitos");

            }
            else
            {
                try
                {
                    DataSet ds = new DataSet();
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", tb_cep.Text);

                    ds.ReadXml(xml);
                    tb_logradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                    tb_bairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    tb_cidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                    tb_uf.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CEP não encontrado.");
                }
                
            }
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
