namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.btMedicos = new System.Windows.Forms.Button();
            this.btPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.picturePrincipal = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btConsultas);
            this.panelMenu.Controls.Add(this.btMedicos);
            this.panelMenu.Controls.Add(this.btPacientes);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 551);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Transparent;
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(0, 505);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(200, 46);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "SAIR";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "REG. MEDICOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btConsultas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(0, 133);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(200, 49);
            this.btConsultas.TabIndex = 4;
            this.btConsultas.Text = "CONSULTAS";
            this.btConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConsultas.UseVisualStyleBackColor = false;
            // 
            // btMedicos
            // 
            this.btMedicos.BackColor = System.Drawing.Color.Transparent;
            this.btMedicos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btMedicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMedicos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMedicos.Location = new System.Drawing.Point(0, 180);
            this.btMedicos.Name = "btMedicos";
            this.btMedicos.Size = new System.Drawing.Size(200, 48);
            this.btMedicos.TabIndex = 3;
            this.btMedicos.Text = "MEDICOS";
            this.btMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMedicos.UseVisualStyleBackColor = false;
            // 
            // btPacientes
            // 
            this.btPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPacientes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPacientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientes.Location = new System.Drawing.Point(0, 89);
            this.btPacientes.Name = "btPacientes";
            this.btPacientes.Size = new System.Drawing.Size(200, 46);
            this.btPacientes.TabIndex = 1;
            this.btPacientes.Text = "PACIENTES";
            this.btPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPacientes.UseVisualStyleBackColor = false;
            this.btPacientes.Click += new System.EventHandler(this.btPacientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.picturePrincipal);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(200, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(817, 551);
            this.panelPrincipal.TabIndex = 1;
            // 
            // picturePrincipal
            // 
            this.picturePrincipal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picturePrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePrincipal.BackgroundImage")));
            this.picturePrincipal.Image = ((System.Drawing.Image)(resources.GetObject("picturePrincipal.Image")));
            this.picturePrincipal.Location = new System.Drawing.Point(0, 0);
            this.picturePrincipal.Name = "picturePrincipal";
            this.picturePrincipal.Size = new System.Drawing.Size(817, 551);
            this.picturePrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePrincipal.TabIndex = 0;
            this.picturePrincipal.TabStop = false;
            this.picturePrincipal.Click += new System.EventHandler(this.picturePrincipal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1017, 551);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.Button btMedicos;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox picturePrincipal;
    }
}

