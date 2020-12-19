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
    public partial class Gestao_de_Pessoas : Form
    {
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
                mtb_cep.Text = dt.Rows[0].Field<string>("t_cep").ToString();
                tb_logradouro.Text = dt.Rows[0].Field<string>("t_endereco").ToString();
                tb_num.Text = dt.Rows[0].Field<string>("t_num").ToString();
                tb_cidade.Text = dt.Rows[0].Field<string>("t_cidade").ToString();
                tb_uf.Text = dt.Rows[0].Field<string>("t_uf").ToString();
                tb_pais.Text = dt.Rows[0].Field<string>("t_pais").ToString();
                tb_bairro.Text = dt.Rows[0].Field<string>("t_bairro").ToString();
                cb_filho.Checked = dt.Rows[0].Field<Boolean>("b_filhos");
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("t_nome").ToString();
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
    }
}
