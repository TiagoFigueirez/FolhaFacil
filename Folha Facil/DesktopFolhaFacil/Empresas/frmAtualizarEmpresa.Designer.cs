namespace PrototipoRH.Empresas
{
    partial class frmAtualizarEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtualizarEmpresa));
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnLimparEmpresa = new System.Windows.Forms.Button();
            this.btnAtualizarEmpresa = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(6, 18);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(407, 20);
            this.txtEmpresa.TabIndex = 1;
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(5, 18);
            this.mskCnpj.Margin = new System.Windows.Forms.Padding(2);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(118, 20);
            this.mskCnpj.TabIndex = 2;
            this.mskCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnLimparEmpresa
            // 
            this.btnLimparEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnLimparEmpresa.Location = new System.Drawing.Point(401, 324);
            this.btnLimparEmpresa.Name = "btnLimparEmpresa";
            this.btnLimparEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnLimparEmpresa.TabIndex = 7;
            this.btnLimparEmpresa.Text = "Limpar Campos";
            this.btnLimparEmpresa.UseVisualStyleBackColor = true;
            this.btnLimparEmpresa.Click += new System.EventHandler(this.btnLimparEmpresa_Click);
            // 
            // btnAtualizarEmpresa
            // 
            this.btnAtualizarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAtualizarEmpresa.Location = new System.Drawing.Point(240, 324);
            this.btnAtualizarEmpresa.Name = "btnAtualizarEmpresa";
            this.btnAtualizarEmpresa.Size = new System.Drawing.Size(146, 54);
            this.btnAtualizarEmpresa.TabIndex = 6;
            this.btnAtualizarEmpresa.Text = "Atualizar";
            this.btnAtualizarEmpresa.UseVisualStyleBackColor = true;
            this.btnAtualizarEmpresa.Click += new System.EventHandler(this.btnAtualizarEmpresa_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Location = new System.Drawing.Point(6, 19);
            this.msktxtTelefone.Mask = "(00) 00000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.msktxtTelefone.TabIndex = 3;
            this.msktxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 19);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(600, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 48);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskCnpj);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox2.Location = new System.Drawing.Point(470, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 48);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CNPJ:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msktxtTelefone);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 48);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telefone:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox4.Location = new System.Drawing.Point(174, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 48);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "E-mail:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEndereco);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(621, 49);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Endereço:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.groupBox6.Location = new System.Drawing.Point(12, 51);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(777, 257);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dados Formais";
            // 
            // frmAtualizarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnLimparEmpresa);
            this.Controls.Add(this.btnAtualizarEmpresa);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtualizarEmpresa";
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.frmAtualizarEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Button btnLimparEmpresa;
        private System.Windows.Forms.Button btnAtualizarEmpresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}