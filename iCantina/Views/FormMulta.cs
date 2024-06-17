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
    public partial class FormMulta : Form
    {
        public FormMulta()
        {
            InitializeComponent();
        }

        private void TSM_GestaoC_Click(object sender, EventArgs e)
        {
            FormReserva FormR = new FormReserva();
            FormR.Show();
        }

        private void TSM_GestaoP_Click(object sender, EventArgs e)
        {
            FormPrato FormP = new FormPrato();
            FormP.Show();
        }

        private void TSM_GestaoM_Click(object sender, EventArgs e)
        {
            FormMenu FormMen = new FormMenu();
            FormMen.Show();
        }

        private void TSM_GestaoF_Click(object sender, EventArgs e)
        {
            FormFatura FormF = new FormFatura();
            FormF.Show();
        }

        private void TSM_Registo_Click(object sender, EventArgs e)
        {
            FormFuncionario FormFun = new FormFuncionario();
            FormFun.Show();
        }
    }
}
