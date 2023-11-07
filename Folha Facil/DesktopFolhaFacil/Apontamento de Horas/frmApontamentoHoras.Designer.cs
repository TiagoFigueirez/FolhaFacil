namespace PrototipoRH.Apontamento_de_Horas
{
    partial class frmApontamentoHoras
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
            this.maskedTextBox_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.label_Funcionario = new System.Windows.Forms.Label();
            this.label_Empresa = new System.Windows.Forms.Label();
            this.comboBox_Empresa = new System.Windows.Forms.ComboBox();
            this.comboBox_Funcionario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_DataFim
            // 
            this.maskedTextBox_DataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_DataFim.Location = new System.Drawing.Point(785, 514);
            this.maskedTextBox_DataFim.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_DataFim.Mask = "00/00/0000";
            this.maskedTextBox_DataFim.Name = "maskedTextBox_DataFim";
            this.maskedTextBox_DataFim.Size = new System.Drawing.Size(95, 22);
            this.maskedTextBox_DataFim.TabIndex = 31;
            this.maskedTextBox_DataFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_DataInicio
            // 
            this.maskedTextBox_DataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox_DataInicio.Location = new System.Drawing.Point(613, 514);
            this.maskedTextBox_DataInicio.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_DataInicio.Mask = "00/00/0000";
            this.maskedTextBox_DataInicio.Name = "maskedTextBox_DataInicio";
            this.maskedTextBox_DataInicio.Size = new System.Drawing.Size(93, 22);
            this.maskedTextBox_DataInicio.TabIndex = 30;
            this.maskedTextBox_DataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblData.Location = new System.Drawing.Point(588, 469);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 29);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(743, 521);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(573, 519);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "De:";
            // 
            // button_Editar
            // 
            this.button_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Editar.FlatAppearance.BorderSize = 0;
            this.button_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Editar.ForeColor = System.Drawing.Color.White;
            this.button_Editar.Location = new System.Drawing.Point(961, 491);
            this.button_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(139, 44);
            this.button_Editar.TabIndex = 24;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = false;
            // 
            // button_Consultar
            // 
            this.button_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.button_Consultar.FlatAppearance.BorderSize = 0;
            this.button_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Consultar.Location = new System.Drawing.Point(347, 222);
            this.button_Consultar.Margin = new System.Windows.Forms.Padding(4);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(153, 44);
            this.button_Consultar.TabIndex = 22;
            this.button_Consultar.Text = "Mostrar Pontos";
            this.button_Consultar.UseVisualStyleBackColor = false;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.AllowUserToAddRows = false;
            this.dataGridView_Consulta.AllowUserToDeleteRows = false;
            this.dataGridView_Consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(548, 42);
            this.dataGridView_Consulta.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.ReadOnly = true;
            this.dataGridView_Consulta.RowHeadersWidth = 51;
            this.dataGridView_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Consulta.Size = new System.Drawing.Size(552, 406);
            this.dataGridView_Consulta.TabIndex = 21;
            // 
            // label_Funcionario
            // 
            this.label_Funcionario.AutoSize = true;
            this.label_Funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Funcionario.Location = new System.Drawing.Point(35, 138);
            this.label_Funcionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Funcionario.Name = "label_Funcionario";
            this.label_Funcionario.Size = new System.Drawing.Size(145, 29);
            this.label_Funcionario.TabIndex = 19;
            this.label_Funcionario.Text = "Funcionário";
            // 
            // label_Empresa
            // 
            this.label_Empresa.AutoSize = true;
            this.label_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label_Empresa.Location = new System.Drawing.Point(35, 44);
            this.label_Empresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Empresa.Name = "label_Empresa";
            this.label_Empresa.Size = new System.Drawing.Size(115, 29);
            this.label_Empresa.TabIndex = 18;
            this.label_Empresa.Text = "Empresa";
            // 
            // comboBox_Empresa
            // 
            this.comboBox_Empresa.FormattingEnabled = true;
            this.comboBox_Empresa.Location = new System.Drawing.Point(41, 79);
            this.comboBox_Empresa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Empresa.Name = "comboBox_Empresa";
            this.comboBox_Empresa.Size = new System.Drawing.Size(459, 24);
            this.comboBox_Empresa.TabIndex = 17;
            this.comboBox_Empresa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Empresa_SelectedIndexChanged);
            // 
            // comboBox_Funcionario
            // 
            this.comboBox_Funcionario.FormattingEnabled = true;
            this.comboBox_Funcionario.Location = new System.Drawing.Point(40, 182);
            this.comboBox_Funcionario.Name = "comboBox_Funcionario";
            this.comboBox_Funcionario.Size = new System.Drawing.Size(460, 24);
            this.comboBox_Funcionario.TabIndex = 33;
            // 
            // frmApontamentoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 571);
            this.Controls.Add(this.comboBox_Funcionario);
            this.Controls.Add(this.maskedTextBox_DataFim);
            this.Controls.Add(this.maskedTextBox_DataInicio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.dataGridView_Consulta);
            this.Controls.Add(this.label_Funcionario);
            this.Controls.Add(this.label_Empresa);
            this.Controls.Add(this.comboBox_Empresa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmApontamentoHoras";
            this.Text = "APONTAMENTO DE HORAS";
            this.Load += new System.EventHandler(this.frmApontamentoHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DataInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
        private System.Windows.Forms.Label label_Funcionario;
        private System.Windows.Forms.Label label_Empresa;
        private System.Windows.Forms.ComboBox comboBox_Empresa;
        private System.Windows.Forms.ComboBox comboBox_Funcionario;
    }
}