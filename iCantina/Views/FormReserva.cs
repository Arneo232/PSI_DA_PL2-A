using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void TSM_GestaoP_Click(object sender, EventArgs e)
        {
            FormPrato FormP = new FormPrato();
            FormP.Show();
            this.Close();
        }

        private void TSM_Extras_Click(object sender, EventArgs e)
        {
            FormExtra FormEx = new FormExtra();
            FormEx.Show();
            this.Close();
        }

        private void TSM_GestaoM_Click(object sender, EventArgs e)
        {
            FormMenu FormMen = new FormMenu();
            FormMen.Show();
            this.Close();
        }

        private void TSM_GestaoMulta_Click(object sender, EventArgs e)
        {
            FormMulta FormM = new FormMulta();
            FormM.Show();
            this.Close();
        }

        private void TSM_Registo_Click(object sender, EventArgs e)
        {
            FormFuncionario FormFun = new FormFuncionario();
            FormFun.Show();
            this.Close();
        }

        private void TSM_GestaoC_Click(object sender, EventArgs e)
        {
            FormCliente FormC = new FormCliente();
            FormC.Show();
            this.Close();
        }
    }
}
