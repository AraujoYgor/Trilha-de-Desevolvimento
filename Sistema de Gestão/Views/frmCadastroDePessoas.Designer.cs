namespace Sistema_de_Gestão.Views
{
    partial class frmCadastroDePessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDePessoas));
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_pes_cep = new System.Windows.Forms.Button();
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
            this.btn_foto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cb_filho = new System.Windows.Forms.CheckBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.visualizar = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imprimir = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(265, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(258, 26);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_sobrenome
            // 
            this.tb_sobrenome.Enabled = false;
            this.tb_sobrenome.Location = new System.Drawing.Point(265, 63);
            this.tb_sobrenome.Name = "tb_sobrenome";
            this.tb_sobrenome.Size = new System.Drawing.Size(258, 26);
            this.tb_sobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sobrenome:";
            // 
            // tb_email
            // 
            this.tb_email.Enabled = false;
            this.tb_email.Location = new System.Drawing.Point(265, 100);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(258, 26);
            this.tb_email.TabIndex = 3;
            // 
            // btn_pes_cep
            // 
            this.btn_pes_cep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pes_cep.Enabled = false;
            this.btn_pes_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pes_cep.Location = new System.Drawing.Point(412, 328);
            this.btn_pes_cep.Name = "btn_pes_cep";
            this.btn_pes_cep.Size = new System.Drawing.Size(110, 34);
            this.btn_pes_cep.TabIndex = 10;
            this.btn_pes_cep.Text = "Pesquisar";
            this.btn_pes_cep.UseVisualStyleBackColor = true;
            this.btn_pes_cep.Click += new System.EventHandler(this.btn_pes_cep_Click);
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.Enabled = false;
            this.tb_logradouro.Location = new System.Drawing.Point(267, 377);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(258, 26);
            this.tb_logradouro.TabIndex = 11;
            // 
            // tb_num
            // 
            this.tb_num.Enabled = false;
            this.tb_num.Location = new System.Drawing.Point(444, 414);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(81, 26);
            this.tb_num.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Logradouro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nº:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Enabled = false;
            this.tb_bairro.Location = new System.Drawing.Point(267, 452);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(258, 26);
            this.tb_bairro.TabIndex = 13;
            // 
            // tb_cidade
            // 
            this.tb_cidade.Enabled = false;
            this.tb_cidade.Location = new System.Drawing.Point(267, 497);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(258, 26);
            this.tb_cidade.TabIndex = 14;
            // 
            // tb_uf
            // 
            this.tb_uf.Enabled = false;
            this.tb_uf.Location = new System.Drawing.Point(267, 547);
            this.tb_uf.Name = "tb_uf";
            this.tb_uf.Size = new System.Drawing.Size(258, 26);
            this.tb_uf.TabIndex = 15;
            // 
            // tb_pais
            // 
            this.tb_pais.Enabled = false;
            this.tb_pais.Location = new System.Drawing.Point(267, 592);
            this.tb_pais.Name = "tb_pais";
            this.tb_pais.Size = new System.Drawing.Size(258, 26);
            this.tb_pais.TabIndex = 16;
            // 
            // cb_cat
            // 
            this.cb_cat.Enabled = false;
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Items.AddRange(new object[] {
            "Advogado",
            "Cozinheiro",
            "Vendedor"});
            this.cb_cat.Location = new System.Drawing.Point(265, 186);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(256, 28);
            this.cb_cat.TabIndex = 6;
            // 
            // tb_salariob
            // 
            this.tb_salariob.Enabled = false;
            this.tb_salariob.Location = new System.Drawing.Point(266, 288);
            this.tb_salariob.Name = "tb_salariob";
            this.tb_salariob.Size = new System.Drawing.Size(258, 26);
            this.tb_salariob.TabIndex = 5;
            // 
            // cb_sexo
            // 
            this.cb_sexo.Enabled = false;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_sexo.Location = new System.Drawing.Point(265, 235);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(258, 28);
            this.cb_sexo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "UF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Paìs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Categoria:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Sexo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sálario Base:";
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.SystemColors.Control;
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Enabled = false;
            this.pb_foto.Location = new System.Drawing.Point(553, 28);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(155, 225);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 29;
            this.pb_foto.TabStop = false;
            // 
            // btn_foto
            // 
            this.btn_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_foto.Enabled = false;
            this.btn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.Location = new System.Drawing.Point(553, 280);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(156, 42);
            this.btn_foto.TabIndex = 17;
            this.btn_foto.Text = "FOTO";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "E-mail:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Controls.Add(this.btn_Visualizar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btn_Limpar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 640);
            this.panel1.TabIndex = 33;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(11, 235);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(117, 44);
            this.btn_Imprimir.TabIndex = 6;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click_1);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(12, 186);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(116, 43);
            this.btn_Visualizar.TabIndex = 5;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "MENU";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(11, 285);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(117, 43);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 141);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(117, 39);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 92);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(117, 43);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(12, 43);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(117, 43);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // cb_filho
            // 
            this.cb_filho.AutoSize = true;
            this.cb_filho.Enabled = false;
            this.cb_filho.Location = new System.Drawing.Point(446, 143);
            this.cb_filho.Name = "cb_filho";
            this.cb_filho.Size = new System.Drawing.Size(77, 24);
            this.cb_filho.TabIndex = 8;
            this.cb_filho.Text = "Filhos";
            this.cb_filho.UseVisualStyleBackColor = true;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Enabled = false;
            this.mtb_cpf.Location = new System.Drawing.Point(267, 141);
            this.mtb_cpf.Mask = " 000.000.000-00 ";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(139, 26);
            this.mtb_cpf.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(157, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "CPF";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(267, 336);
            this.tb_cep.MaxLength = 8;
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(139, 26);
            this.tb_cep.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Complamento";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(552, 339);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(156, 248);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "1º Clique no botão Novo\r\npara iniciar o cadastro;\r\n\r\n2º Fotos nos formatos\r\nJPG e" +
    " PNG com 800x800\r\npixels;\r\n\r\n3º Salve a foto com seu \r\nnome;\r\n";
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // visualizar
            // 
            this.visualizar.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.visualizar.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.visualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.visualizar.ClientSize = new System.Drawing.Size(400, 300);
            this.visualizar.Document = this.documento;
            this.visualizar.Enabled = true;
            this.visualizar.Icon = ((System.Drawing.Icon)(resources.GetObject("visualizar.Icon")));
            this.visualizar.Name = "visualizar";
            this.visualizar.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imprimir
            // 
            this.imprimir.UseEXDialog = true;
            // 
            // frmCadastroDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(732, 640);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.cb_filho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_foto);
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
            this.Controls.Add(this.btn_pes_cep);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sobrenome);
            this.Controls.Add(this.tb_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroDePessoas";
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
        private System.Windows.Forms.Button btn_pes_cep;
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
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.CheckBox cb_filho;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_cep;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog visualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.PrintDialog imprimir;
    }
}