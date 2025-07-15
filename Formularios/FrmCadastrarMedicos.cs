using Hospital.DAO;
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

namespace Hospital.Formularios
{
    public partial class FrmCadastrarMedicos : Form
    {
        private Form1 formPrincipal;
        public FrmCadastrarMedicos(Form1 panelForm1)
        {
            InitializeComponent();
            formPrincipal = panelForm1;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty || mtxtCpf.Text == string.Empty || txtSexo.Text == string.Empty || mtxtTelefone.Text == string.Empty || txtCrm.Text == string.Empty)
                {
                    throw new Exception("Preencha todos os campos!");
                }
                char sexo = Convert.ToChar(txtSexo.Text.ToString().ToUpper());
                string nome = txtNome.Text;
                string crm = txtCrm.Text;
                string telefone = mtxtTelefone.Text;
                DateTime data_nascimento = Convert.ToDateTime(mtxtDataNascimento.Text);
                string cpf = mtxtCpf.Text;

                MedicosDAO medicoDAO = new MedicosDAO();
                Medicos medico = new Medicos(sexo, nome, crm, telefone, data_nascimento, cpf);

                medicoDAO.Cadastrar(medico);
                MessageBox.Show("Médico cadastrado com sucesso!", "CADASTRAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtSexo.Clear();
                mtxtCpf.Clear();
                mtxtTelefone.Clear();
                mtxtDataNascimento.Clear();
                txtCrm.Clear();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSexo.Clear();
            mtxtCpf.Clear();
            mtxtTelefone.Clear();
            mtxtDataNascimento.Clear();
            txtCrm.Clear();
            txtNome.Focus();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmMedico(formPrincipal));
        }

        private void mtxtCrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == true)
            {
                switch (txtCrm.TextLength)
                {
                    case 0:
                        txtCrm.Text = "";
                        break;

                    case 6:
                        txtCrm.Text = txtCrm.Text + "/";
                        txtCrm.SelectionStart = 7;
                        break;
                }
            }
        }

        private void txtCrm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
