namespace Hospital.Formularios
{
    partial class frmConsultarPacientes
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
            this.lbAtualizarPaciente = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTipoSangue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAtualizarPaciente
            // 
            this.lbAtualizarPaciente.BackColor = System.Drawing.Color.Gray;
            this.lbAtualizarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAtualizarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtualizarPaciente.Location = new System.Drawing.Point(0, 0);
            this.lbAtualizarPaciente.Name = "lbAtualizarPaciente";
            this.lbAtualizarPaciente.Size = new System.Drawing.Size(817, 47);
            this.lbAtualizarPaciente.TabIndex = 74;
            this.lbAtualizarPaciente.Text = "CONSULTAR PACIENTE";
            this.lbAtualizarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(677, 485);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(111, 46);
            this.btVoltar.TabIndex = 76;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(284, 96);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(246, 29);
            this.txtBuscar.TabIndex = 79;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(542, 94);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 31);
            this.btBuscar.TabIndex = 80;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(281, 78);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 81;
            this.lbBuscar.Text = "Buscar";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 109);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 18);
            this.lbNome.TabIndex = 82;
            this.lbNome.Text = "Nome:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(12, 168);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(69, 18);
            this.lbTelefone.TabIndex = 84;
            this.lbTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 26);
            this.txtNome.TabIndex = 85;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(12, 189);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(251, 26);
            this.txtTelefone.TabIndex = 87;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.YellowGreen;
            this.btSalvar.Location = new System.Drawing.Point(185, 221);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(78, 31);
            this.btSalvar.TabIndex = 88;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Visible = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstNome,
            this.lstCpf,
            this.lstTelefone,
            this.lstDataNascimento,
            this.lstTipoSangue});
            this.lstPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPacientes.HideSelection = false;
            this.lstPacientes.Location = new System.Drawing.Point(284, 131);
            this.lstPacientes.MultiSelect = false;
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(522, 335);
            this.lstPacientes.TabIndex = 89;
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPacientes_ItemSelectionChanged);
            this.lstPacientes.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged_1);
            // 
            // lstId
            // 
            this.lstId.Text = "ID";
            this.lstId.Width = 30;
            // 
            // lstNome
            // 
            this.lstNome.Text = "NOME";
            this.lstNome.Width = 144;
            // 
            // lstCpf
            // 
            this.lstCpf.Text = "CPF";
            this.lstCpf.Width = 94;
            // 
            // lstTelefone
            // 
            this.lstTelefone.Text = "TELEFONE";
            this.lstTelefone.Width = 97;
            // 
            // lstDataNascimento
            // 
            this.lstDataNascimento.Text = "DATA NASCIMENTO";
            this.lstDataNascimento.Width = 90;
            // 
            // lstTipoSangue
            // 
            this.lstTipoSangue.Text = "SANGUE";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "",
            "ID",
            "Nome",
            "Cpf"});
            this.cbFiltrar.Location = new System.Drawing.Point(684, 98);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 28);
            this.cbFiltrar.TabIndex = 90;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(683, 82);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lbFiltrar.TabIndex = 91;
            this.lbFiltrar.Text = "Filtrar";
            this.lbFiltrar.Click += new System.EventHandler(this.lbFiltrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(99, 258);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(78, 31);
            this.btEditar.TabIndex = 92;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btCancelar.Location = new System.Drawing.Point(99, 221);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(78, 31);
            this.btCancelar.TabIndex = 93;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.IndianRed;
            this.btDeletar.Location = new System.Drawing.Point(12, 221);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(78, 31);
            this.btDeletar.TabIndex = 94;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // frmConsultarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbAtualizarPaciente);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarPacientes";
            this.Text = "frmAtualizarPacientes";
            this.Load += new System.EventHandler(this.frmAtualizarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAtualizarPaciente;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstNome;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ColumnHeader lstCpf;
        private System.Windows.Forms.ColumnHeader lstTelefone;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ColumnHeader lstDataNascimento;
        private System.Windows.Forms.ColumnHeader lstTipoSangue;
        private System.Windows.Forms.Button btDeletar;
    }
}