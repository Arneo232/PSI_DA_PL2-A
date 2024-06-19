using iCantina.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iCantina.Modelo.Prato;
using static iCantina.Views.FormPrato;

namespace iCantina.Views
{
    public partial class FormMulta : Form
    {
        public FormMulta()
        {
            InitializeComponent();
            using (var db = new CantinaContext())
            {
                dtgMultas.DataSource = db.Multas.ToList();
            }
        }

        private void TSM_GestaoC_Click(object sender, EventArgs e)
        {
            FormCliente FormC = new FormCliente();
            FormC.Show();
            this.Close();
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

        private void TSM_Registo_Click(object sender, EventArgs e)
        {
            FormFuncionario FormFun = new FormFuncionario();
            FormFun.Show();
            this.Close();
        }

        private void gestãoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserva FormR = new FormReserva();
            FormR.Show();
            this.Close();
        }

        private void EnableEditingControls()
        {
            btnAdicionar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void ClearEditingControls()
        {
            txtValor.Text = "";
            txtHoras.Text = "";
            btnAdicionar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sValor = txtValor.Text;
            float valor = float.Parse(sValor);

            string sNumHoras = txtHoras.Text;
            float numHoras = float.Parse(sNumHoras);

            Multa multa = new Multa(valor, numHoras);

            using (var db = new CantinaContext())
            {
                db.Multas.Add(multa);
                db.SaveChanges();
                dtgMultas.DataSource = null;
                dtgMultas.DataSource = db.Multas.ToList();
            }
            ClearEditingControls();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dtgMultas.SelectedRows.Count > 0)
            {
                Multa multaToDelete = dtgMultas.SelectedRows[0].DataBoundItem as Multa;

                if (dtgMultas != null)
                {
                    using (var db = new CantinaContext())
                    {
                        if (db.Entry(multaToDelete).State == EntityState.Detached)
                        {
                            db.Multas.Attach(multaToDelete);
                        }
                        db.Multas.Remove(multaToDelete);
                        db.SaveChanges();
                        dtgMultas.DataSource = null;
                        dtgMultas.DataSource = db.Multas.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel apagar a multa selecionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione uma multa para apagar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtgMultas.SelectedRows.Count > 0)
            {
                Multa multaEditar = dtgMultas.SelectedRows[0].DataBoundItem as Multa;

                if (multaEditar != null)
                {
                    txtValor.Text = multaEditar.Valor.ToString();
                    txtHoras.Text = multaEditar.NumHoras.ToString();

                    EnableEditingControls();
                }
                else
                {
                    MessageBox.Show("Não foi possivel editar a multa selecionada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione uma multa para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Multa multaEditar = dtgMultas.SelectedRows[0].DataBoundItem as Multa;

            if (multaEditar != null)
            {
                string sValor = txtValor.Text;
                float valor = float.Parse(sValor);
                multaEditar.Valor = valor;

                string sNumHoras = txtHoras.Text;
                float numHoras = float.Parse(sNumHoras);
                multaEditar.NumHoras = numHoras;

                using (var db = new CantinaContext())
                {
                    if (db.Entry(multaEditar).State == EntityState.Detached)
                    {
                        db.Multas.Attach(multaEditar);
                    }
                    db.Entry(multaEditar).State = EntityState.Modified;
                    db.SaveChanges();
                    dtgMultas.DataSource = null;
                    dtgMultas.DataSource = db.Multas.ToList();
                }
                ClearEditingControls();
            }
        }
    }
}
