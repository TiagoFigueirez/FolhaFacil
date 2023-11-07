namespace PrototipoRH.Funcionarios
{
    partial class frmFuncionario
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
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.BtnEditFuncionario = new System.Windows.Forms.Button();
            this.btnExcluFuncionario = new System.Windows.Forms.Button();
            this.txtPesFuncionario = new System.Windows.Forms.TextBox();
            this.lblPesFuncionario = new System.Windows.Forms.Label();
            this.BtnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.lblFunCadastrados = new System.Windows.Forms.Label();
            this.lblFiltroFuncionario = new System.Windows.Forms.Label();
            this.radioButton_Matrícula = new System.Windows.Forms.RadioButton();
            this.radioButton_RG = new System.Windows.Forms.RadioButton();
            this.radioButton_CPF = new System.Windows.Forms.RadioButton();
            this.radioButton_Nome = new System.Windows.Forms.RadioButton();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.Location = new System.Drawing.Point(469, 71);
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.RowHeadersWidth = 51;
            this.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionario.Size = new System.Drawing.Size(652, 382);
            this.DgvFuncionario.TabIndex = 0;
            // 
            // btnAddFuncionario
            // 
            this.btnAddFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAddFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAddFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFuncionario.Location = new System.Drawing.Point(637, 478);
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Size = new System.Drawing.Size(145, 54);
            this.btnAddFuncionario.TabIndex = 1;
            this.btnAddFuncionario.Text = "Adicionar";
            this.btnAddFuncionario.UseVisualStyleBackColor = false;
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            // 
            // BtnEditFuncionario
            // 
            this.BtnEditFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnEditFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnEditFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditFuncionario.Location = new System.Drawing.Point(812, 478);
            this.BtnEditFuncionario.Name = "BtnEditFuncionario";
            this.BtnEditFuncionario.Size = new System.Drawing.Size(145, 54);
            this.BtnEditFuncionario.TabIndex = 2;
            this.BtnEditFuncionario.Text = "Editar";
            this.BtnEditFuncionario.UseVisualStyleBackColor = false;
            this.BtnEditFuncionario.Click += new System.EventHandler(this.BtnEditFuncionario_Click);
            // 
            // btnExcluFuncionario
            // 
            this.btnExcluFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnExcluFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluFuncionario.Location = new System.Drawing.Point(976, 478);
            this.btnExcluFuncionario.Name = "btnExcluFuncionario";
            this.btnExcluFuncionario.Size = new System.Drawing.Size(145, 54);
            this.btnExcluFuncionario.TabIndex = 3;
            this.btnExcluFuncionario.Text = "Excluir";
            this.btnExcluFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluFuncionario.Click += new System.EventHandler(this.btnExcluFuncionario_Click);
            // 
            // txtPesFuncionario
            // 
            this.txtPesFuncionario.Location = new System.Drawing.Point(43, 181);
            this.txtPesFuncionario.Name = "txtPesFuncionario";
            this.txtPesFuncionario.Size = new System.Drawing.Size(367, 20);
            this.txtPesFuncionario.TabIndex = 4;
            // 
            // lblPesFuncionario
            // 
            this.lblPesFuncionario.AutoSize = true;
            this.lblPesFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPesFuncionario.Location = new System.Drawing.Point(38, 140);
            this.lblPesFuncionario.Name = "lblPesFuncionario";
            this.lblPesFuncionario.Size = new System.Drawing.Size(200, 25);
            this.lblPesFuncionario.TabIndex = 5;
            this.lblPesFuncionario.Text = "Pesquisa Funcionario";
            // 
            // BtnPesquisarFuncionario
            // 
            this.BtnPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnPesquisarFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisarFuncionario.Location = new System.Drawing.Point(270, 233);
            this.BtnPesquisarFuncionario.Name = "BtnPesquisarFuncionario";
            this.BtnPesquisarFuncionario.Size = new System.Drawing.Size(140, 50);
            this.BtnPesquisarFuncionario.TabIndex = 6;
            this.BtnPesquisarFuncionario.Text = "Pesquisar";
            this.BtnPesquisarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.BtnPesquisarFuncionario.Click += new System.EventHandler(this.BtnPesquisarFuncionario_Click);
            // 
            // lblFunCadastrados
            // 
            this.lblFunCadastrados.AutoSize = true;
            this.lblFunCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFunCadastrados.Location = new System.Drawing.Point(464, 27);
            this.lblFunCadastrados.Name = "lblFunCadastrados";
            this.lblFunCadastrados.Size = new System.Drawing.Size(124, 25);
            this.lblFunCadastrados.TabIndex = 7;
            this.lblFunCadastrados.Text = "Cadastrados";
            // 
            // lblFiltroFuncionario
            // 
            this.lblFiltroFuncionario.AutoSize = true;
            this.lblFiltroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFiltroFuncionario.Location = new System.Drawing.Point(37, 266);
            this.lblFiltroFuncionario.Name = "lblFiltroFuncionario";
            this.lblFiltroFuncionario.Size = new System.Drawing.Size(73, 17);
            this.lblFiltroFuncionario.TabIndex = 8;
            this.lblFiltroFuncionario.Text = "Filtrar por:";
            // 
            // radioButton_Matrícula
            // 
            this.radioButton_Matrícula.AutoSize = true;
            this.radioButton_Matrícula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Matrícula.Location = new System.Drawing.Point(52, 370);
            this.radioButton_Matrícula.Name = "radioButton_Matrícula";
            this.radioButton_Matrícula.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Matrícula.TabIndex = 15;
            this.radioButton_Matrícula.TabStop = true;
            this.radioButton_Matrícula.Text = "Matrícula";
            this.radioButton_Matrícula.UseVisualStyleBackColor = true;
            // 
            // radioButton_RG
            // 
            this.radioButton_RG.AutoSize = true;
            this.radioButton_RG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_RG.Location = new System.Drawing.Point(51, 347);
            this.radioButton_RG.Name = "radioButton_RG";
            this.radioButton_RG.Size = new System.Drawing.Size(41, 17);
            this.radioButton_RG.TabIndex = 14;
            this.radioButton_RG.TabStop = true;
            this.radioButton_RG.Text = "RG";
            this.radioButton_RG.UseVisualStyleBackColor = true;
            // 
            // radioButton_CPF
            // 
            this.radioButton_CPF.AutoSize = true;
            this.radioButton_CPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_CPF.Location = new System.Drawing.Point(51, 324);
            this.radioButton_CPF.Name = "radioButton_CPF";
            this.radioButton_CPF.Size = new System.Drawing.Size(45, 17);
            this.radioButton_CPF.TabIndex = 13;
            this.radioButton_CPF.TabStop = true;
            this.radioButton_CPF.Text = "CPF";
            this.radioButton_CPF.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nome
            // 
            this.radioButton_Nome.AutoSize = true;
            this.radioButton_Nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Nome.Location = new System.Drawing.Point(52, 301);
            this.radioButton_Nome.Name = "radioButton_Nome";
            this.radioButton_Nome.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Nome.TabIndex = 12;
            this.radioButton_Nome.TabStop = true;
            this.radioButton_Nome.Text = "Nome";
            this.radioButton_Nome.UseVisualStyleBackColor = true;
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Empresa.Location = new System.Drawing.Point(38, 57);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(90, 25);
            this.label_Empresa.TabIndex = 19;
            this.label_Empresa.Text = "Empresa";
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(43, 96);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(367, 21);
            this.comboBox_Empresa.TabIndex = 20;
            // 
            // frmFuncionario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1151, 571);
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
            this.Controls.Add(this.btnExcluFuncionario);
            this.Controls.Add(this.BtnEditFuncionario);
            this.Controls.Add(this.btnAddFuncionario);
            this.Controls.Add(this.DgvFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUNCIONARIO";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFuncionario;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.Button BtnEditFuncionario;
        private System.Windows.Forms.Button btnExcluFuncionario;
        private System.Windows.Forms.TextBox txtPesFuncionario;
        private System.Windows.Forms.Label lblPesFuncionario;
        private System.Windows.Forms.Button BtnPesquisarFuncionario;
        private System.Windows.Forms.Label lblFunCadastrados;
        private System.Windows.Forms.Label lblFiltroFuncionario;
        private System.Windows.Forms.RadioButton radioButton_Matrícula;
        private System.Windows.Forms.RadioButton radioButton_RG;
        private System.Windows.Forms.RadioButton radioButton_CPF;
        private System.Windows.Forms.RadioButton radioButton_Nome;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.ComboBox comboBox_Empresa;
    }
}