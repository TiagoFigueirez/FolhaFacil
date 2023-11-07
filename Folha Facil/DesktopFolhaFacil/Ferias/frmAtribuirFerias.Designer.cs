namespace PrototipoRH.Ferias
{
    partial class frmAtribuirFerias
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
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.mskDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.lblInicioFerias = new System.Windows.Forms.Label();
            this.mskDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFimFerias = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblDataVencimento.Location = new System.Drawing.Point(582, 56);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(129, 16);
            this.lblDataVencimento.TabIndex = 0;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // mskDataVencimento
            // 
            this.mskDataVencimento.Enabled = false;
            this.mskDataVencimento.Location = new System.Drawing.Point(717, 53);
            this.mskDataVencimento.Mask = "00/00/0000";
            this.mskDataVencimento.Name = "mskDataVencimento";
            this.mskDataVencimento.Size = new System.Drawing.Size(100, 22);
            this.mskDataVencimento.TabIndex = 1;
            this.mskDataVencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblInicioFerias
            // 
            this.lblInicioFerias.AutoSize = true;
            this.lblInicioFerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblInicioFerias.Location = new System.Drawing.Point(31, 138);
            this.lblInicioFerias.Name = "lblInicioFerias";
            this.lblInicioFerias.Size = new System.Drawing.Size(105, 16);
            this.lblInicioFerias.TabIndex = 2;
            this.lblInicioFerias.Text = "inicio das Férias";
            // 
            // mskDataInicio
            // 
            this.mskDataInicio.Location = new System.Drawing.Point(142, 138);
            this.mskDataInicio.Mask = "00/00/0000";
            this.mskDataInicio.Name = "mskDataInicio";
            this.mskDataInicio.Size = new System.Drawing.Size(92, 22);
            this.mskDataInicio.TabIndex = 2;
            this.mskDataInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(303, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fim das Ferias";
            // 
            // mskFimFerias
            // 
            this.mskFimFerias.Location = new System.Drawing.Point(405, 140);
            this.mskFimFerias.Mask = "00/00/0000";
            this.mskFimFerias.Name = "mskFimFerias";
            this.mskFimFerias.Size = new System.Drawing.Size(105, 22);
            this.mskFimFerias.TabIndex = 3;
            this.mskFimFerias.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskFimFerias.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(598, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Funcionario";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(185, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAtribuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtribuir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtribuir.Location = new System.Drawing.Point(360, 292);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(145, 54);
            this.btnAtribuir.TabIndex = 5;
            this.btnAtribuir.Text = "Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = false;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Location = new System.Drawing.Point(680, 137);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(100, 22);
            this.txtVencimento.TabIndex = 5;
            // 
            // frmAtribuirFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.txtVencimento);
            this.Controls.Add(this.btnAtribuir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskFimFerias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskDataInicio);
            this.Controls.Add(this.lblInicioFerias);
            this.Controls.Add(this.mskDataVencimento);
            this.Controls.Add(this.lblDataVencimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtribuirFerias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atribuir Ferias";
            this.Load += new System.EventHandler(this.frmAtribuirFerias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.MaskedTextBox mskDataVencimento;
        private System.Windows.Forms.Label lblInicioFerias;
        private System.Windows.Forms.MaskedTextBox mskDataInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFimFerias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.TextBox txtVencimento;
    }
}