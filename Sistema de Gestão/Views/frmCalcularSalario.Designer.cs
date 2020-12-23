namespace Sistema_de_Gestão.Views
{
    partial class Calcular_Salario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_pessoa = new System.Windows.Forms.ComboBox();
            this.cb_salariob = new System.Windows.Forms.TextBox();
            this.tb_horasTrabalhadas = new System.Windows.Forms.TextBox();
            this.tb_percentualVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_pessoa
            // 
            this.cb_pessoa.FormattingEnabled = true;
            this.cb_pessoa.Location = new System.Drawing.Point(221, 26);
            this.cb_pessoa.Name = "cb_pessoa";
            this.cb_pessoa.Size = new System.Drawing.Size(181, 28);
            this.cb_pessoa.TabIndex = 0;
            // 
            // cb_salariob
            // 
            this.cb_salariob.Location = new System.Drawing.Point(222, 110);
            this.cb_salariob.Name = "cb_salariob";
            this.cb_salariob.ReadOnly = true;
            this.cb_salariob.Size = new System.Drawing.Size(181, 26);
            this.cb_salariob.TabIndex = 1;
            // 
            // tb_horasTrabalhadas
            // 
            this.tb_horasTrabalhadas.Location = new System.Drawing.Point(221, 155);
            this.tb_horasTrabalhadas.Name = "tb_horasTrabalhadas";
            this.tb_horasTrabalhadas.Size = new System.Drawing.Size(181, 26);
            this.tb_horasTrabalhadas.TabIndex = 2;
            // 
            // tb_percentualVenda
            // 
            this.tb_percentualVenda.Location = new System.Drawing.Point(221, 200);
            this.tb_percentualVenda.Name = "tb_percentualVenda";
            this.tb_percentualVenda.Size = new System.Drawing.Size(181, 26);
            this.tb_percentualVenda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pessoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Horas Trabalhadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentagem nas Vendas";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(28, 242);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(375, 39);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(29, 298);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(375, 41);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 345);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(376, 137);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 26);
            this.textBox1.TabIndex = 12;
            // 
            // Calcular_Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 497);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_percentualVenda);
            this.Controls.Add(this.tb_horasTrabalhadas);
            this.Controls.Add(this.cb_salariob);
            this.Controls.Add(this.cb_pessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calcular_Salario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Salario";
            this.Load += new System.EventHandler(this.Calcular_Salario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pessoa;
        private System.Windows.Forms.TextBox cb_salariob;
        private System.Windows.Forms.TextBox tb_horasTrabalhadas;
        private System.Windows.Forms.TextBox tb_percentualVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}