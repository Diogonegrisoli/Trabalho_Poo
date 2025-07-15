namespace Hospital.Formularios
{
    partial class FrmConsultarMedicos
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
            this.btDeletar = new System.Windows.Forms.Button();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.lstMedicos = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCrm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCrm = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbConsultarMedico = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.IndianRed;
            this.btDeletar.Location = new System.Drawing.Point(7, 291);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(78, 31);
            this.btDeletar.TabIndex = 110;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(683, 82);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lbFiltrar.TabIndex = 107;
            this.lbFiltrar.Text = "Filtrar";
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "",
            "ID",
            "Nome",
            "Cpf",
            "Crm"});
            this.cbFiltrar.Location = new System.Drawing.Point(684, 98);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 28);
            this.cbFiltrar.TabIndex = 106;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // lstMedicos
            // 
            this.lstMedicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstNome,
            this.lstCpf,
            this.lstTelefone,
            this.lstDataNascimento,
            this.lstCrm});
            this.lstMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMedicos.HideSelection = false;
            this.lstMedicos.Location = new System.Drawing.Point(284, 131);
            this.lstMedicos.MultiSelect = false;
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(522, 335);
            this.lstMedicos.TabIndex = 105;
            this.lstMedicos.UseCompatibleStateImageBehavior = false;
            this.lstMedicos.View = System.Windows.Forms.View.Details;
            this.lstMedicos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstMedicos_ItemSelectionChanged);
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
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
            // lstCrm
            // 
            this.lstCrm.Text = "CRM";
            this.lstCrm.Width = 70;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.YellowGreen;
            this.btSalvar.Location = new System.Drawing.Point(180, 291);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(78, 31);
            this.btSalvar.TabIndex = 104;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Visible = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtCrm
            // 
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.Location = new System.Drawing.Point(12, 189);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.ReadOnly = true;
            this.txtCrm.Size = new System.Drawing.Size(251, 26);
            this.txtCrm.TabIndex = 103;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(251, 26);
            this.txtNome.TabIndex = 102;
            // 
            // lbCrm
            // 
            this.lbCrm.AutoSize = true;
            this.lbCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrm.Location = new System.Drawing.Point(12, 168);
            this.lbCrm.Name = "lbCrm";
            this.lbCrm.Size = new System.Drawing.Size(47, 18);
            this.lbCrm.TabIndex = 101;
            this.lbCrm.Text = "CRM:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 109);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 18);
            this.lbNome.TabIndex = 100;
            this.lbNome.Text = "Nome:";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(281, 78);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 99;
            this.lbBuscar.Text = "Buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(542, 95);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 31);
            this.btBuscar.TabIndex = 98;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(284, 96);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(246, 29);
            this.txtBuscar.TabIndex = 97;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(677, 485);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(111, 46);
            this.btVoltar.TabIndex = 96;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbConsultarMedico
            // 
            this.lbConsultarMedico.BackColor = System.Drawing.Color.Gray;
            this.lbConsultarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarMedico.Location = new System.Drawing.Point(0, 0);
            this.lbConsultarMedico.Name = "lbConsultarMedico";
            this.lbConsultarMedico.Size = new System.Drawing.Size(817, 47);
            this.lbConsultarMedico.TabIndex = 95;
            this.lbConsultarMedico.Text = "CONSULTAR MEDICO";
            this.lbConsultarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(94, 291);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(78, 31);
            this.btEditar.TabIndex = 108;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btCancelar.Location = new System.Drawing.Point(94, 291);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(78, 31);
            this.btCancelar.TabIndex = 109;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(12, 252);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(251, 26);
            this.txtTelefone.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Telefone:";
            // 
            // FrmConsultarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.lstMedicos);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbCrm);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbConsultarMedico);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarMedicos";
            this.Text = "FrmConsultarMedicos";
            this.Load += new System.EventHandler(this.FrmConsultarMedicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.ListView lstMedicos;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstNome;
        private System.Windows.Forms.ColumnHeader lstCpf;
        private System.Windows.Forms.ColumnHeader lstTelefone;
        private System.Windows.Forms.ColumnHeader lstDataNascimento;
        private System.Windows.Forms.ColumnHeader lstCrm;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbCrm;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbConsultarMedico;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label1;
    }
}