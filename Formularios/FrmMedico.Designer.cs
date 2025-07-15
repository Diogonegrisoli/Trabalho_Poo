namespace Hospital.Formularios
{
    partial class FrmMedico
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
            this.btConsultarMedicos = new System.Windows.Forms.Button();
            this.btCadastrarMedicos = new System.Windows.Forms.Button();
            this.lbConsultarMedicos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsultarMedicos
            // 
            this.btConsultarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarMedicos.Location = new System.Drawing.Point(465, 194);
            this.btConsultarMedicos.Name = "btConsultarMedicos";
            this.btConsultarMedicos.Size = new System.Drawing.Size(242, 191);
            this.btConsultarMedicos.TabIndex = 7;
            this.btConsultarMedicos.Text = "CONSULTAR";
            this.btConsultarMedicos.UseVisualStyleBackColor = true;
            this.btConsultarMedicos.Click += new System.EventHandler(this.btConsultarMedicos_Click);
            // 
            // btCadastrarMedicos
            // 
            this.btCadastrarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMedicos.Location = new System.Drawing.Point(102, 194);
            this.btCadastrarMedicos.Name = "btCadastrarMedicos";
            this.btCadastrarMedicos.Size = new System.Drawing.Size(242, 191);
            this.btCadastrarMedicos.TabIndex = 6;
            this.btCadastrarMedicos.Text = "CADASTRAR";
            this.btCadastrarMedicos.UseVisualStyleBackColor = true;
            this.btCadastrarMedicos.Click += new System.EventHandler(this.btCadastrarMedicos_Click);
            // 
            // lbConsultarMedicos
            // 
            this.lbConsultarMedicos.BackColor = System.Drawing.Color.Gray;
            this.lbConsultarMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarMedicos.Location = new System.Drawing.Point(0, 0);
            this.lbConsultarMedicos.Name = "lbConsultarMedicos";
            this.lbConsultarMedicos.Size = new System.Drawing.Size(817, 64);
            this.lbConsultarMedicos.TabIndex = 5;
            this.lbConsultarMedicos.Text = "MEDICOS";
            this.lbConsultarMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btConsultarMedicos);
            this.Controls.Add(this.btCadastrarMedicos);
            this.Controls.Add(this.lbConsultarMedicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMedico";
            this.Text = "FrmMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConsultarMedicos;
        private System.Windows.Forms.Button btCadastrarMedicos;
        private System.Windows.Forms.Label lbConsultarMedicos;
    }
}