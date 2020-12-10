namespace Sistema_de_Gestão
{
    partial class frm_TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESSOASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILHOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESSOASToolStripMenuItem,
            this.fILHOSToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // pESSOASToolStripMenuItem
            // 
            this.pESSOASToolStripMenuItem.Name = "pESSOASToolStripMenuItem";
            this.pESSOASToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pESSOASToolStripMenuItem.Text = "PESSOAS";
            this.pESSOASToolStripMenuItem.Click += new System.EventHandler(this.pESSOASToolStripMenuItem_Click);
            // 
            // fILHOSToolStripMenuItem
            // 
            this.fILHOSToolStripMenuItem.Name = "fILHOSToolStripMenuItem";
            this.fILHOSToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fILHOSToolStripMenuItem.Text = "FILHOS";
            this.fILHOSToolStripMenuItem.Click += new System.EventHandler(this.fILHOSToolStripMenuItem_Click);
            // 
            // frm_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESSOASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILHOSToolStripMenuItem;
    }
}

