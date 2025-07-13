namespace Hospital.Formularios
{
    partial class FrmPaciente
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
            this.lbConsultarPacientes = new System.Windows.Forms.Label();
            this.btPacientesCadastrar = new System.Windows.Forms.Button();
            this.btPacientesConsultar = new System.Windows.Forms.Button();
            this.btPacientesAtualizar = new System.Windows.Forms.Button();
            this.btPacientesDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsultarPacientes
            // 
            this.lbConsultarPacientes.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPacientes.Location = new System.Drawing.Point(0, 0);
            this.lbConsultarPacientes.Name = "lbConsultarPacientes";
            this.lbConsultarPacientes.Size = new System.Drawing.Size(817, 46);
            this.lbConsultarPacientes.TabIndex = 1;
            this.lbConsultarPacientes.Text = "PACIENTES";
            this.lbConsultarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConsultarPacientes.Click += new System.EventHandler(this.lbConsultarClientes_Click);
            // 
            // btPacientesCadastrar
            // 
            this.btPacientesCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientesCadastrar.Location = new System.Drawing.Point(120, 144);
            this.btPacientesCadastrar.Name = "btPacientesCadastrar";
            this.btPacientesCadastrar.Size = new System.Drawing.Size(180, 125);
            this.btPacientesCadastrar.TabIndex = 2;
            this.btPacientesCadastrar.Text = "CADASTRAR";
            this.btPacientesCadastrar.UseVisualStyleBackColor = true;
            this.btPacientesCadastrar.Click += new System.EventHandler(this.btPacientesCadastrar_Click);
            // 
            // btPacientesConsultar
            // 
            this.btPacientesConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientesConsultar.Location = new System.Drawing.Point(512, 144);
            this.btPacientesConsultar.Name = "btPacientesConsultar";
            this.btPacientesConsultar.Size = new System.Drawing.Size(180, 125);
            this.btPacientesConsultar.TabIndex = 3;
            this.btPacientesConsultar.Text = "CONSULTAR";
            this.btPacientesConsultar.UseVisualStyleBackColor = true;
            this.btPacientesConsultar.Click += new System.EventHandler(this.btPacientesConsultar_Click);
            // 
            // btPacientesAtualizar
            // 
            this.btPacientesAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientesAtualizar.Location = new System.Drawing.Point(120, 320);
            this.btPacientesAtualizar.Name = "btPacientesAtualizar";
            this.btPacientesAtualizar.Size = new System.Drawing.Size(180, 125);
            this.btPacientesAtualizar.TabIndex = 4;
            this.btPacientesAtualizar.Text = "ATUALIZAR";
            this.btPacientesAtualizar.UseVisualStyleBackColor = true;
            this.btPacientesAtualizar.Click += new System.EventHandler(this.btPacientesAtualizar_Click);
            // 
            // btPacientesDeletar
            // 
            this.btPacientesDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientesDeletar.Location = new System.Drawing.Point(512, 320);
            this.btPacientesDeletar.Name = "btPacientesDeletar";
            this.btPacientesDeletar.Size = new System.Drawing.Size(180, 125);
            this.btPacientesDeletar.TabIndex = 5;
            this.btPacientesDeletar.Text = "DELETAR";
            this.btPacientesDeletar.UseVisualStyleBackColor = true;
            this.btPacientesDeletar.Click += new System.EventHandler(this.btPacientesDeletar_Click);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btPacientesDeletar);
            this.Controls.Add(this.btPacientesAtualizar);
            this.Controls.Add(this.btPacientesConsultar);
            this.Controls.Add(this.btPacientesCadastrar);
            this.Controls.Add(this.lbConsultarPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbConsultarPacientes;
        private System.Windows.Forms.Button btPacientesCadastrar;
        private System.Windows.Forms.Button btPacientesConsultar;
        private System.Windows.Forms.Button btPacientesAtualizar;
        private System.Windows.Forms.Button btPacientesDeletar;
    }
}