namespace Hospital.Formularios
{
    partial class frmCadastrarPacientes
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtTipoSangue = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbTipoSangue = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbCadastrarPaciente = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(56, 466);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(119, 46);
            this.btCadastrar.TabIndex = 36;
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
            this.btVoltar.TabIndex = 34;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txtTipoSangue
            // 
            this.txtTipoSangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoSangue.Location = new System.Drawing.Point(56, 352);
            this.txtTipoSangue.Name = "txtTipoSangue";
            this.txtTipoSangue.Size = new System.Drawing.Size(64, 35);
            this.txtTipoSangue.TabIndex = 33;
            this.txtTipoSangue.TextChanged += new System.EventHandler(this.txtTipoSangue_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(513, 148);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(46, 35);
            this.txtSexo.TabIndex = 29;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(56, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 35);
            this.txtNome.TabIndex = 28;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbTipoSangue
            // 
            this.lbTipoSangue.AutoSize = true;
            this.lbTipoSangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoSangue.Location = new System.Drawing.Point(49, 312);
            this.lbTipoSangue.Name = "lbTipoSangue";
            this.lbTipoSangue.Size = new System.Drawing.Size(220, 31);
            this.lbTipoSangue.TabIndex = 26;
            this.lbTipoSangue.Text = "TIPO SANGUE:";
            this.lbTipoSangue.Click += new System.EventHandler(this.lbTipoSangue_Click);
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(506, 108);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(102, 31);
            this.lbSexo.TabIndex = 25;
            this.lbSexo.Text = "SEXO:";
            this.lbSexo.Click += new System.EventHandler(this.lbSexo_Click);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(262, 205);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(175, 31);
            this.lbTelefone.TabIndex = 24;
            this.lbTelefone.Text = "TELEFONE:";
            this.lbTelefone.Click += new System.EventHandler(this.lbTelefone_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(49, 108);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(108, 31);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "NOME:";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(49, 205);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(81, 31);
            this.lbCpf.TabIndex = 22;
            this.lbCpf.Text = "CPF:";
            this.lbCpf.Click += new System.EventHandler(this.lbCpf_Click);
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(502, 205);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(197, 31);
            this.lbDataNascimento.TabIndex = 21;
            this.lbDataNascimento.Text = "DATA NASC.:";
            this.lbDataNascimento.Click += new System.EventHandler(this.lbDataNascimento_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(219, 466);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(119, 46);
            this.btLimpar.TabIndex = 37;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbCadastrarPaciente
            // 
            this.lbCadastrarPaciente.BackColor = System.Drawing.Color.Gray;
            this.lbCadastrarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCadastrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastrarPaciente.Location = new System.Drawing.Point(0, 0);
            this.lbCadastrarPaciente.Name = "lbCadastrarPaciente";
            this.lbCadastrarPaciente.Size = new System.Drawing.Size(817, 47);
            this.lbCadastrarPaciente.TabIndex = 56;
            this.lbCadastrarPaciente.Text = "CADASTRAR PACIENTE";
            this.lbCadastrarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCadastrarPaciente.Click += new System.EventHandler(this.lbCadastrarPaciente_Click);
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCpf.Location = new System.Drawing.Point(56, 245);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(191, 35);
            this.mtxtCpf.TabIndex = 57;
            this.mtxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCpf_MaskInputRejected);
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNascimento.Location = new System.Drawing.Point(508, 245);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(127, 35);
            this.mtxtDataNascimento.TabIndex = 58;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mtxtDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDataNascimento_MaskInputRejected);
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone.Location = new System.Drawing.Point(268, 245);
            this.mtxtTelefone.Mask = "(00)00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(187, 35);
            this.mtxtTelefone.TabIndex = 59;
            this.mtxtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtTelefone_MaskInputRejected);
            // 
            // frmCadastrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtDataNascimento);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.lbCadastrarPaciente);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txtTipoSangue);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbTipoSangue);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbDataNascimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCadastrarPacientes";
            this.Load += new System.EventHandler(this.frmCadastrarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtTipoSangue;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbTipoSangue;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbCadastrarPaciente;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
    }
}