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
            this.btCadastrarPacientes = new System.Windows.Forms.Button();
            this.btConsultarPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsultarPacientes
            // 
            this.lbConsultarPacientes.BackColor = System.Drawing.Color.Gray;
            this.lbConsultarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarPacientes.Location = new System.Drawing.Point(0, 0);
            this.lbConsultarPacientes.Name = "lbConsultarPacientes";
            this.lbConsultarPacientes.Size = new System.Drawing.Size(817, 64);
            this.lbConsultarPacientes.TabIndex = 1;
            this.lbConsultarPacientes.Text = "PACIENTES";
            this.lbConsultarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConsultarPacientes.Click += new System.EventHandler(this.lbConsultarClientes_Click);
            // 
            // btCadastrarPacientes
            // 
            this.btCadastrarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarPacientes.Location = new System.Drawing.Point(102, 194);
            this.btCadastrarPacientes.Name = "btCadastrarPacientes";
            this.btCadastrarPacientes.Size = new System.Drawing.Size(242, 191);
            this.btCadastrarPacientes.TabIndex = 2;
            this.btCadastrarPacientes.Text = "CADASTRAR";
            this.btCadastrarPacientes.UseVisualStyleBackColor = true;
            this.btCadastrarPacientes.Click += new System.EventHandler(this.btPacientesCadastrar_Click);
            // 
            // btConsultarPacientes
            // 
            this.btConsultarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarPacientes.Location = new System.Drawing.Point(465, 194);
            this.btConsultarPacientes.Name = "btConsultarPacientes";
            this.btConsultarPacientes.Size = new System.Drawing.Size(242, 191);
            this.btConsultarPacientes.TabIndex = 4;
            this.btConsultarPacientes.Text = "CONSULTAR";
            this.btConsultarPacientes.UseVisualStyleBackColor = true;
            this.btConsultarPacientes.Click += new System.EventHandler(this.btPacientesConsultar_Click_1);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btConsultarPacientes);
            this.Controls.Add(this.btCadastrarPacientes);
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
        private System.Windows.Forms.Button btCadastrarPacientes;
        private System.Windows.Forms.Button btConsultarPacientes;
    }
}