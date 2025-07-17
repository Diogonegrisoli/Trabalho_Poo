namespace Hospital.Formularios
{
    partial class FrmCadastrarMedicos
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
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCadastrarMedicos = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbCrm = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone.Location = new System.Drawing.Point(268, 245);
            this.mtxtTelefone.Mask = "(00)00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(187, 35);
            this.mtxtTelefone.TabIndex = 75;
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDataNascimento.Location = new System.Drawing.Point(494, 245);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(127, 35);
            this.mtxtDataNascimento.TabIndex = 74;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCpf.Location = new System.Drawing.Point(56, 245);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(191, 35);
            this.mtxtCpf.TabIndex = 73;
            // 
            // lbCadastrarMedicos
            // 
            this.lbCadastrarMedicos.BackColor = System.Drawing.Color.Gray;
            this.lbCadastrarMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCadastrarMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastrarMedicos.Location = new System.Drawing.Point(0, 0);
            this.lbCadastrarMedicos.Name = "lbCadastrarMedicos";
            this.lbCadastrarMedicos.Size = new System.Drawing.Size(817, 47);
            this.lbCadastrarMedicos.TabIndex = 72;
            this.lbCadastrarMedicos.Text = "CADASTRAR MEDICO";
            this.lbCadastrarMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(688, 148);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(46, 35);
            this.txtSexo.TabIndex = 67;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(56, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 35);
            this.txtNome.TabIndex = 66;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(681, 108);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(102, 31);
            this.lbSexo.TabIndex = 64;
            this.lbSexo.Text = "SEXO:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(262, 205);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(175, 31);
            this.lbTelefone.TabIndex = 63;
            this.lbTelefone.Text = "TELEFONE:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(49, 108);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(108, 31);
            this.lbNome.TabIndex = 62;
            this.lbNome.Text = "NOME:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(49, 205);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(81, 31);
            this.lbCpf.TabIndex = 61;
            this.lbCpf.Text = "CPF:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(490, 205);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(197, 31);
            this.lbDataNascimento.TabIndex = 60;
            this.lbDataNascimento.Text = "DATA NASC.:";
            // 
            // lbCrm
            // 
            this.lbCrm.AutoSize = true;
            this.lbCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrm.Location = new System.Drawing.Point(488, 108);
            this.lbCrm.Name = "lbCrm";
            this.lbCrm.Size = new System.Drawing.Size(88, 31);
            this.lbCrm.TabIndex = 76;
            this.lbCrm.Text = "CRM:";
            // 
            // txtCrm
            // 
            this.txtCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.Location = new System.Drawing.Point(494, 148);
            this.txtCrm.MaxLength = 9;
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(138, 35);
            this.txtCrm.TabIndex = 77;
            this.txtCrm.TextChanged += new System.EventHandler(this.txtCrm_TextChanged);
            this.txtCrm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCrm_KeyPress);
            // 
            // FrmCadastrarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.lbCrm);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtDataNascimento);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.lbCadastrarMedicos);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbDataNascimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarMedicos";
            this.Text = "FrmCadastrarMedicos";
            this.Load += new System.EventHandler(this.FrmCadastrarMedicos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label lbCadastrarMedicos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbCrm;
        private System.Windows.Forms.TextBox txtCrm;
    }
}