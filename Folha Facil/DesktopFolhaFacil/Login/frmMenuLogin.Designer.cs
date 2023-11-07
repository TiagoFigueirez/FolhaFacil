namespace PrototipoRH.Usuarios
{
    partial class frmUsuario
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnRefreshUsuario = new System.Windows.Forms.Button();
            this.lblUsuCadastrados = new System.Windows.Forms.Label();
            this.btnExcluFuncionario = new System.Windows.Forms.Button();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.BtnPesquisarUsuario = new System.Windows.Forms.Button();
            this.lblPesUsuario = new System.Windows.Forms.Label();
            this.txtPesUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(351, 77);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(489, 310);
            this.dgvUsuario.TabIndex = 42;
            // 
            // btnRefreshUsuario
            // 
            this.btnRefreshUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshUsuario.Image = global::PrototipoRH.Properties.Resources.icons8_actualizar_32;
            this.btnRefreshUsuario.Location = new System.Drawing.Point(806, 32);
            this.btnRefreshUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshUsuario.Name = "btnRefreshUsuario";
            this.btnRefreshUsuario.Size = new System.Drawing.Size(34, 32);
            this.btnRefreshUsuario.TabIndex = 41;
            this.btnRefreshUsuario.UseVisualStyleBackColor = true;
            this.btnRefreshUsuario.Click += new System.EventHandler(this.btnRefreshUsuario_Click_1);
            // 
            // lblUsuCadastrados
            // 
            this.lblUsuCadastrados.AutoSize = true;
            this.lblUsuCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblUsuCadastrados.Location = new System.Drawing.Point(346, 32);
            this.lblUsuCadastrados.Name = "lblUsuCadastrados";
            this.lblUsuCadastrados.Size = new System.Drawing.Size(124, 25);
            this.lblUsuCadastrados.TabIndex = 40;
            this.lblUsuCadastrados.Text = "Cadastrados";
            // 
            // btnExcluFuncionario
            // 
            this.btnExcluFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnExcluFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluFuncionario.Location = new System.Drawing.Point(730, 399);
            this.btnExcluFuncionario.Name = "btnExcluFuncionario";
            this.btnExcluFuncionario.Size = new System.Drawing.Size(109, 44);
            this.btnExcluFuncionario.TabIndex = 39;
            this.btnExcluFuncionario.Text = "Excluir";
            this.btnExcluFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluFuncionario.Click += new System.EventHandler(this.btnExcluFuncionario_Click);
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditarUsuario.Location = new System.Drawing.Point(606, 399);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(109, 44);
            this.BtnEditarUsuario.TabIndex = 38;
            this.BtnEditarUsuario.Text = "Editar";
            this.BtnEditarUsuario.UseVisualStyleBackColor = false;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.btnAddUsuario.FlatAppearance.BorderSize = 0;
            this.btnAddUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUsuario.Location = new System.Drawing.Point(481, 399);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(109, 44);
            this.btnAddUsuario.TabIndex = 37;
            this.btnAddUsuario.Text = "Adicionar";
            this.btnAddUsuario.UseVisualStyleBackColor = false;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // BtnPesquisarUsuario
            // 
            this.BtnPesquisarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.BtnPesquisarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnPesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisarUsuario.Location = new System.Drawing.Point(199, 153);
            this.BtnPesquisarUsuario.Name = "BtnPesquisarUsuario";
            this.BtnPesquisarUsuario.Size = new System.Drawing.Size(105, 41);
            this.BtnPesquisarUsuario.TabIndex = 36;
            this.BtnPesquisarUsuario.Text = "Pesquisar";
            this.BtnPesquisarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPesquisarUsuario.UseVisualStyleBackColor = false;
            this.BtnPesquisarUsuario.Click += new System.EventHandler(this.BtnPesquisarUsuario_Click);
            // 
            // lblPesUsuario
            // 
            this.lblPesUsuario.AutoSize = true;
            this.lblPesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(129)))));
            this.lblPesUsuario.Location = new System.Drawing.Point(25, 77);
            this.lblPesUsuario.Name = "lblPesUsuario";
            this.lblPesUsuario.Size = new System.Drawing.Size(165, 25);
            this.lblPesUsuario.TabIndex = 35;
            this.lblPesUsuario.Text = "Pesquisa Usuario";
            // 
            // txtPesUsuario
            // 
            this.txtPesUsuario.Location = new System.Drawing.Point(28, 110);
            this.txtPesUsuario.Name = "txtPesUsuario";
            this.txtPesUsuario.Size = new System.Drawing.Size(276, 20);
            this.txtPesUsuario.TabIndex = 34;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 464);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnRefreshUsuario);
            this.Controls.Add(this.lblUsuCadastrados);
            this.Controls.Add(this.btnExcluFuncionario);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.btnAddUsuario);
            this.Controls.Add(this.BtnPesquisarUsuario);
            this.Controls.Add(this.lblPesUsuario);
            this.Controls.Add(this.txtPesUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuario";
            this.Text = "USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnRefreshUsuario;
        private System.Windows.Forms.Label lblUsuCadastrados;
        private System.Windows.Forms.Button btnExcluFuncionario;
        private System.Windows.Forms.Button BtnEditarUsuario;
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.Button BtnPesquisarUsuario;
        private System.Windows.Forms.Label lblPesUsuario;
        private System.Windows.Forms.TextBox txtPesUsuario;
    }
}