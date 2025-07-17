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
    public partial class FrmCadastrarConsultas : Form
    {
        private Form1 formPrincipal;
        public FrmCadastrarConsultas(Form1 panelPrincipal)
        {
            InitializeComponent();
            formPrincipal = panelPrincipal;
        }

        private void FrmCadastrarConsultas_Load(object sender, EventArgs e)
        {
            cbPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbMedicos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMedicos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mtxtDataHora.MaskFull || cbMedicos.SelectedIndex == -1 || cbPacientes.SelectedIndex == -1)
                {
                    throw new Exception("Preencha todos os campos!");
                }
                else
                {
                    ConsultasDAO consultaDAO = new ConsultasDAO();

                    DateTime dataHora = Convert.ToDateTime(mtxtDataHora.Text);
                    Medicos medicoSelecionado = (Medicos)cbMedicos.SelectedItem;
                    Pacientes pacienteSelecionado = (Pacientes)cbPacientes.SelectedItem;

                    Consultas novaConsulta = new Consultas()
                    {
                        Data_hora = dataHora,
                        Fk_id_medico = medicoSelecionado.Id_medico,
                        medicoConsulta = medicoSelecionado,
                        Fk_id_paciente = pacienteSelecionado.Id_paciente,
                        pacienteConsulta = pacienteSelecionado
                    };

                    consultaDAO.Cadastrar(novaConsulta);
                    MessageBox.Show("Consulta cadastrada com sucesso!", "CADASTRAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mtxtDataHora.Clear();
                    cbMedicos.SelectedIndex = -1;
                    cbPacientes.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CADASTRAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmConsultas(formPrincipal));
        }

        private void cbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbPacientes_Click(object sender, EventArgs e)
        {
            PacientesDAO pacientesDAO = new PacientesDAO();
            var listaPacientes = pacientesDAO.SelecionarTodos();

            cbPacientes.DataSource = listaPacientes;
            cbPacientes.DisplayMember = "nome";
            cbPacientes.ValueMember = "id_paciente";
        }

        private void cbMedicos_Click(object sender, EventArgs e)
        {
            MedicosDAO medicosDAO = new MedicosDAO();

            var listaMedicos = medicosDAO.SelecionarTodos();

            cbMedicos.DataSource = listaMedicos;
            cbMedicos.DisplayMember = "nome";
            cbMedicos.ValueMember = "id_medico";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            mtxtDataHora.Clear();
            cbPacientes.SelectedIndex = -1;
            cbMedicos.SelectedIndex = -1;
        }
    }
}
