namespace PrototipoRH.Empresas
{
    partial class frmEmpresa
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
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.BtnExcluirEmpresa = new System.Windows.Forms.Button();
            this.BtnEditarEmpresa = new System.Windows.Forms.Button();
            this.BtnAddEmpresa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RbtnNomeEmpresa = new System.Windows.Forms.RadioButton();
            this.RbtnCnpjEmpresa = new System.Windows.Forms.RadioButton();
            this.btnPesquisarEmpresa = new System.Windows.Forms.Button();
            this.TxtPesquisarEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiltroEmpresa = new System.Windows.Forms.Label();
            this.btnRefreshEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(350, 72);
            this.dgvEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresa.RowTemplate.Height = 24;
            this.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.Size = new System.Drawing.Size(489, 310);
            this.dgvEmpresa.TabIndex = 45;
            // 
            // BtnExcluirEmpresa
            // 
            this.BtnExcluirEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluirEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnExcluirEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnExcluirEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExcluirEmpresa.Location = new System.Drawing.Point(730, 393);
            this.BtnExcluirEmpresa.Name = "BtnExcluirEmpresa";
            this.BtnExcluirEmpresa.Size = new System.Drawing.Size(109, 44);
            this.BtnExcluirEmpresa.TabIndex = 41;
            this.BtnExcluirEmpresa.Text = "Excluir";
            this.BtnExcluirEmpresa.UseVisualStyleBackColor = false;
            this.BtnExcluirEmpresa.Click += new System.EventHandler(this.BtnExcluirEmpresa_Click_1);
            // 
            // BtnEditarEmpresa
            // 
            this.BtnEditarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnEditarEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEditarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditarEmpresa.Location = new System.Drawing.Point(608, 393);
            this.BtnEditarEmpresa.Name = "BtnEditarEmpresa";
            this.BtnEditarEmpresa.Size = new System.Drawing.Size(109, 44);
            this.BtnEditarEmpresa.TabIndex = 40;
            this.BtnEditarEmpresa.Text = "Editar";
            this.BtnEditarEmpresa.UseVisualStyleBackColor = false;
            this.BtnEditarEmpresa.Click += new System.EventHandler(this.BtnEditarEmpresa_Click);
            // 
            // BtnAddEmpresa
            // 
            this.BtnAddEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnAddEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnAddEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddEmpresa.Location = new System.Drawing.Point(476, 393);
            this.BtnAddEmpresa.Name = "BtnAddEmpresa";
            this.BtnAddEmpresa.Size = new System.Drawing.Size(109, 44);
            this.BtnAddEmpresa.TabIndex = 39;
            this.BtnAddEmpresa.Text = "Adicionar";
            this.BtnAddEmpresa.UseVisualStyleBackColor = false;
            this.BtnAddEmpresa.Click += new System.EventHandler(this.BtnAddEmpresa_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(346, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cadastrados ";
            // 
            // RbtnNomeEmpresa
            // 
            this.RbtnNomeEmpresa.AutoSize = true;
            this.RbtnNomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.RbtnNomeEmpresa.Location = new System.Drawing.Point(28, 245);
            this.RbtnNomeEmpresa.Name = "RbtnNomeEmpresa";
            this.RbtnNomeEmpresa.Size = new System.Drawing.Size(53, 17);
            this.RbtnNomeEmpresa.TabIndex = 38;
            this.RbtnNomeEmpresa.TabStop = true;
            this.RbtnNomeEmpresa.Text = "Nome";
            this.RbtnNomeEmpresa.UseMnemonic = false;
            this.RbtnNomeEmpresa.UseVisualStyleBackColor = true;
            // 
            // RbtnCnpjEmpresa
            // 
            this.RbtnCnpjEmpresa.AutoSize = true;
            this.RbtnCnpjEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.RbtnCnpjEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.RbtnCnpjEmpresa.Location = new System.Drawing.Point(28, 268);
            this.RbtnCnpjEmpresa.Name = "RbtnCnpjEmpresa";
            this.RbtnCnpjEmpresa.Size = new System.Drawing.Size(52, 17);
            this.RbtnCnpjEmpresa.TabIndex = 37;
            this.RbtnCnpjEmpresa.TabStop = true;
            this.RbtnCnpjEmpresa.Text = "CNPJ";
            this.RbtnCnpjEmpresa.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnPesquisarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnPesquisarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(199, 147);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(105, 41);
            this.btnPesquisarEmpresa.TabIndex = 36;
            this.btnPesquisarEmpresa.Text = "Pesquisar";
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = false;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click_1);
            // 
            // TxtPesquisarEmpresa
            // 
            this.TxtPesquisarEmpresa.Location = new System.Drawing.Point(28, 105);
            this.TxtPesquisarEmpresa.Name = "TxtPesquisarEmpresa";
            this.TxtPesquisarEmpresa.Size = new System.Drawing.Size(276, 20);
            this.TxtPesquisarEmpresa.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(26, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Filtrar por:";
            // 
            // lblFiltroEmpresa
            // 
            this.lblFiltroEmpresa.AutoSize = true;
            this.lblFiltroEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.lblFiltroEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblFiltroEmpresa.Location = new System.Drawing.Point(25, 72);
            this.lblFiltroEmpresa.Name = "lblFiltroEmpresa";
            this.lblFiltroEmpresa.Size = new System.Drawing.Size(182, 25);
            this.lblFiltroEmpresa.TabIndex = 42;
            this.lblFiltroEmpresa.Text = "Pesquisar Empresa";
            // 
            // btnRefreshEmpresa
            // 
            this.btnRefreshEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshEmpresa.Image = global::PrototipoRH.Properties.Resources.icons8_actualizar_32;
            this.btnRefreshEmpresa.Location = new System.Drawing.Point(805, 27);
            this.btnRefreshEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshEmpresa.Name = "btnRefreshEmpresa";
            this.btnRefreshEmpresa.Size = new System.Drawing.Size(34, 32);
            this.btnRefreshEmpresa.TabIndex = 46;
            this.btnRefreshEmpresa.UseVisualStyleBackColor = true;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.btnRefreshEmpresa);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.BtnExcluirEmpresa);
            this.Controls.Add(this.BtnEditarEmpresa);
            this.Controls.Add(this.BtnAddEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbtnNomeEmpresa);
            this.Controls.Add(this.RbtnCnpjEmpresa);
            this.Controls.Add(this.btnPesquisarEmpresa);
            this.Controls.Add(this.TxtPesquisarEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFiltroEmpresa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmpresa";
            this.Text = "EMPRESA";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button BtnExcluirEmpresa;
        private System.Windows.Forms.Button BtnEditarEmpresa;
        private System.Windows.Forms.Button BtnAddEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbtnNomeEmpresa;
        private System.Windows.Forms.RadioButton RbtnCnpjEmpresa;
        private System.Windows.Forms.Button btnPesquisarEmpresa;
        private System.Windows.Forms.TextBox TxtPesquisarEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiltroEmpresa;
        private System.Windows.Forms.Button btnRefreshEmpresa;
    }
}