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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_salariob = new System.Windows.Forms.TextBox();
            this.tb_Extra1 = new System.Windows.Forms.TextBox();
            this.tb_Extra2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbExtra1 = new System.Windows.Forms.Label();
            this.lbExtra2 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.dgv_Pessoas = new System.Windows.Forms.DataGridView();
            this.tb_pessoa = new System.Windows.Forms.TextBox();
            this.lbresposta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_salariob
            // 
            this.tb_salariob.Location = new System.Drawing.Point(221, 110);
            this.tb_salariob.Name = "tb_salariob";
            this.tb_salariob.ReadOnly = true;
            this.tb_salariob.Size = new System.Drawing.Size(181, 26);
            this.tb_salariob.TabIndex = 2;
            this.tb_salariob.TabStop = false;
            // 
            // tb_Extra1
            // 
            this.tb_Extra1.Location = new System.Drawing.Point(221, 155);
            this.tb_Extra1.Name = "tb_Extra1";
            this.tb_Extra1.Size = new System.Drawing.Size(181, 26);
            this.tb_Extra1.TabIndex = 3;
            // 
            // tb_Extra2
            // 
            this.tb_Extra2.Location = new System.Drawing.Point(221, 200);
            this.tb_Extra2.Name = "tb_Extra2";
            this.tb_Extra2.Size = new System.Drawing.Size(181, 26);
            this.tb_Extra2.TabIndex = 4;
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
            // lbExtra1
            // 
            this.lbExtra1.AutoSize = true;
            this.lbExtra1.Location = new System.Drawing.Point(22, 155);
            this.lbExtra1.Name = "lbExtra1";
            this.lbExtra1.Size = new System.Drawing.Size(144, 20);
            this.lbExtra1.TabIndex = 6;
            this.lbExtra1.Text = "Horas Trabalhadas";
            // 
            // lbExtra2
            // 
            this.lbExtra2.AutoSize = true;
            this.lbExtra2.Location = new System.Drawing.Point(22, 203);
            this.lbExtra2.Name = "lbExtra2";
            this.lbExtra2.Size = new System.Drawing.Size(193, 20);
            this.lbExtra2.TabIndex = 7;
            this.lbExtra2.Text = "Porcentagem nas Vendas";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(29, 246);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(375, 39);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(29, 300);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(375, 41);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
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
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(220, 65);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.ReadOnly = true;
            this.tb_categoria.Size = new System.Drawing.Size(182, 26);
            this.tb_categoria.TabIndex = 1;
            this.tb_categoria.TabStop = false;
            // 
            // dgv_Pessoas
            // 
            this.dgv_Pessoas.AllowUserToAddRows = false;
            this.dgv_Pessoas.AllowUserToDeleteRows = false;
            this.dgv_Pessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Pessoas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Pessoas.Location = new System.Drawing.Point(439, 22);
            this.dgv_Pessoas.MultiSelect = false;
            this.dgv_Pessoas.Name = "dgv_Pessoas";
            this.dgv_Pessoas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pessoas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Pessoas.RowHeadersVisible = false;
            this.dgv_Pessoas.RowHeadersWidth = 62;
            this.dgv_Pessoas.RowTemplate.Height = 28;
            this.dgv_Pessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pessoas.Size = new System.Drawing.Size(232, 460);
            this.dgv_Pessoas.TabIndex = 13;
            this.dgv_Pessoas.SelectionChanged += new System.EventHandler(this.dgv_Pessoas_SelectionChanged);
            // 
            // tb_pessoa
            // 
            this.tb_pessoa.Location = new System.Drawing.Point(219, 22);
            this.tb_pessoa.Name = "tb_pessoa";
            this.tb_pessoa.ReadOnly = true;
            this.tb_pessoa.Size = new System.Drawing.Size(183, 26);
            this.tb_pessoa.TabIndex = 0;
            this.tb_pessoa.TabStop = false;
            // 
            // lbresposta
            // 
            this.lbresposta.AutoSize = true;
            this.lbresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresposta.ForeColor = System.Drawing.Color.Red;
            this.lbresposta.Location = new System.Drawing.Point(29, 348);
            this.lbresposta.Name = "lbresposta";
            this.lbresposta.Size = new System.Drawing.Size(19, 25);
            this.lbresposta.TabIndex = 14;
            this.lbresposta.Text = "-";
            // 
            // Calcular_Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 497);
            this.Controls.Add(this.lbresposta);
            this.Controls.Add(this.tb_pessoa);
            this.Controls.Add(this.dgv_Pessoas);
            this.Controls.Add(this.tb_categoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbExtra2);
            this.Controls.Add(this.lbExtra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Extra2);
            this.Controls.Add(this.tb_Extra1);
            this.Controls.Add(this.tb_salariob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calcular_Salario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Salario";
            this.Load += new System.EventHandler(this.Calcular_Salario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_salariob;
        private System.Windows.Forms.TextBox tb_Extra1;
        private System.Windows.Forms.TextBox tb_Extra2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExtra1;
        private System.Windows.Forms.Label lbExtra2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.DataGridView dgv_Pessoas;
        private System.Windows.Forms.TextBox tb_pessoa;
        private System.Windows.Forms.Label lbresposta;
    }
}