namespace Hospital.Formularios
{
    partial class FrmConsultas
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
            this.btConsultarConsultas = new System.Windows.Forms.Button();
            this.btCadastrarConsultas = new System.Windows.Forms.Button();
            this.lbConsultas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsultarConsultas
            // 
            this.btConsultarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarConsultas.Location = new System.Drawing.Point(465, 194);
            this.btConsultarConsultas.Name = "btConsultarConsultas";
            this.btConsultarConsultas.Size = new System.Drawing.Size(242, 191);
            this.btConsultarConsultas.TabIndex = 7;
            this.btConsultarConsultas.Text = "CONSULTAR";
            this.btConsultarConsultas.UseVisualStyleBackColor = true;
            this.btConsultarConsultas.Click += new System.EventHandler(this.btConsultarConsultas_Click);
            // 
            // btCadastrarConsultas
            // 
            this.btCadastrarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarConsultas.Location = new System.Drawing.Point(102, 194);
            this.btCadastrarConsultas.Name = "btCadastrarConsultas";
            this.btCadastrarConsultas.Size = new System.Drawing.Size(242, 191);
            this.btCadastrarConsultas.TabIndex = 6;
            this.btCadastrarConsultas.Text = "CADASTRAR";
            this.btCadastrarConsultas.UseVisualStyleBackColor = true;
            this.btCadastrarConsultas.Click += new System.EventHandler(this.btCadastrarConsultas_Click);
            // 
            // lbConsultas
            // 
            this.lbConsultas.BackColor = System.Drawing.Color.Gray;
            this.lbConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultas.Location = new System.Drawing.Point(0, 0);
            this.lbConsultas.Name = "lbConsultas";
            this.lbConsultas.Size = new System.Drawing.Size(817, 64);
            this.lbConsultas.TabIndex = 5;
            this.lbConsultas.Text = "CONSULTAS";
            this.lbConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btConsultarConsultas);
            this.Controls.Add(this.btCadastrarConsultas);
            this.Controls.Add(this.lbConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConsultarConsultas;
        private System.Windows.Forms.Button btCadastrarConsultas;
        private System.Windows.Forms.Label lbConsultas;
    }
}