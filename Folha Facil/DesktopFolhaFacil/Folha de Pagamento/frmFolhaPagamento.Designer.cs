namespace PrototipoRH.Folha_de_Pagamento
{
    partial class frmFolhaPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.radioButton_Matrícula = new System.Windows.Forms.RadioButton();
            this.radioButton_RG = new System.Windows.Forms.RadioButton();
            this.radioButton_CPF = new System.Windows.Forms.RadioButton();
            this.radioButton_Nome = new System.Windows.Forms.RadioButton();
            this.lblFiltroFuncionario = new System.Windows.Forms.Label();
            this.lblFunCadastrados = new System.Windows.Forms.Label();
            this.lblPesFuncionario = new System.Windows.Forms.Label();
            this.txtPesFuncionario = new System.Windows.Forms.TextBox();
            this.btnVisualizarHolerite = new System.Windows.Forms.Button();
            this.BtnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.maskedTextBox_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(39, 102);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(367, 21);
            this.comboBox_Empresa.TabIndex = 35;
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Empresa.Location = new System.Drawing.Point(34, 63);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(90, 25);
            this.label_Empresa.TabIndex = 34;
            this.label_Empresa.Text = "Empresa";
            // 
            // radioButton_Matrícula
            // 
            this.radioButton_Matrícula.AutoSize = true;
            this.radioButton_Matrícula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.radioButton_Matrícula.Location = new System.Drawing.Point(48, 376);
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
            this.radioButton_RG.Location = new System.Drawing.Point(47, 353);
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
            this.radioButton_CPF.Location = new System.Drawing.Point(47, 330);
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
            this.radioButton_Nome.Location = new System.Drawing.Point(48, 307);
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
            this.lblFiltroFuncionario.Location = new System.Drawing.Point(33, 272);
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
            this.lblFunCadastrados.Location = new System.Drawing.Point(460, 33);
            this.lblFunCadastrados.Name = "lblFunCadastrados";
            this.lblFunCadastrados.Size = new System.Drawing.Size(124, 25);
            this.lblFunCadastrados.TabIndex = 28;
            this.lblFunCadastrados.Text = "Cadastrados";
            // 
            // lblPesFuncionario
            // 
            this.lblPesFuncionario.AutoSize = true;
            this.lblPesFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPesFuncionario.Location = new System.Drawing.Point(34, 146);
            this.lblPesFuncionario.Name = "lblPesFuncionario";
            this.lblPesFuncionario.Size = new System.Drawing.Size(200, 25);
            this.lblPesFuncionario.TabIndex = 26;
            this.lblPesFuncionario.Text = "Pesquisa Funcionario";
            // 
            // txtPesFuncionario
            // 
            this.txtPesFuncionario.Location = new System.Drawing.Point(39, 187);
            this.txtPesFuncionario.Name = "txtPesFuncionario";
            this.txtPesFuncionario.Size = new System.Drawing.Size(367, 20);
            this.txtPesFuncionario.TabIndex = 25;
            // 
            // btnVisualizarHolerite
            // 
            this.btnVisualizarHolerite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarHolerite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnVisualizarHolerite.FlatAppearance.BorderSize = 0;
            this.btnVisualizarHolerite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarHolerite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisualizarHolerite.Location = new System.Drawing.Point(972, 484);
            this.btnVisualizarHolerite.Name = "btnVisualizarHolerite";
            this.btnVisualizarHolerite.Size = new System.Drawing.Size(145, 54);
            this.btnVisualizarHolerite.TabIndex = 24;
            this.btnVisualizarHolerite.Text = "Visualzar Holerite";
            this.btnVisualizarHolerite.UseVisualStyleBackColor = false;
            this.btnVisualizarHolerite.Click += new System.EventHandler(this.btnVisualizarHolerite_Click);
            // 
            // BtnPesquisarFuncionario
            // 
            this.BtnPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnPesquisarFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisarFuncionario.Location = new System.Drawing.Point(266, 255);
            this.BtnPesquisarFuncionario.Name = "BtnPesquisarFuncionario";
            this.BtnPesquisarFuncionario.Size = new System.Drawing.Size(140, 50);
            this.BtnPesquisarFuncionario.TabIndex = 36;
            this.BtnPesquisarFuncionario.Text = "Pesquisar";
            this.BtnPesquisarFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.BtnPesquisarFuncionario.Click += new System.EventHandler(this.BtnPesquisarFuncionario_Click);
            // 
            // maskedTextBox_DataFim
            // 
            this.maskedTextBox_DataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_DataFim.Location = new System.Drawing.Point(866, 521);
            this.maskedTextBox_DataFim.Mask = "00/00/0000";
            this.maskedTextBox_DataFim.Name = "maskedTextBox_DataFim";
            this.maskedTextBox_DataFim.Size = new System.Drawing.Size(72, 20);
            this.maskedTextBox_DataFim.TabIndex = 41;
            this.maskedTextBox_DataFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_DataInicio
            // 
            this.maskedTextBox_DataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_DataInicio.Location = new System.Drawing.Point(737, 521);
            this.maskedTextBox_DataInicio.Mask = "00/00/0000";
            this.maskedTextBox_DataInicio.Name = "maskedTextBox_DataInicio";
            this.maskedTextBox_DataInicio.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox_DataInicio.TabIndex = 40;
            this.maskedTextBox_DataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblData.Location = new System.Drawing.Point(718, 484);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 25);
            this.lblData.TabIndex = 39;
            this.lblData.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(834, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(707, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "De:";
            // 
            // DgvFuncionario
            // 
            this.DgvFuncionario.AllowUserToAddRows = false;
            this.DgvFuncionario.AllowUserToDeleteRows = false;
            this.DgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionario.Location = new System.Drawing.Point(465, 73);
            this.DgvFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.DgvFuncionario.Name = "DgvFuncionario";
            this.DgvFuncionario.ReadOnly = true;
            this.DgvFuncionario.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFuncionario.RowTemplate.Height = 24;
            this.DgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionario.Size = new System.Drawing.Size(652, 397);
            this.DgvFuncionario.TabIndex = 44;
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 571);
            this.Controls.Add(this.DgvFuncionario);
            this.Controls.Add(this.maskedTextBox_DataFim);
            this.Controls.Add(this.maskedTextBox_DataInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPesquisarFuncionario);
            this.Controls.Add(this.comboBox_Empresa);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.radioButton_Matrícula);
            this.Controls.Add(this.radioButton_RG);
            this.Controls.Add(this.radioButton_CPF);
            this.Controls.Add(this.radioButton_Nome);
            this.Controls.Add(this.lblFiltroFuncionario);
            this.Controls.Add(this.lblFunCadastrados);
            this.Controls.Add(this.lblPesFuncionario);
            this.Controls.Add(this.txtPesFuncionario);
            this.Controls.Add(this.btnVisualizarHolerite);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmFolhaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FOLHA DE PAGAMENTO";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
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
        private System.Windows.Forms.Label lblPesFuncionario;
        private System.Windows.Forms.TextBox txtPesFuncionario;
        private System.Windows.Forms.Button btnVisualizarHolerite;
        private System.Windows.Forms.Button BtnPesquisarFuncionario;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvFuncionario;
    }
}