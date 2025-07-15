using Hospital.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Mapeamento;

namespace Hospital.Formularios
{
    public partial class FrmPaciente : Form
    {
        private Form1 formPrincipal;

        public FrmPaciente(Form1 panelForm1)
        {
            InitializeComponent();
            formPrincipal = panelForm1;
        }

        private void lbConsultarClientes_Click(object sender, EventArgs e)
        {

        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void btPacientesCadastrar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new frmCadastrarPacientes(formPrincipal));
        }

        private void btPacientesConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void btPacientesConsultar_Click_1(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new frmConsultarPacientes(formPrincipal));
        }
    }
}
