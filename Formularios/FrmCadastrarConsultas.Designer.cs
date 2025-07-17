namespace Hospital.Formularios
{
    partial class FrmCadastrarConsultas
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
            this.lbCadastrarConsulta = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbMedico = new System.Windows.Forms.Label();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.mtxtDataHora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbCadastrarConsulta
            // 
            this.lbCadastrarConsulta.BackColor = System.Drawing.Color.Gray;
            this.lbCadastrarConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCadastrarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastrarConsulta.Location = new System.Drawing.Point(0, 0);
            this.lbCadastrarConsulta.Name = "lbCadastrarConsulta";
            this.lbCadastrarConsulta.Size = new System.Drawing.Size(817, 47);
            this.lbCadastrarConsulta.TabIndex = 72;
            this.lbCadastrarConsulta.Text = "CADASTRAR CONSULTA";
            this.lbCadastrarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(219, 466);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(119, 46);
            this.btLimpar.TabIndex = 71;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(56, 466);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(119, 46);
            this.btCadastrar.TabIndex = 70;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(640, 466);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(111, 46);
            this.btVoltar.TabIndex = 69;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaciente.Location = new System.Drawing.Point(49, 215);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(168, 31);
            this.lbPaciente.TabIndex = 62;
            this.lbPaciente.Text = "PACIENTE:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(50, 108);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(192, 31);
            this.lbDataNascimento.TabIndex = 60;
            this.lbDataNascimento.Text = "DATA/HORA:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedico.Location = new System.Drawing.Point(399, 108);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(138, 31);
            this.lbMedico.TabIndex = 75;
            this.lbMedico.Text = "MEDICO:";
            // 
            // cbPacientes
            // 
            this.cbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(56, 249);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(313, 33);
            this.cbPacientes.TabIndex = 77;
            this.cbPacientes.SelectedIndexChanged += new System.EventHandler(this.cbPacientes_SelectedIndexChanged);
            this.cbPacientes.Click += new System.EventHandler(this.cbPacientes_Click);
            // 
            // cbMedicos
            // 
            this.cbMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(405, 148);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(313, 33);
            this.cbMedicos.TabIndex = 78;
            this.cbMedicos.Click += new System.EventHandler(this.cbMedicos_Click);
            // 
            // mtxtDataHora
            // 
            this.mtxtDataHora.BeepOnError = true;
            this.mtxtDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataHora.Location = new System.Drawing.Point(56, 148);
            this.mtxtDataHora.Mask = "00/00/0000 90:00";
            this.mtxtDataHora.Name = "mtxtDataHora";
            this.mtxtDataHora.Size = new System.Drawing.Size(187, 31);
            this.mtxtDataHora.TabIndex = 74;
            this.mtxtDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadastrarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.mtxtDataHora);
            this.Controls.Add(this.lbCadastrarConsulta);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.lbDataNascimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarConsultas";
            this.Text = "FrmCadastrarConsultas";
            this.Load += new System.EventHandler(this.FrmCadastrarConsultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCadastrarConsulta;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.MaskedTextBox mtxtDataHora;
    }
}