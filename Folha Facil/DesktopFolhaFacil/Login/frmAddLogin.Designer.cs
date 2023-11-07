namespace PrototipoRH.Usuarios
{
    partial class frmAddLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLogin));
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbSenha = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.gbNivel = new System.Windows.Forms.GroupBox();
            this.gbConfirmarSenha = new System.Windows.Forms.GroupBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbUsuario.SuspendLayout();
            this.gbSenha.SuspendLayout();
            this.gbNivel.SuspendLayout();
            this.gbConfirmarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAddUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAddUsuario.Location = new System.Drawing.Point(123, 231);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(145, 54);
            this.btnAddUsuario.TabIndex = 5;
            this.btnAddUsuario.Text = "Adicionar";
            this.btnAddUsuario.UseVisualStyleBackColor = false;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
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
            this.gbUsuario.Location = new System.Drawing.Point(80, 56);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(231, 39);
            this.gbUsuario.TabIndex = 11;
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
            this.gbSenha.Location = new System.Drawing.Point(355, 56);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Size = new System.Drawing.Size(174, 39);
            this.gbSenha.TabIndex = 20;
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
            // gbNivel
            // 
            this.gbNivel.Controls.Add(this.cbNivel);
            this.gbNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbNivel.Location = new System.Drawing.Point(80, 140);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(231, 40);
            this.gbNivel.TabIndex = 20;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nível";
            // 
            // gbConfirmarSenha
            // 
            this.gbConfirmarSenha.Controls.Add(this.txtConfirmarSenha);
            this.gbConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.gbConfirmarSenha.Location = new System.Drawing.Point(355, 141);
            this.gbConfirmarSenha.Name = "gbConfirmarSenha";
            this.gbConfirmarSenha.Size = new System.Drawing.Size(174, 39);
            this.gbConfirmarSenha.TabIndex = 21;
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
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(342, 231);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 54);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmAddLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 353);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbConfirmarSenha);
            this.Controls.Add(this.gbNivel);
            this.Controls.Add(this.gbSenha);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.btnAddUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuario";
            this.Load += new System.EventHandler(this.frmAddLogin_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbSenha.ResumeLayout(false);
            this.gbSenha.PerformLayout();
            this.gbNivel.ResumeLayout(false);
            this.gbConfirmarSenha.ResumeLayout(false);
            this.gbConfirmarSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox gbNivel;
        private System.Windows.Forms.GroupBox gbConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Button btnLimpar;
    }
}