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

namespace iCantina.Views
{
    public partial class FormMenu : Form
    {
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

        private void LoadComboBoxes()
        {
            using (var db = new CantinaContext())
            {
                var pratos = db.Pratos.ToList();
                var extras = db.Extras.ToList();

                // Associar a informação ás comboboxes
                cbPrato.DataSource = pratos;
                cbPrato.DisplayMember = "Descricao";
                cbPrato.ValueMember = "Id";

                cbExtra.DataSource = extras;
                cbExtra.DisplayMember = "Descricao";
                cbExtra.ValueMember = "Id";
            }
        }

        public FormMenu()
        {
            InitializeComponent();
            LoadComboBoxes();
            using (var db = new CantinaContext())
            {
                dtgMenu.DataSource = db.Menus.ToList();
            }
        }

        private void EnableEditingControls()
        {
            btnAdicionarM.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void ClearEditingControls()
        {
            txtQntDesp.Text = "";
            txtPrecoEst.Text = "";
            txtPrecoProf.Text = "";
            btnAdicionarM.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnAdicionarM_Click(object sender, EventArgs e)
        {
            string sQntDesp = txtQntDesp.Text;
            string sPrecoEst = txtPrecoEst.Text;
            string sPrecoProf = txtPrecoProf.Text;

            int qntDesp = int.Parse(sQntDesp);
            float precoEst = float.Parse(sPrecoEst);
            float precoProf = float.Parse(sPrecoProf);
            DateTime dataHora = mCalendar.SelectionStart;

            Modelo.Menu menu = new Modelo.Menu(dataHora, qntDesp, precoEst, precoProf);

            using (var db = new CantinaContext())
            {
                db.Menus.Add(menu);
                db.SaveChanges();
                dtgMenu.DataSource = db.Menus.ToList();
                ClearEditingControls();
            }
        }

        private void BtnApagarM_Click(object sender, EventArgs e)
        {
            if (dtgMenu.SelectedRows.Count > 0)
            {
                Modelo.Menu menuToDelete = dtgMenu.SelectedRows[0].DataBoundItem as Modelo.Menu;

                if (menuToDelete != null)
                {
                    using (var db = new CantinaContext())
                    {
                        if (db.Entry(menuToDelete).State == EntityState.Detached)
                        {
                            db.Menus.Attach(menuToDelete);
                        }
                        db.Menus.Remove(menuToDelete);
                        db.SaveChanges();
                        dtgMenu.DataSource = null;
                        dtgMenu.DataSource = db.Menus.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar o menu selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um menu para apagar.");
            }
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {
            if (dtgMenu.SelectedRows.Count > 0)
            {
                Modelo.Menu menuEditar = dtgMenu.SelectedRows[0].DataBoundItem as Modelo.Menu;

                if (menuEditar != null)
                { 
                    txtQntDesp.Text = menuEditar.QntDisp.ToString();
                    txtPrecoEst.Text = menuEditar.PrecoEst.ToString();
                    txtPrecoProf.Text = menuEditar.PrecoProf.ToString();
                    mCalendar.SelectionStart = menuEditar.DataHora;
                    EnableEditingControls();
                }
                else
                {
                    MessageBox.Show("Não foi possivel editar o menu selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um menu para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo.Menu menuEditar = dtgMenu.SelectedRows[0].DataBoundItem as Modelo.Menu;

            if (menuEditar != null)
            {
                string sQntDesp = txtQntDesp.Text;
                int qntDesp = int.Parse(sQntDesp);
                menuEditar.QntDisp = qntDesp;

                string sPrecoEst = txtPrecoEst.Text;
                float precoEst = float.Parse(sPrecoEst);
                menuEditar.PrecoEst = precoEst;

                string sPrecoProf = txtPrecoProf.Text;
                float precoProf = float.Parse(sPrecoProf);
                menuEditar.PrecoProf = precoProf;

                menuEditar.DataHora = mCalendar.SelectionStart;

                using (var db = new CantinaContext())
                {
                    if (db.Entry(menuEditar).State == EntityState.Detached)
                    {
                        db.Menus.Attach(menuEditar);
                    }
                    db.Entry(menuEditar).State = EntityState.Modified;
                    db.SaveChanges();
                    dtgMenu.DataSource = null;
                    dtgMenu.DataSource = db.Menus.ToList();
                }
                ClearEditingControls();
            }
        }
    }
}
