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
    public partial class Gestao_de_Pessoas : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public Gestao_de_Pessoas()
        {
            InitializeComponent();
        }

        private void Gestao_de_Pessoas_Load(object sender, EventArgs e)
        {
            dgw_pais.DataSource = Banco.ObterPessoasIdNomeCategoria();
            dgw_pais.Columns[0].Width = 50;
            dgw_pais.Columns[1].Width = 107;
            dgw_pais.Columns[2].Width = 100;

            
           // dgw_Filhos.DataSource = Banco.ObterFilhosPessoas(pId);
           // dgw_Filhos.Columns[0].Width = 50;
        }

        private void dgw_pais_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Banco.ObterDadosPessoas(vId);
                dt = Banco.ObterDadosPessoas(vId);
                tb_id.Text = dt.Rows[0].Field<Int64>("n_id_pessoa").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                tb_sobrenome.Text = dt.Rows[0].Field<string>("t_sobrenome").ToString();
                cb_sexo.Text = dt.Rows[0].Field<string>("t_sexo").ToString();
                cb_cat.Text = dt.Rows[0].Field<string>("t_categoria").ToString();
                tb_salariob.Text = dt.Rows[0].Field<string>("t_salarioB").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("t_email").ToString();
                mtb_cpf.Text = dt.Rows[0].Field<string>("t_cpf").ToString();
                tb_cep.Text = dt.Rows[0].Field<string>("t_cep").ToString();
                tb_logradouro.Text = dt.Rows[0].Field<string>("t_endereco").ToString();
                tb_num.Text = dt.Rows[0].Field<string>("t_num").ToString();
                tb_cidade.Text = dt.Rows[0].Field<string>("t_cidade").ToString();
                tb_uf.Text = dt.Rows[0].Field<string>("t_uf").ToString();
                tb_pais.Text = dt.Rows[0].Field<string>("t_pais").ToString();
                tb_bairro.Text = dt.Rows[0].Field<string>("t_bairro").ToString();
                cb_filho.Checked = dt.Rows[0].Field<Boolean>("b_filhos");
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("t_foto");
            }

            DataGridView dgv1 = (DataGridView)sender;
            int contLinhas1 = dgv.SelectedRows.Count;
            if (contLinhas1 > 0)
            {

                DataTable dt1 = new DataTable();
                string pId = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                dt1 = Banco.ObterFilhosPessoas(pId);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Cadastro_de_Pessoas cadastro_De_Pessoas = new Cadastro_de_Pessoas();
            cadastro_De_Pessoas.ShowDialog();
        }

        private void tn_foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("O arquivo ja existe, deseja subistituir", "Subistituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pb_foto.ImageLocation = origemCompleto;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }



        }

        private void tbn_pes_cep_Click(object sender, EventArgs e)
        {
            if (tb_cep.Text == "")
            {
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
    }
}
