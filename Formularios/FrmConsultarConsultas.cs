using Hospital.DAO;
using Hospital.Mapeamento;
using Mysqlx.Crud;
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
    public partial class FrmConsultarConsultas : Form
    {
        Form1 formPrincipal;
        public FrmConsultarConsultas(Form1 panelForm)
        {
            InitializeComponent();
            formPrincipal = panelForm;

            lstConsultas.View = View.Details;
            lstConsultas.LabelEdit = true;
            lstConsultas.AllowColumnReorder = true;
            lstConsultas.FullRowSelect = true;
            lstConsultas.GridLines = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ConsultasDAO consultaDAO = new ConsultasDAO();
            Consultas consulta = new Consultas()
            {
                medicoConsulta = new Medicos(),
                pacienteConsulta = new Pacientes(),
            };
            

            try
            {
                if (cbFiltrar.SelectedIndex == 0)
                {
                    CarregarConsultas();
                }
                else if (cbFiltrar.SelectedIndex == 1)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o ID!");
                    }
                    consulta.Id_consulta = Convert.ToInt32(txtBuscar.Text);
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 2)
                {
                    if (txtBuscar.Text == string.Empty)
                        throw new Exception("Informe o nome do paciente!");

                    consulta.pacienteConsulta.Nome = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 3)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o CPF completo!");
                    }
                    consulta.pacienteConsulta.Cpf = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 4)
                {
                    if (txtBuscar.Text == string.Empty)
                        throw new Exception("Informe o nome do médico!");

                    consulta.medicoConsulta.Nome = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 5)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o ID do médico!");
                    }
                    consulta.medicoConsulta.Id_medico = Convert.ToInt32(txtBuscar.Text);
                    txtBuscar.Clear();
                }

                var listaConsultas = consultaDAO.Selecionar(consulta);

                if(listaConsultas.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado com os dados informados!", "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string idConsulta; //Para transformar o id do paciente em string para poder utilizar no listView
                string idMedico;
                string data;

                lstConsultas.Items.Clear();
                foreach (var c in listaConsultas)
                {
                    string[] linha =
                    {
                    idConsulta = Convert.ToString(c.Id_consulta),
                    data = Convert.ToString(c.Data_hora),
                    c.pacienteConsulta.Nome,
                    c.pacienteConsulta.Cpf,
                    c.medicoConsulta.Nome,
                    idMedico = Convert.ToString(c.medicoConsulta.Id_medico),
                    };

                    lstConsultas.Items.Add(new ListViewItem(linha));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection linhaSelecionada = lstConsultas.SelectedItems;

            foreach (ListViewItem linha in linhaSelecionada)
            {
                id_consulta_selecionado = Convert.ToInt32(linha.SubItems[0].Text);
                txtData.Text = linha.SubItems[1].Text;
                txtPaciente.Text = linha.SubItems[2].Text;
                txtMedico.Text = linha.SubItems[4].Text;
            }
        }
        private int id_consulta_selecionado;

        private void CarregarConsultas()
        {
            lstConsultas.Items.Clear();
            ConsultasDAO consultaDAO = new ConsultasDAO();
            List<Consultas> consultas = consultaDAO.SelecionarTodos();

            foreach (Consultas c in consultas)
            {
                ListViewItem item = new ListViewItem(c.Id_consulta.ToString());
                item.SubItems.Add(c.Data_hora.ToString());
                item.SubItems.Add(c.pacienteConsulta.Nome);
                item.SubItems.Add(c.pacienteConsulta.Cpf);
                item.SubItems.Add(c.medicoConsulta.Nome);
                item.SubItems.Add(c.medicoConsulta.Id_medico.ToString());

                lstConsultas.Items.Add(item);
            }
        }
        private void FrmConsultarConsultas_Load(object sender, EventArgs e)
        {
            CarregarConsultas();
        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.SelectedIndex == 0)
            {
                txtBuscar.Focus();
                txtBuscar.ReadOnly = true;
            }
            else if (cbFiltrar.SelectedIndex == 1 || cbFiltrar.SelectedIndex == 2 || cbFiltrar.SelectedIndex == 3 || cbFiltrar.SelectedIndex == 4 || cbFiltrar.SelectedIndex == 5)
            {
                txtBuscar.Focus();
                txtBuscar.ReadOnly = false;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmConsultas(formPrincipal));
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            try 
            {
                ConsultasDAO consultaDAO = new ConsultasDAO();
                Consultas consulta = new Consultas();

                if (txtPaciente.Text == string.Empty || txtMedico.Text == string.Empty)
                {
                    throw new Exception("Selecione uma consulta!");
                }
                else
                {
                    var resultado = MessageBox.Show("Deseja deletar esta consulta?", "DELETAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        consulta.Id_consulta = id_consulta_selecionado;
                        consultaDAO.Deletar(consulta);
                        MessageBox.Show("Consulta deletada com sucesso!", "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPaciente.Clear();
                        txtMedico.Clear();
                        txtData.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
