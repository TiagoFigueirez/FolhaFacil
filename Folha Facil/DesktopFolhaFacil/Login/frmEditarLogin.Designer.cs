namespace PrototipoRH.Login
{
    partial class frmEditarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarLogin));
            this.btnEditarUsuario = new System.Windows.Forms.Button();
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
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.Location = new System.Drawing.Point(327, 305);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(193, 66);
            this.btnEditarUsuario.TabIndex = 22;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Location = new System.Drawing.Point(7, 17);
            this.cbNivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(293, 24);
            this.cbNivel.TabIndex = 3;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbUsuario.Location = new System.Drawing.Point(112, 76);
            this.gbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUsuario.Size = new System.Drawing.Size(308, 48);
            this.gbUsuario.TabIndex = 24;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(8, 17);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(291, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // gbSenha
            // 
            this.gbSenha.Controls.Add(this.txtSenha);
            this.gbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbSenha.Location = new System.Drawing.Point(479, 76);
            this.gbSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSenha.Size = new System.Drawing.Size(232, 48);
            this.gbSenha.TabIndex = 25;
            this.gbSenha.TabStop = false;
            this.gbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(8, 17);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(215, 22);
            this.txtSenha.TabIndex = 2;
            // 
            // gbConfirmarSenha
            // 
            this.gbConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.gbConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbConfirmarSenha.Location = new System.Drawing.Point(479, 181);
            this.gbConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConfirmarSenha.Name = "gbConfirmarSenha";
            this.gbConfirmarSenha.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConfirmarSenha.Size = new System.Drawing.Size(232, 48);
            this.gbConfirmarSenha.TabIndex = 27;
            this.gbConfirmarSenha.TabStop = false;
            this.gbConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(8, 17);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '●';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(215, 22);
            this.txtConfirmarSenha.TabIndex = 4;
            // 
            // gbNivel
            // 
            this.gbNivel.Controls.Add(this.cbNivel);
            this.gbNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbNivel.Location = new System.Drawing.Point(112, 180);
            this.gbNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNivel.Size = new System.Drawing.Size(308, 49);
            this.gbNivel.TabIndex = 26;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nível";
            // 
            // frmEditarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 434);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbSenha);
            this.Controls.Add(this.gbConfirmarSenha);
            this.Controls.Add(this.gbNivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditarLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarLogin";
            this.Load += new System.EventHandler(this.frmEditarLogin_Load);
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

        private System.Windows.Forms.Button btnEditarUsuario;
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