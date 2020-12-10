namespace Sistema_de_Gestão
{
    partial class Cadastro_de_Pessoas
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.tbn_pes_cep = new System.Windows.Forms.Button();
            this.tb_logradouro = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.tb_uf = new System.Windows.Forms.TextBox();
            this.tb_pais = new System.Windows.Forms.TextBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.tb_salariob = new System.Windows.Forms.TextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.tn_foto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cb_filho = new System.Windows.Forms.CheckBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(143, 40);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(196, 22);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Location = new System.Drawing.Point(142, 86);
            this.tb_sobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(197, 22);
            this.tb_sobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sobrenome:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(142, 134);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(197, 22);
            this.tb_email.TabIndex = 3;
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(353, 42);
            this.mtb_cep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtb_cep.Mask = "  00.000-000 ";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(91, 22);
            this.mtb_cep.TabIndex = 9;
            // 
            // tbn_pes_cep
            // 
            this.tbn_pes_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_pes_cep.Location = new System.Drawing.Point(452, 42);
            this.tbn_pes_cep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbn_pes_cep.Name = "tbn_pes_cep";
            this.tbn_pes_cep.Size = new System.Drawing.Size(108, 21);
            this.tbn_pes_cep.TabIndex = 10;
            this.tbn_pes_cep.Text = "Pesquisar";
            this.tbn_pes_cep.UseVisualStyleBackColor = true;
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.Location = new System.Drawing.Point(354, 84);
            this.tb_logradouro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(161, 22);
            this.tb_logradouro.TabIndex = 11;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(520, 84);
            this.tb_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(40, 22);
            this.tb_num.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logradouro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nº:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(354, 132);
            this.tb_bairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(207, 22);
            this.tb_bairro.TabIndex = 13;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(353, 185);
            this.tb_cidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(208, 22);
            this.tb_cidade.TabIndex = 14;
            // 
            // tb_uf
            // 
            this.tb_uf.Location = new System.Drawing.Point(355, 236);
            this.tb_uf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_uf.Name = "tb_uf";
            this.tb_uf.Size = new System.Drawing.Size(80, 22);
            this.tb_uf.TabIndex = 15;
            // 
            // tb_pais
            // 
            this.tb_pais.Location = new System.Drawing.Point(440, 236);
            this.tb_pais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(120, 22);
            this.tb_pais.TabIndex = 16;
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Items.AddRange(new object[] {
            "Advogado",
            "Cozinheiro",
            "Vendedor"});
            this.cb_cat.Location = new System.Drawing.Point(141, 233);
            this.cb_cat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(103, 24);
            this.cb_cat.TabIndex = 6;
            // 
            // tb_salariob
            // 
            this.tb_salariob.Location = new System.Drawing.Point(260, 182);
            this.tb_salariob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_salariob.Name = "tb_salariob";
            this.tb_salariob.Size = new System.Drawing.Size(78, 22);
            this.tb_salariob.TabIndex = 5;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(249, 233);
            this.cb_sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(88, 24);
            this.cb_sexo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "UF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Paìs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Categoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sexo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sálario Base:";
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.SystemColors.Control;
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(576, 40);
            this.pb_foto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(138, 180);
            this.pb_foto.TabIndex = 29;
            this.pb_foto.TabStop = false;
            // 
            // tn_foto
            // 
            this.tn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_foto.Location = new System.Drawing.Point(576, 224);
            this.tn_foto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tn_foto.Name = "tn_foto";
            this.tn_foto.Size = new System.Drawing.Size(138, 33);
            this.tn_foto.TabIndex = 17;
            this.tn_foto.Text = "FOTO";
            this.tn_foto.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "E-mail:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 302);
            this.panel1.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "MENU";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(11, 154);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(104, 26);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(11, 115);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(104, 26);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(11, 74);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(104, 26);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(11, 34);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(104, 26);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // cb_filho
            // 
            this.cb_filho.AutoSize = true;
            this.cb_filho.Location = new System.Drawing.Point(140, 271);
            this.cb_filho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_filho.Name = "cb_filho";
            this.cb_filho.Size = new System.Drawing.Size(114, 21);
            this.cb_filho.TabIndex = 8;
            this.cb_filho.Text = "Possui Filhos";
            this.cb_filho.UseVisualStyleBackColor = true;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(142, 182);
            this.mtb_cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtb_cpf.Mask = " 000.000.000-00 ";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(112, 22);
            this.mtb_cpf.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "CPF";
            // 
            // Cadastro_de_Pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(737, 302);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.cb_filho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tn_foto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.tb_salariob);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.tb_pais);
            this.Controls.Add(this.tb_uf);
            this.Controls.Add(this.tb_cidade);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.tb_logradouro);
            this.Controls.Add(this.tbn_pes_cep);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.tb_nome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_de_Pessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Button tbn_pes_cep;
        private System.Windows.Forms.TextBox tb_logradouro;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.TextBox tb_uf;
        private System.Windows.Forms.TextBox tb_pais;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.TextBox tb_salariob;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button tn_foto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.CheckBox cb_filho;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}