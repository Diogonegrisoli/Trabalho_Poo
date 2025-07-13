using Hospital.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hospital.Mapeamento;
using System.Windows.Forms;

namespace Hospital.Formularios
{
    public partial class frmAtualizarPacientes : Form
    {
        public Form1 formPrincipal;
        public frmAtualizarPacientes(Form1 form1)
        {
            InitializeComponent();
            formPrincipal = form1;
        }

        public frmAtualizarPacientes() { }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmPaciente(formPrincipal));
        }

        private void frmAtualizarPacientes_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        public void ListViewInserir(ListViewItem lista)
        {
            lstPacientes.Items.Add(lista);
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            PacientesDAO pacienteDAO = new PacientesDAO();
            Pacientes paciente = new Pacientes();

            try
            {
                if (cbFiltrar.SelectedIndex == 1)
                {
                    paciente.Id_paciente = Convert.ToInt32(txtBuscar.Text);
                }
                else if (cbFiltrar.SelectedIndex == 2)
                {
                    paciente.Nome = txtBuscar.Text;
                }
                else if(cbFiltrar.SelectedIndex == 3)
                {
                    paciente.Cpf = txtBuscar.Text;
                }

                    var listaPacientes = pacienteDAO.Selecionar(paciente);
                
                string id; //Para transformar o id do paciente em string para poder utilizar no listView

                lstPacientes.Items.Clear();
                foreach (var p in listaPacientes)
                {
                    string[] linha =
                    {
                    id = Convert.ToString(p.Id_paciente),
                    p.Nome,
                    p.Cpf,
                    p.Telefone,
                    p.Tipo_Sangue
                    };

                    lstPacientes.Items.Add(new ListViewItem(linha));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PACIENTES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.SelectedIndex == 0 || cbFiltrar.SelectedIndex == 1 || cbFiltrar.SelectedIndex == 2)
            {
                txtBuscar.ReadOnly = false;
            }
        }

        private void lstPacientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }
    }
}
