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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            using (var db = new CantinaContext())
            {
                dtgFuncionario.DataSource = db.Funcionarios.ToList();
            }
        }

        private void TSM_GestaoC_Click(object sender, EventArgs e)
        {
            FormCliente Formc = new FormCliente();
            Formc.Show();
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

        private void TSM_GestaoMulta_Click(object sender, EventArgs e)
        {
            FormMulta FormM = new FormMulta();
            FormM.Show();
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
            btnAdicionarF.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void ClearEditingControls()
        {
            txtNome.Text = "";
            txtNIF.Text = "";
            txtUsername.Text = "";
            btnAdicionarF.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void OrganizeDataGridViewColumns()
        {
            if (dtgFuncionario.Columns.Count > 0)
            {
                dtgFuncionario.Columns["Id"].DisplayIndex = 0;
                dtgFuncionario.Columns["Name"].DisplayIndex = 1;
                dtgFuncionario.Columns["Nif"].DisplayIndex = 2;
                dtgFuncionario.Columns["Username"].DisplayIndex = 3;
            }
        }

        private void btnAdicionarF_Click(object sender, EventArgs e)
        {
            string name = txtNome.Text;
            string SNif = txtNIF.Text;
            string username = txtUsername.Text;

            int nif = int.Parse(SNif);

            Funcionario funcionario = new Funcionario(name, nif, username);

            using (var db = new CantinaContext())
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                dtgFuncionario.DataSource = null;
                dtgFuncionario.DataSource = db.Funcionarios.ToList();
            }
            ClearEditingControls();
            OrganizeDataGridViewColumns();
        }

        private void BtnApagarF_Click(object sender, EventArgs e)
        {
            if (dtgFuncionario.SelectedRows.Count > 0)
            {
                Funcionario funcionarioToDelete = dtgFuncionario.SelectedRows[0].DataBoundItem as Funcionario;

                if (funcionarioToDelete != null)
                {
                    using (var db = new CantinaContext())
                    {
                        if (db.Entry(funcionarioToDelete).State == EntityState.Detached)
                        {
                            db.Funcionarios.Attach(funcionarioToDelete);
                        }
                        db.Funcionarios.Remove(funcionarioToDelete);
                        db.SaveChanges();
                        dtgFuncionario.DataSource = null;
                        dtgFuncionario.DataSource = db.Funcionarios.ToList();
                    }
                    OrganizeDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Não foi possível apagar o funcionário selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um funcionário para apagar.");
            }
        }

        private void btnEditarF_Click(object sender, EventArgs e)
        {
            if (dtgFuncionario.SelectedRows.Count > 0)
            {
                Funcionario funcionarioEditar = dtgFuncionario.SelectedRows[0].DataBoundItem as Funcionario;

                if (funcionarioEditar != null)
                {
                    txtNome.Text = funcionarioEditar.Name;
                    txtNIF.Text = funcionarioEditar.Nif.ToString();
                    txtUsername.Text = funcionarioEditar.Username;

                    EnableEditingControls();
                    OrganizeDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("Não foi possivel editar o funcionário selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um funcionário para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioEditar = dtgFuncionario.SelectedRows[0].DataBoundItem as Funcionario;

            if (funcionarioEditar != null)
            {
                funcionarioEditar.Name = txtNome.Text;
                string SNif = txtNIF.Text;
                int nif = int.Parse(SNif);
                funcionarioEditar.Nif = nif;
                funcionarioEditar.Username = txtUsername.Text;

                using (var db = new CantinaContext())
                {
                    if (db.Entry(funcionarioEditar).State == EntityState.Detached)
                    {
                        db.Funcionarios.Attach(funcionarioEditar);
                    }
                    db.Entry(funcionarioEditar).State = EntityState.Modified;
                    db.SaveChanges();
                    dtgFuncionario.DataSource = null;
                    dtgFuncionario.DataSource = db.Funcionarios.ToList();
                }
                ClearEditingControls();
                OrganizeDataGridViewColumns();
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            OrganizeDataGridViewColumns();
        }
    }
}
