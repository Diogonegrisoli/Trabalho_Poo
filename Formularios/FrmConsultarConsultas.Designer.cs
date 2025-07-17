namespace Hospital.Formularios
{
    partial class FrmConsultarConsultas
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
            this.lstConsultas = new System.Windows.Forms.ListView();
            this.lstId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstIdMedico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbConsultarConsultas = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lbDataHora = new System.Windows.Forms.Label();
            this.lstDataConsulta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.IndianRed;
            this.btDeletar.Location = new System.Drawing.Point(12, 292);
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
            this.lbFiltrar.Location = new System.Drawing.Point(683, 92);
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
            "ID (Consulta)",
            "Paciente",
            "CPF (Paciente)",
            "Medico",
            "ID (Medico)"});
            this.cbFiltrar.Location = new System.Drawing.Point(684, 108);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(121, 28);
            this.cbFiltrar.TabIndex = 106;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // lstConsultas
            // 
            this.lstConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstId,
            this.lstDataConsulta,
            this.lstPaciente,
            this.lstCpf,
            this.lstMedico,
            this.lstIdMedico});
            this.lstConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConsultas.HideSelection = false;
            this.lstConsultas.Location = new System.Drawing.Point(284, 142);
            this.lstConsultas.MultiSelect = false;
            this.lstConsultas.Name = "lstConsultas";
            this.lstConsultas.Size = new System.Drawing.Size(523, 335);
            this.lstConsultas.TabIndex = 105;
            this.lstConsultas.UseCompatibleStateImageBehavior = false;
            this.lstConsultas.View = System.Windows.Forms.View.Details;
            this.lstConsultas.SelectedIndexChanged += new System.EventHandler(this.lstPacientes_SelectedIndexChanged);
            // 
            // lstId
            // 
            this.lstId.Text = "ID";
            this.lstId.Width = 30;
            // 
            // lstPaciente
            // 
            this.lstPaciente.Text = "PACIENTE";
            this.lstPaciente.Width = 140;
            // 
            // lstCpf
            // 
            this.lstCpf.Text = "CPF_PACIENTE";
            this.lstCpf.Width = 94;
            // 
            // lstMedico
            // 
            this.lstMedico.Text = "MEDICO";
            this.lstMedico.Width = 140;
            // 
            // lstIdMedico
            // 
            this.lstIdMedico.Text = "ID_MEDICO";
            this.lstIdMedico.Width = 90;
            // 
            // txtMedico
            // 
            this.txtMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.Location = new System.Drawing.Point(12, 199);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.ReadOnly = true;
            this.txtMedico.Size = new System.Drawing.Size(251, 26);
            this.txtMedico.TabIndex = 103;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(12, 140);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(251, 26);
            this.txtPaciente.TabIndex = 102;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(12, 178);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(61, 18);
            this.lbTelefone.TabIndex = 101;
            this.lbTelefone.Text = "Médico:";
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaciente.Location = new System.Drawing.Point(12, 119);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(69, 18);
            this.lbPaciente.TabIndex = 100;
            this.lbPaciente.Text = "Paciente:";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(281, 88);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(40, 13);
            this.lbBuscar.TabIndex = 99;
            this.lbBuscar.Text = "Buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(542, 104);
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
            this.txtBuscar.Location = new System.Drawing.Point(284, 106);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.ReadOnly = true;
            this.txtBuscar.Size = new System.Drawing.Size(246, 29);
            this.txtBuscar.TabIndex = 97;
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(677, 495);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(111, 46);
            this.btVoltar.TabIndex = 96;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbConsultarConsultas
            // 
            this.lbConsultarConsultas.BackColor = System.Drawing.Color.Gray;
            this.lbConsultarConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarConsultas.Location = new System.Drawing.Point(0, 0);
            this.lbConsultarConsultas.Name = "lbConsultarConsultas";
            this.lbConsultarConsultas.Size = new System.Drawing.Size(817, 47);
            this.lbConsultarConsultas.TabIndex = 95;
            this.lbConsultarConsultas.Text = "CONSULTAS REALIZADAS";
            this.lbConsultarConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(12, 258);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(159, 26);
            this.txtData.TabIndex = 112;
            // 
            // lbDataHora
            // 
            this.lbDataHora.AutoSize = true;
            this.lbDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataHora.Location = new System.Drawing.Point(12, 237);
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(80, 18);
            this.lbDataHora.TabIndex = 111;
            this.lbDataHora.Text = "Data/Hora:";
            // 
            // lstDataConsulta
            // 
            this.lstDataConsulta.Text = "DATA/HORA";
            this.lstDataConsulta.Width = 80;
            // 
            // FrmConsultarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbDataHora);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.lstConsultas);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbConsultarConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarConsultas";
            this.Text = "FrmConsultarConsultas";
            this.Load += new System.EventHandler(this.FrmConsultarConsultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ComboBox cbFiltrar;
        private System.Windows.Forms.ListView lstConsultas;
        private System.Windows.Forms.ColumnHeader lstId;
        private System.Windows.Forms.ColumnHeader lstPaciente;
        private System.Windows.Forms.ColumnHeader lstCpf;
        private System.Windows.Forms.ColumnHeader lstMedico;
        private System.Windows.Forms.ColumnHeader lstIdMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbConsultarConsultas;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lbDataHora;
        private System.Windows.Forms.ColumnHeader lstDataConsulta;
    }
}