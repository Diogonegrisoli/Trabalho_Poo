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
    public partial class FrmMedico : Form
    {
        private Form1 formPrincipal;
        public FrmMedico(Form1 panelForm1)
        {
            InitializeComponent();
            formPrincipal = panelForm1;
        }

        private void btCadastrarMedicos_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmCadastrarMedicos(formPrincipal));
        }

        private void btConsultarMedicos_Click(object sender, EventArgs e)
        {
            formPrincipal.MostrarForm(new FrmConsultarMedicos(formPrincipal));
        }
    }
}
