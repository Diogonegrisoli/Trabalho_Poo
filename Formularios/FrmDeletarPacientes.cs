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
    public partial class FrmDeletarPacientes : Form
    {
        public Form1 formPrincipal;
        public FrmDeletarPacientes(Form1 form1)
        {
            InitializeComponent();
            formPrincipal = form1;
        }

        private void FrmDeletarPacientes_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtDataNascimento.ReadOnly = true;
            txtSexo.ReadOnly = true;
            txtTipoSangue.ReadOnly = true;
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Certeza que deseja deletar este cadastro?", "PACIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);

                    PacientesDAO pacienteDAO = new PacientesDAO();
                    Pacientes paciente = new Pacientes();
                    paciente.Id_paciente = id;

                    pacienteDAO.Deletar(paciente);
                    MessageBox.Show("Cadastro deletado com sucesso!", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmPaciente(formPrincipal));
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtId.Focus();
        }
    }
}
