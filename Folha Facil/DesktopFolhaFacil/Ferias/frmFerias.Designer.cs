namespace PrototipoRH.Ferias
{
    partial class frmFerias
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
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.radioButton_Matrícula = new System.Windows.Forms.RadioButton();
            this.radioButton_RG = new System.Windows.Forms.RadioButton();
            this.radioButton_CPF = new System.Windows.Forms.RadioButton();
            this.radioButton_Nome = new System.Windows.Forms.RadioButton();
            this.lblFiltroFuncionario = new System.Windows.Forms.Label();
            this.lblFunCadastrados = new System.Windows.Forms.Label();
            this.BtnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.lblPesFuncionario = new System.Windows.Forms.Label();
            this.txtPesFuncionario = new System.Windows.Forms.TextBox();
            this.btnAtribuirFerias = new System.Windows.Forms.Button();
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(29, 79);
            this.comboBox_Empresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(276, 21);
            this.comboBox_Empresa.TabIndex = 35;
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Empresa.Location = new System.Drawing.Point(26, 47);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(90, 25);
            this.label_Empresa.TabIndex = 34;
            this.label_Empresa.Text = "Empresa";
            // 
            // radioButton_Matrícula
            // 
            this.radioButton_Matrícula.AutoSize = true;
            this.radioButton_Matrícula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Matrícula.Location = new System.Drawing.Point(36, 301);
            this.radioButton_Matrícula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Matrícula.Name = "radioButton_Matrícula";
            this.radioButton_Matrícula.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Matrícula.TabIndex = 33;
            this.radioButton_Matrícula.TabStop = true;
            this.radioButton_Matrícula.Text = "Matrícula";
            this.radioButton_Matrícula.UseVisualStyleBackColor = true;
            // 
            // radioButton_RG
            // 
            this.radioButton_RG.AutoSize = true;
            this.radioButton_RG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_RG.Location = new System.Drawing.Point(35, 283);
            this.radioButton_RG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_RG.Name = "radioButton_RG";
            this.radioButton_RG.Size = new System.Drawing.Size(41, 17);
            this.radioButton_RG.TabIndex = 32;
            this.radioButton_RG.TabStop = true;
            this.radioButton_RG.Text = "RG";
            this.radioButton_RG.UseVisualStyleBackColor = true;
            // 
            // radioButton_CPF
            // 
            this.radioButton_CPF.AutoSize = true;
            this.radioButton_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_CPF.Location = new System.Drawing.Point(35, 264);
            this.radioButton_CPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_CPF.Name = "radioButton_CPF";
            this.radioButton_CPF.Size = new System.Drawing.Size(45, 17);
            this.radioButton_CPF.TabIndex = 31;
            this.radioButton_CPF.TabStop = true;
            this.radioButton_CPF.Text = "CPF";
            this.radioButton_CPF.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nome
            // 
            this.radioButton_Nome.AutoSize = true;
            this.radioButton_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Nome.Location = new System.Drawing.Point(36, 245);
            this.radioButton_Nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_Nome.Name = "radioButton_Nome";
            this.radioButton_Nome.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Nome.TabIndex = 30;
            this.radioButton_Nome.TabStop = true;
            this.radioButton_Nome.Text = "Nome";
            this.radioButton_Nome.UseVisualStyleBackColor = true;
            // 
            // lblFiltroFuncionario
            // 
            this.lblFiltroFuncionario.AutoSize = true;
            this.lblFiltroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFiltroFuncionario.Location = new System.Drawing.Point(25, 217);
            this.lblFiltroFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroFuncionario.Name = "lblFiltroFuncionario";
            this.lblFiltroFuncionario.Size = new System.Drawing.Size(73, 17);
            this.lblFiltroFuncionario.TabIndex = 29;
            this.lblFiltroFuncionario.Text = "Filtrar por:";
            // 
            // lblFunCadastrados
            // 
            this.lblFunCadastrados.AutoSize = true;
            this.lblFunCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFunCadastrados.Location = new System.Drawing.Point(345, 23);
            this.lblFunCadastrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFunCadastrados.Name = "lblFunCadastrados";
            this.lblFunCadastrados.Size = new System.Drawing.Size(124, 25);
            this.lblFunCadastrados.TabIndex = 28;
            this.lblFunCadastrados.Text = "Cadastrados";
            // 
            // BtnPesquisarFuncionario
            // 
            this.BtnPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnPesquisarFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisarFuncionario.Location = new System.Drawing.Point(200, 190);
            this.BtnPesquisarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPesquisarFuncionario.Name = "BtnPesquisarFuncionario";
            this.BtnPesquisarFuncionario.Size = new System.Drawing.Size(105, 41);
            this.BtnPesquisarFuncionario.TabIndex = 27;
            this.BtnPesquisarFuncionario.Text = "Pesquisar";
            this.BtnPesquisarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.BtnPesquisarFuncionario.Click += new System.EventHandler(this.BtnPesquisarFuncionario_Click);
            // 
            // lblPesFuncionario
            // 
            this.lblPesFuncionario.AutoSize = true;
            this.lblPesFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPesFuncionario.Location = new System.Drawing.Point(26, 115);
            this.lblPesFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesFuncionario.Name = "lblPesFuncionario";
            this.lblPesFuncionario.Size = new System.Drawing.Size(200, 25);
            this.lblPesFuncionario.TabIndex = 26;
            this.lblPesFuncionario.Text = "Pesquisa Funcionario";
            // 
            // txtPesFuncionario
            // 
            this.txtPesFuncionario.Location = new System.Drawing.Point(29, 148);
            this.txtPesFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesFuncionario.Name = "txtPesFuncionario";
            this.txtPesFuncionario.Size = new System.Drawing.Size(276, 20);
            this.txtPesFuncionario.TabIndex = 25;
            // 
            // btnAtribuirFerias
            // 
            this.btnAtribuirFerias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtribuirFerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAtribuirFerias.FlatAppearance.BorderSize = 0;
            this.btnAtribuirFerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtribuirFerias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtribuirFerias.Location = new System.Drawing.Point(729, 389);
            this.btnAtribuirFerias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtribuirFerias.Name = "btnAtribuirFerias";
            this.btnAtribuirFerias.Size = new System.Drawing.Size(109, 44);
            this.btnAtribuirFerias.TabIndex = 24;
            this.btnAtribuirFerias.Text = "Atribuir Ferias";
            this.btnAtribuirFerias.UseVisualStyleBackColor = false;
            this.btnAtribuirFerias.Click += new System.EventHandler(this.btnAtribuirFerias_Click);
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.Location = new System.Drawing.Point(349, 58);
            this.DgvFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.RowHeadersWidth = 51;
            this.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionario.Size = new System.Drawing.Size(489, 310);
            this.DgvFuncionario.TabIndex = 21;
            // 
            // frmFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.comboBox_Empresa);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.radioButton_Matrícula);
            this.Controls.Add(this.radioButton_RG);
            this.Controls.Add(this.radioButton_CPF);
            this.Controls.Add(this.radioButton_Nome);
            this.Controls.Add(this.lblFiltroFuncionario);
            this.Controls.Add(this.lblFunCadastrados);
            this.Controls.Add(this.BtnPesquisarFuncionario);
            this.Controls.Add(this.lblPesFuncionario);
            this.Controls.Add(this.txtPesFuncionario);
            this.Controls.Add(this.btnAtribuirFerias);
            this.Controls.Add(this.DgvFuncionario);
            this.Name = "frmFerias";
            this.Text = "RECIBO DE FERIAS";
            this.Load += new System.EventHandler(this.frmFerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Empresa;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.RadioButton radioButton_Matrícula;
        private System.Windows.Forms.RadioButton radioButton_RG;
        private System.Windows.Forms.RadioButton radioButton_CPF;
        private System.Windows.Forms.RadioButton radioButton_Nome;
        private System.Windows.Forms.Label lblFiltroFuncionario;
        private System.Windows.Forms.Label lblFunCadastrados;
        private System.Windows.Forms.Button BtnPesquisarFuncionario;
        private System.Windows.Forms.Label lblPesFuncionario;
        private System.Windows.Forms.TextBox txtPesFuncionario;
        private System.Windows.Forms.Button btnAtribuirFerias;
        private System.Windows.Forms.DataGridView DgvFuncionario;
    }
}