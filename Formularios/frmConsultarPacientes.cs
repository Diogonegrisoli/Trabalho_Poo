using Hospital.DAO;
using Hospital.Mapeamento;
using Hospital.Utilitarios;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Formularios
{
    public partial class frmConsultarPacientes : Form
    {
        public Form1 formPrincipal;
        public frmConsultarPacientes(Form1 form1)
        {
            InitializeComponent();
            formPrincipal = form1;

            lstPacientes.View = View.Details;
            lstPacientes.LabelEdit = true;
            lstPacientes.AllowColumnReorder = true;
            lstPacientes.FullRowSelect = true;
            lstPacientes.GridLines = true;
        }

        public frmConsultarPacientes() { }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtTelefone.Clear();
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
            txtTelefone.ReadOnly = true;
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
            try
            {
                PacientesDAO pacienteDAO = new PacientesDAO();
                Pacientes paciente = new Pacientes();

                if (txtNome.Text == string.Empty || txtTelefone.Text == string.Empty)
                {
                    throw new Exception("Selecione um paciente!");
                }
                paciente.Id_paciente = id_paciente_selecionado;

                paciente.Nome = txtNome.Text;
                paciente.Telefone = txtTelefone.Text;

                pacienteDAO.Atualizar(paciente);
                MessageBox.Show("Paciente atualizado com sucesso!", "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtTelefone.Clear();
                btSalvar.Visible = false;
                btCancelar.Visible = false;
                btEditar.Visible = true;
                txtNome.ReadOnly = true;
                txtTelefone.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o ID!");
                    }
                    paciente.Id_paciente = Convert.ToInt32(txtBuscar.Text);
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 2)
                {
                    paciente.Nome = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 3)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o CPF completo!");
                    }
                    paciente.Cpf = txtBuscar.Text;
                    txtBuscar.Clear();
                }

                var listaPacientes = pacienteDAO.Selecionar(paciente);
                if (listaPacientes.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado com os dados informados!", "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string id; //Para transformar o id do paciente em string para poder utilizar no listView
                string dataNasc;

                lstPacientes.Items.Clear();
                foreach (var p in listaPacientes)
                {
                    string[] linha =
                    {
                    id = Convert.ToString(p.Id_paciente),
                    p.Nome,
                    p.Cpf,
                    p.Telefone,
                    dataNasc = Convert.ToString(p.Data_nasc),
                    p.Tipo_Sangue
                    };

                    lstPacientes.Items.Add(new ListViewItem(linha));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cbFiltrar.SelectedIndex == 0)
            {
                txtBuscar.Focus();
                txtBuscar.ReadOnly = true;
            }
            else if (cbFiltrar.SelectedIndex == 1 || cbFiltrar.SelectedIndex == 2 || cbFiltrar.SelectedIndex == 3)
            {
                txtBuscar.Focus();
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
            btEditar.Visible = false;
            btSalvar.Visible = true;
            btCancelar.Visible = true;
        }

        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmPaciente(formPrincipal));
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btEditar.Visible = true;
            btCancelar.Visible = false;
            btSalvar.Visible = false;
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtNome.Clear();
            txtTelefone.Clear();
        }
        private int id_paciente_selecionado = 0;
        private void lstPacientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection linhaSelecionada = lstPacientes.SelectedItems;

            foreach (ListViewItem linha in linhaSelecionada)
            {
                id_paciente_selecionado = Convert.ToInt32(linha.SubItems[0].Text);
                txtNome.Text = linha.SubItems[1].Text;
                txtTelefone.Text = linha.SubItems[3].Text;
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                PacientesDAO pacienteDAO = new PacientesDAO();
                Pacientes paciente = new Pacientes();

                if (txtNome.Text == string.Empty)
                {
                    throw new Exception("Selecione o paciente!");
                }
                else
                {
                    var resultado = MessageBox.Show("Deseja deletar este paciente?", "DELETAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {           
                        paciente.Id_paciente = id_paciente_selecionado;
                        pacienteDAO.Deletar(paciente);
                        MessageBox.Show("Deletado com sucesso!", "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtTelefone.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
