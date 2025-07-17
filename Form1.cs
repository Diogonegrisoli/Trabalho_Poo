using Hospital.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Formularios;
namespace Hospital
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;
        public Form1()
        {
            InitializeComponent();

            try
            {
                Conexao.Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void MostrarForm(Form frm)
        {
            FecharForm();
            frm.TopLevel = false;
            frmAtivo = frm;
            panelPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void FecharForm()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void AtivarBotao(Button frmAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }
            frmAtivo.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao.Conectar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void registrosMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btPacientes_Click(object sender, EventArgs e)
        {
            AtivarBotao(btPacientes);
            MostrarForm(new FrmPaciente(this));
        }

        private void picturePrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btMedicos_Click(object sender, EventArgs e)
        {
            AtivarBotao(btMedicos);
            MostrarForm(new FrmMedico(this));
        }

        private void btConsultas_Click(object sender, EventArgs e)
        {
            AtivarBotao(btConsultas);
            MostrarForm(new FrmConsultas(this));
        }
    }
}
