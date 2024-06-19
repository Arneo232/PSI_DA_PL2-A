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
    public partial class FormExtra : Form
    {
        public FormExtra()
        {
            InitializeComponent();

            using (var db = new CantinaContext())
            {
                dgvExtras.DataSource = db.Extras.ToList();
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
            txtDescricao.Text = "";
            txtPreco.Text = "";
            cbEstado.Checked = false;

            btnGuardar.Enabled = false;
            btnAdicionar.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            string sPreco = txtPreco.Text;
            bool ativo = cbEstado.Checked;

            float preco = float.Parse(sPreco);

            Extra extra = new Extra(descricao, preco, ativo);

            using (var db = new CantinaContext())
            {
                db.Extras.Add(extra);
                db.SaveChanges();
                dgvExtras.DataSource = null;
                dgvExtras.DataSource = db.Extras.ToList();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvExtras.SelectedRows.Count > 0)
            {
                Extra ExtraApagar = dgvExtras.SelectedRows[0].DataBoundItem as Extra;

                if (ExtraApagar != null)
                {
                    using (var db = new CantinaContext())
                    {
                        if (db.Entry(ExtraApagar).State == EntityState.Detached)
                        {
                            db.Extras.Attach(ExtraApagar);
                        }
                        db.Extras.Remove(ExtraApagar);
                        db.SaveChanges();
                        dgvExtras.DataSource = null;
                        dgvExtras.DataSource = db.Extras.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel apagar o extra selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um extra para apagar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvExtras.SelectedRows.Count > 0)
            {
                Extra extraEditar = dgvExtras.SelectedRows[0].DataBoundItem as Extra;

                if (extraEditar != null)
                {
                    txtDescricao.Text = extraEditar.Descricao;
                    txtPreco.Text = extraEditar.Preco.ToString();
                    cbEstado.Checked = extraEditar.Ativo;

                    EnableEditingControls();
                }
                else
                {
                    MessageBox.Show("Não foi possível editar o extra selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um extra para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Extra extraEditar = dgvExtras.SelectedRows[0].DataBoundItem as Extra;

            if (extraEditar != null)
            {
                extraEditar.Descricao = txtDescricao.Text;
                string sPreco = txtPreco.Text;
                float preco = float.Parse(sPreco);
                extraEditar.Preco = preco;
                extraEditar.Ativo = cbEstado.Checked;

                using (var db = new CantinaContext())
                {
                    if (db.Entry(extraEditar).State == EntityState.Detached)
                    {
                        db.Extras.Attach(extraEditar);
                    }
                    db.Entry(extraEditar).State = EntityState.Modified;
                    db.SaveChanges();
                    dgvExtras.DataSource = null;
                    dgvExtras.DataSource = db.Extras.ToList();
                }
                ClearEditingControls();
            }
        }
    }
}
