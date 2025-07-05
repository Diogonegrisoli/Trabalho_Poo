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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
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
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(120, 144);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(180, 125);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(512, 144);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(180, 125);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(120, 320);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(180, 125);
            this.btAtualizar.TabIndex = 4;
            this.btAtualizar.Text = "ATUALIZAR";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(512, 320);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(180, 125);
            this.btDeletar.TabIndex = 5;
            this.btDeletar.Text = "DELETAR";
            this.btDeletar.UseVisualStyleBackColor = true;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbConsultarPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbConsultarPacientes;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btDeletar;
    }
}