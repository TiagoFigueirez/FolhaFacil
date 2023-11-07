namespace PrototipoRH.Usuarios
{
    partial class frmDeletarLogin
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
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbSenha = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.gbConfirmarSenha = new System.Windows.Forms.GroupBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.gbNivel = new System.Windows.Forms.GroupBox();
            this.gbUsuario.SuspendLayout();
            this.gbSenha.SuspendLayout();
            this.gbConfirmarSenha.SuspendLayout();
            this.gbNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.White;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(245, 242);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(145, 54);
            this.btnExcluirUsuario.TabIndex = 28;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(5, 14);
            this.cbNivel.Margin = new System.Windows.Forms.Padding(2);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(221, 21);
            this.cbNivel.TabIndex = 3;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbUsuario.Location = new System.Drawing.Point(84, 56);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(231, 39);
            this.gbUsuario.TabIndex = 29;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(219, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // gbSenha
            // 
            this.gbSenha.Controls.Add(this.txtSenha);
            this.gbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbSenha.Location = new System.Drawing.Point(359, 56);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Size = new System.Drawing.Size(174, 39);
            this.gbSenha.TabIndex = 30;
            this.gbSenha.TabStop = false;
            this.gbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 14);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(162, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // gbConfirmarSenha
            // 
            this.gbConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.gbConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbConfirmarSenha.Location = new System.Drawing.Point(359, 141);
            this.gbConfirmarSenha.Name = "gbConfirmarSenha";
            this.gbConfirmarSenha.Size = new System.Drawing.Size(174, 39);
            this.gbConfirmarSenha.TabIndex = 32;
            this.gbConfirmarSenha.TabStop = false;
            this.gbConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(6, 14);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '●';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmarSenha.TabIndex = 4;
            // 
            // gbNivel
            // 
            this.gbNivel.Controls.Add(this.cbNivel);
            this.gbNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbNivel.Location = new System.Drawing.Point(84, 140);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(231, 40);
            this.gbNivel.TabIndex = 31;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nível";
            // 
            // frmDeletarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 353);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbSenha);
            this.Controls.Add(this.gbConfirmarSenha);
            this.Controls.Add(this.gbNivel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDeletarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeletarUsuario";
            this.Load += new System.EventHandler(this.frmDeletarLogin_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbSenha.ResumeLayout(false);
            this.gbSenha.PerformLayout();
            this.gbConfirmarSenha.ResumeLayout(false);
            this.gbConfirmarSenha.PerformLayout();
            this.gbNivel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox gbConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.GroupBox gbNivel;
    }
}