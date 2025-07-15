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
                if (txtNome.Text == string.Empty || mtxtCpf.Text == string.Empty || txtSexo.Text == string.Empty || mtxtTelefone.Text == string.Empty || mtxtDataNascimento.Text == string.Empty || txtTipoSangue.Text == string.Empty)
                {
                    throw new Exception("Preencha todos os campos!");
                }
                char sexo = Convert.ToChar(txtSexo.Text.ToString().ToUpper());
                string nome = txtNome.Text;
                string tipo_sangue = txtTipoSangue.Text;
                string telefone = mtxtTelefone.Text;
                DateTime data_nascimento = Convert.ToDateTime(mtxtDataNascimento.Text);
                string cpf = mtxtCpf.Text;

                PacientesDAO pacienteDAO = new PacientesDAO();
                Pacientes paciente = new Pacientes(sexo, nome, tipo_sangue, telefone, data_nascimento, cpf);

                pacienteDAO.Cadastrar(paciente);
                MessageBox.Show("Paciente cadastrado com sucesso!", "CADASTRAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtSexo.Clear();
                mtxtCpf.Clear();
                mtxtTelefone.Clear();
                mtxtDataNascimento.Clear();
                txtTipoSangue.Clear();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSexo.Clear();
            mtxtCpf.Clear();
            mtxtTelefone.Clear();
            mtxtDataNascimento.Clear();
            txtTipoSangue.Clear();
            txtNome.Focus();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoSangue_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbCadastrarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTipoSangue_Click(object sender, EventArgs e)
        {

        }

        private void lbSexo_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbCpf_Click(object sender, EventArgs e)
        {

        }

        private void lbDataNascimento_Click(object sender, EventArgs e)
        {

        }
    }
}
