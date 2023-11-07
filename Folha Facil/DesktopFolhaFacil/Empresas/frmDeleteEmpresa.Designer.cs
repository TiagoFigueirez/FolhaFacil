namespace PrototipoRH.Empresas
{
    partial class frmDeleteEmpresa
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
            this.mskDeleteCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteEmpresa = new System.Windows.Forms.Button();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.mskDeleteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtDeleteEndereco = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDeleteEmpresa = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEnderecp = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskDeleteCnpj
            // 
            this.mskDeleteCnpj.Enabled = false;
            this.mskDeleteCnpj.Location = new System.Drawing.Point(782, 73);
            this.mskDeleteCnpj.Mask = "00,000,000/0000-00";
            this.mskDeleteCnpj.Name = "mskDeleteCnpj";
            this.mskDeleteCnpj.Size = new System.Drawing.Size(156, 22);
            this.mskDeleteCnpj.TabIndex = 2;
            this.mskDeleteCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnDeleteEmpresa
            // 
            this.btnDeleteEmpresa.Location = new System.Drawing.Point(377, 334);
            this.btnDeleteEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmpresa.Name = "btnDeleteEmpresa";
            this.btnDeleteEmpresa.Size = new System.Drawing.Size(193, 66);
            this.btnDeleteEmpresa.TabIndex = 6;
            this.btnDeleteEmpresa.Text = "Deletar";
            this.btnDeleteEmpresa.UseVisualStyleBackColor = true;
            this.btnDeleteEmpresa.Click += new System.EventHandler(this.btnDeleteEmpresa_Click);
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.Enabled = false;
            this.txtDeleteEmail.Location = new System.Drawing.Point(386, 214);
            this.txtDeleteEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.Size = new System.Drawing.Size(552, 22);
            this.txtDeleteEmail.TabIndex = 5;
            // 
            // mskDeleteTelefone
            // 
            this.mskDeleteTelefone.Enabled = false;
            this.mskDeleteTelefone.Location = new System.Drawing.Point(140, 210);
            this.mskDeleteTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mskDeleteTelefone.Mask = "(00) 00000-0000";
            this.mskDeleteTelefone.Name = "mskDeleteTelefone";
            this.mskDeleteTelefone.Size = new System.Drawing.Size(132, 22);
            this.mskDeleteTelefone.TabIndex = 4;
            this.mskDeleteTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtDeleteEndereco
            // 
            this.txtDeleteEndereco.Enabled = false;
            this.txtDeleteEndereco.Location = new System.Drawing.Point(140, 140);
            this.txtDeleteEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteEndereco.MaxLength = 45;
            this.txtDeleteEndereco.Name = "txtDeleteEndereco";
            this.txtDeleteEndereco.Size = new System.Drawing.Size(799, 22);
            this.txtDeleteEndereco.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(330, 214);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-mail";
            // 
            // txtDeleteEmpresa
            // 
            this.txtDeleteEmpresa.Enabled = false;
            this.txtDeleteEmpresa.Location = new System.Drawing.Point(140, 73);
            this.txtDeleteEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteEmpresa.MaxLength = 45;
            this.txtDeleteEmpresa.Name = "txtDeleteEmpresa";
            this.txtDeleteEmpresa.Size = new System.Drawing.Size(543, 22);
            this.txtDeleteEmpresa.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(61, 220);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 16);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEnderecp
            // 
            this.lblEnderecp.AutoSize = true;
            this.lblEnderecp.Location = new System.Drawing.Point(61, 144);
            this.lblEnderecp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecp.Name = "lblEnderecp";
            this.lblEnderecp.Size = new System.Drawing.Size(66, 16);
            this.lblEnderecp.TabIndex = 12;
            this.lblEnderecp.Text = "Endereço";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(733, 76);
            this.lblCnpj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(42, 16);
            this.lblCnpj.TabIndex = 10;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(68, 76);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(62, 16);
            this.lblEmpresa.TabIndex = 8;
            this.lblEmpresa.Text = "Empresa";
            // 
            // frmDeleteEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.mskDeleteCnpj);
            this.Controls.Add(this.btnDeleteEmpresa);
            this.Controls.Add(this.txtDeleteEmail);
            this.Controls.Add(this.mskDeleteTelefone);
            this.Controls.Add(this.txtDeleteEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDeleteEmpresa);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEnderecp);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDeleteCnpj;
        private System.Windows.Forms.Button btnDeleteEmpresa;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.MaskedTextBox mskDeleteTelefone;
        private System.Windows.Forms.TextBox txtDeleteEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDeleteEmpresa;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEnderecp;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblEmpresa;
    }
}