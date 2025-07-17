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
    public partial class FrmConsultas : Form
    {
        private Form1 formPrincipal;
        public FrmConsultas(Form1 panelPrincipal)
        {
            InitializeComponent();
            formPrincipal = panelPrincipal;
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarConsultas_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmCadastrarConsultas(formPrincipal));
        }

        private void btConsultarConsultas_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmConsultarConsultas(formPrincipal));
        }
    }
}
