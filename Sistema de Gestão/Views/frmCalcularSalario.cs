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
            dgv_Pessoas.DataSource = Controller.Banco.ObterPessoasIdNome();
            dgv_Pessoas.Columns[0].Width = 50;
            dgv_Pessoas.Columns[1].Width = 100;
        }
        private void dgv_Pessoas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                Controller.Banco.ObterDadosPessoas(vId);
                dt = Controller.Banco.ObterDadosPessoas(vId);
                tb_pessoa.Text = dt.Rows[0].Field<string>("t_nome").ToString();
                tb_categoria.Text = dt.Rows[0].Field<string>("t_categoria").ToString();
                tb_salariob.Text = dt.Rows[0].Field<string>("t_salarioB").ToString();
            }
            if (tb_categoria.Text.Equals("Advogado"))
            {
                lbExtra1.Text = "Processos Ganhos";
                lbExtra2.Visible = false;
                tb_Extra2.Visible = false;
            }
            else if (tb_categoria.Text.Equals("Cozinheiro"))
            {
                lbExtra1.Text = "Horas Trabalhadas";
                lbExtra2.Visible = false;
                tb_Extra2.Visible = false;
            }
            else if (tb_categoria.Text.Equals("Vendedor"))
            {
                lbExtra2.Visible = true;
                tb_Extra2.Visible = true;
                lbExtra1.Text = "Dias Trabalhados";
                lbExtra2.Text = "Percentual sobre Vendas";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if ((tb_Extra1 == null) || (tb_Extra2 == null))
            {
                double salariobase = 0.00;
                double extra1 = 0.00;
                double extra2 = 0.00;
                double salario = 0.00;

                if (tb_categoria.Text.Equals("Advogado"))
                {
                    salariobase = double.Parse(tb_salariob.Text);
                    extra1 = double.Parse(tb_Extra1.Text);
                    //extra2 = double.Parse(tb_Extra2.Text);

                    salario = salariobase * extra1;

                    lbresposta.Text = "O salario de " + tb_pessoa.Text + " é :" + salario;

                }
                else if (tb_categoria.Text.Equals("Cozinheiro"))
                {
                    salariobase = double.Parse(tb_salariob.Text);
                    extra1 = double.Parse(tb_Extra1.Text);
                    //extra2 = double.Parse(tb_Extra2.Text);

                    salario = salariobase * extra1;

                    lbresposta.Text = "O salario de " + tb_pessoa.Text + " é :" + salario;

                }
                else if (tb_categoria.Text.Equals("Vendedor"))
                {
                    salariobase = double.Parse(tb_salariob.Text);
                    extra1 = double.Parse(tb_Extra1.Text);
                    extra2 = double.Parse(tb_Extra2.Text);

                    salario = salariobase * extra1 + (5 * extra2 / 100);

                    lbresposta.Text = "O salario de " + tb_pessoa.Text + " é :" + salario;
                }
            }
            else
            {
                MessageBox.Show("Obrigatorio preencher todos os campos!");
            }
            
        }
    }
}
