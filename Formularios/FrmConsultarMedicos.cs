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
    public partial class FrmConsultarMedicos : Form
    {
        private Form1 formPrincipal;
        public FrmConsultarMedicos(Form1 panelForm1)
        {
            InitializeComponent();
            formPrincipal = panelForm1;

            lstMedicos.View = View.Details;
            lstMedicos.LabelEdit = true;
            lstMedicos.AllowColumnReorder = true;
            lstMedicos.FullRowSelect = true;
            lstMedicos.GridLines = true;
        }

        private void FrmConsultarMedicos_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmMedico(formPrincipal));
        }

        private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrar.SelectedIndex == 0)
            {
                txtBuscar.Focus();
                txtBuscar.ReadOnly = true;
            }
            else if (cbFiltrar.SelectedIndex == 1 || cbFiltrar.SelectedIndex == 2 || cbFiltrar.SelectedIndex == 3 || cbFiltrar.SelectedIndex == 4)
            {
                txtBuscar.Focus();
                txtBuscar.ReadOnly = false;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            MedicosDAO medicoDAO = new MedicosDAO();
            Medicos medico = new Medicos();

            try
            {
                if (cbFiltrar.SelectedIndex == 1)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o ID!");
                    }
                    medico.Id_medico = Convert.ToInt32(txtBuscar.Text);
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 2)
                {
                    medico.Nome = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 3)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o CPF completo!");
                    }
                    medico.Cpf = txtBuscar.Text;
                    txtBuscar.Clear();
                }
                else if (cbFiltrar.SelectedIndex == 4)
                {
                    if (txtBuscar.Text == string.Empty)
                    {
                        throw new Exception("Informe o CRM do médico!");
                    }
                    medico.Crm = txtBuscar.Text;
                    txtBuscar.Clear();
                }

                var listaMedicos = medicoDAO.Selecionar(medico);

                string id; //Para transformar o id do medico em string para poder utilizar no listView
                string dataNasc;

                lstMedicos.Items.Clear();
                foreach (var m in listaMedicos)
                {
                    string[] linha =
                    {
                    id = Convert.ToString(m.Id_medico),
                    m.Nome,
                    m.Cpf,
                    m.Telefone,
                    dataNasc = Convert.ToString(m.Data_nasc),
                    m.Crm
                    };

                    lstMedicos.Items.Add(new ListViewItem(linha));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btEditar.Visible = true;
            btCancelar.Visible = false;
            btSalvar.Visible = false;
            txtNome.ReadOnly = true;
            txtCrm.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtNome.Clear();
            txtCrm.Clear();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCrm.ReadOnly = false;
            btEditar.Visible = false;
            btSalvar.Visible = true;
            btCancelar.Visible = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicosDAO medicoDAO = new MedicosDAO();
                Medicos medico = new Medicos();

                if (txtNome.Text == string.Empty || txtTelefone.Text == string.Empty)
                {
                    throw new Exception("Selecione um paciente!");
                }
                medico.Id_medico = id_paciente_selecionado;

                medico.Nome = txtNome.Text;
                medico.Telefone = txtTelefone.Text;
                medico.Crm = txtCrm.Text;

                medicoDAO.Atualizar(medico);
                MessageBox.Show("Paciente atualizado com sucesso!", "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtTelefone.Clear();
                txtCrm.Clear();
                btSalvar.Visible = false;
                btCancelar.Visible = false;
                btEditar.Visible = true;
                txtNome.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtCrm.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CONSULTAR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id_paciente_selecionado;
        private void lstMedicos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection linhaSelecionada = lstMedicos.SelectedItems;

            foreach (ListViewItem linha in linhaSelecionada)
            {
                id_paciente_selecionado = Convert.ToInt32(linha.SubItems[0].Text);
                txtNome.Text = linha.SubItems[1].Text;
                txtTelefone.Text = linha.SubItems[3].Text;
                txtCrm.Text = linha.SubItems[5].Text;
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                MedicosDAO medicoDAO = new MedicosDAO();
                Medicos medico = new Medicos();

                if (txtNome.Text == string.Empty)
                {
                    throw new Exception("Selecione o medico!");
                }
                else
                {
                    var resultado = MessageBox.Show("Deseja deletar este medico?", "DELETAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        medico.Id_medico = id_paciente_selecionado;
                        medicoDAO.Deletar(medico);
                        MessageBox.Show("Deletado com sucesso!", "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Clear();
                        txtTelefone.Clear();
                        txtCrm.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
