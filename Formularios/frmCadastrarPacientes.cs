using Hospital.Mapeamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.DAO;

namespace Hospital.Formularios
{
    public partial class frmCadastrarPacientes : Form
    {
        private Form1 formPrincipal;

        public frmCadastrarPacientes(Form1 panelForm1)
        {
            InitializeComponent();
            formPrincipal = panelForm1;
        }

        private void frmCadastrarPacientes_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmPaciente(formPrincipal));
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try 
            {
                char sexo = Convert.ToChar(txtSexo.Text);
                string nome = txtNome.Text;
                string tipo_sangue = txtTipoSangue.Text;
                string telefone = txtTelefone.Text;
                DateTime data_nascimento = Convert.ToDateTime(txtDataNascimento.Text);
                string cpf = txtCpf.Text;

                PacientesDAO pacienteDAO = new PacientesDAO();
                Pacientes paciente = new Pacientes(sexo, nome, tipo_sangue, telefone, data_nascimento, cpf);

                pacienteDAO.Cadastrar(paciente);
                MessageBox.Show("Paciente cadastrado com sucesso!", "PACIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"PACIENTE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSexo.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtDataNascimento.Clear();
            txtTipoSangue.Clear();
            txtNome.Focus();
        }
    }
}
