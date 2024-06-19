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
using System.Xml.Linq;
using static iCantina.Modelo.Prato;
using static iCantina.Views.FormPrato;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace iCantina.Views
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            InitializeDataGridView();
            using (var db = new CantinaContext())
            {
                dgvClientes.DataSource = db.Clientes.ToList();
            }
        }

        private void TSM_GestaoReserva_Click(object sender, EventArgs e)
        {
            FormReserva FormR = new FormReserva();
            FormR.Show();
            this.Close();
        }

        private void TSM_Registo_Click(object sender, EventArgs e)
        {
            FormFuncionario FormFun = new FormFuncionario();
            FormFun.Show();
            this.Close();
        }

        private void TSM_GestaoMulta_Click(object sender, EventArgs e)
        {
            FormMulta FormM = new FormMulta();
            FormM.Show();
            this.Close();
        }

        private void TSM_GestaoM_Click(object sender, EventArgs e)
        {
            FormMenu FormMen = new FormMenu();
            FormMen.Show();
            this.Close();
        }

        private void TSM_Extras_Click(object sender, EventArgs e)
        {
            FormExtra FormEx = new FormExtra();
            FormEx.Show();
            this.Close();
        }

        private void TSM_GestaoP_Click(object sender, EventArgs e)
        {
            FormPrato FormP = new FormPrato();
            FormP.Show();
            this.Close();
        }

        private void EnableEditingControls()
        {
            btnAddProf.Enabled = false;
            btnAddAluno.Enabled = false;

            btnGuardar.Enabled = true;
        }

        private void ClearEditingControls()
        {
            txtNome.Text = "";
            txtNif.Text = "";
            txtSaldo.Text = "";
            txtEmail.Text = "";
            txtNumEstudante.Text = "";
            btnAddProf.Enabled = true;
            btnAddAluno.Enabled = true;

            btnGuardar.Enabled = false;
        }

        private void InitializeDataGridView()
        {
            // Isto configura manualmente as colunas
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", DataPropertyName = "Id" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", DataPropertyName = "Nome" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nif", HeaderText = "Nif", DataPropertyName = "Nif" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Saldo", HeaderText = "Saldo", DataPropertyName = "Saldo" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", HeaderText = "Email", DataPropertyName = "Email" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "NumEstudante", HeaderText = "NumEstudante", DataPropertyName = "NumEstudante" });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tipo", HeaderText = "Tipo", DataPropertyName = "Tipo" });
        }
        private void OrganizeDataGridViewColumns()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Nif");
            dt.Columns.Add("Saldo");
            dt.Columns.Add("Email");
            dt.Columns.Add("NumEstudante");
            dt.Columns.Add("Tipo");

            using (var db = new CantinaContext())
            {
                var estudantes = db.Estudantes.ToList();
                foreach (var e in estudantes)
                {
                    dt.Rows.Add(e.Id, e.Name, e.Nif, e.Saldo, DBNull.Value, e.NumEstudante, "Estudante");
                }

                var professores = db.Professores.ToList();
                foreach (var p in professores)
                {
                    dt.Rows.Add(p.Id, p.Name, p.Nif, p.Saldo, p.Email, DBNull.Value, "Professor");
                }
            }

            dgvClientes.DataSource = dt;
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sNif = txtNif.Text;
            string email = txtEmail.Text;
            string sSaldo = txtSaldo.Text;

            if (!int.TryParse(sNif, out int nif))
            {
                MessageBox.Show("NIF inválido. Por favor, insira um número válido.");
                return;
            }

            if (!float.TryParse(sSaldo, out float saldo))
            {
                MessageBox.Show("Saldo inválido. Por favor, insira um número válido.");
                return;
            }

            Professor professor = new Professor(nome, nif, saldo, email);

            try
            {
                using (var db = new CantinaContext())
                {
                    db.Professores.Add(professor);
                    db.SaveChanges();
                }

                ClearEditingControls();
                OrganizeDataGridViewColumns(); // Garantir que a ordem das colunas seja respeitada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar o professor: " + ex.Message);
            }
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            string sNumEstudante = txtNumEstudante.Text;
            string nome = txtNome.Text;
            string sNif = txtNif.Text;
            string sSaldo = txtSaldo.Text;

            if (!int.TryParse(sNif, out int nif))
            {
                MessageBox.Show("NIF inválido. Por favor, insira um número válido.");
                return;
            }

            if (!int.TryParse(sNumEstudante, out int numEstudante))
            {
                MessageBox.Show("Número de estudante inválido. Por favor, insira um número válido.");
                return;
            }

            if (!float.TryParse(sSaldo, out float saldo))
            {
                MessageBox.Show("Saldo inválido. Por favor, insira um número válido.");
                return;
            }

            Estudante aluno = new Estudante(nome, nif, saldo, numEstudante);

            try
            {
                using (var db = new CantinaContext())
                {
                    db.Estudantes.Add(aluno);
                    db.SaveChanges();
                }

                ClearEditingControls();
                OrganizeDataGridViewColumns(); // Garantir que a ordem das colunas seja respeitada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar o estudante: " + ex.Message);
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            OrganizeDataGridViewColumns();
        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                string email = selectedRow.Cells["Email"].Value.ToString();
                string tipo = selectedRow.Cells["Tipo"].Value.ToString();

                using (var db = new CantinaContext())
                {
                    if (tipo == "Estudante")
                    {
                        if (int.TryParse(selectedRow.Cells["NumEstudante"].Value.ToString(), out int numEstudante))
                        {
                            var estudanteToDelete = db.Estudantes.SingleOrDefault(estudante => estudante.NumEstudante == numEstudante);
                            if (estudanteToDelete != null)
                            {
                                db.Estudantes.Remove(estudanteToDelete);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Número de Estudante inválido.");
                            return;
                        }
                    }
                    else if (tipo == "Professor")
                    {
                        var professorToDelete = db.Professores.SingleOrDefault(professor => professor.Email == email);
                        if (professorToDelete != null)
                        {
                            db.Professores.Remove(professorToDelete);
                        }
                    }

                    db.SaveChanges();
                    OrganizeDataGridViewColumns();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para apagar.");
            }
        }

        private string tipoClienteSelecionado; // Variavel para guardar o tipo do clente selecionado

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                string tipo = selectedRow.Cells["Tipo"].Value.ToString();

                if (tipo == "Estudante")
                {
                    if (int.TryParse(selectedRow.Cells["NumEstudante"].Value.ToString(), out int numEstudante))
                    {
                        using (var db = new CantinaContext())
                        {
                            var estudanteFromDB = db.Estudantes.FirstOrDefault(est => est.NumEstudante == numEstudante);
                            if (estudanteFromDB != null)
                            {
                                txtNome.Text = estudanteFromDB.Name;
                                txtNumEstudante.Text = estudanteFromDB.NumEstudante.ToString();
                                txtNif.Text = estudanteFromDB.Nif.ToString();
                                txtSaldo.Text = estudanteFromDB.Saldo.ToString();
                            }
                        }
                    }
                }
                else if (tipo == "Professor")
                {
                    string email = selectedRow.Cells["Email"].Value.ToString();
                    using (var db = new CantinaContext())
                    {
                        var professorFromDB = db.Professores.FirstOrDefault(prof => prof.Email == email);
                        if (professorFromDB != null)
                        {
                            txtNome.Text = professorFromDB.Name;
                            txtEmail.Text = professorFromDB.Email;
                            txtNumEstudante.Text = string.Empty;
                            txtNif.Text = professorFromDB.Nif.ToString();
                            txtSaldo.Text = professorFromDB.Saldo.ToString();
                        }
                    }
                }

                tipoClienteSelecionado = tipo;
                EnableEditingControls();
                OrganizeDataGridViewColumns();
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente para editar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tipoClienteSelecionado))
            {
                using (var db = new CantinaContext())
                {
                    if (tipoClienteSelecionado == "Estudante")
                    {
                        if (int.TryParse(txtNumEstudante.Text, out int numEstudante))
                        {
                            var estudanteFromDB = db.Estudantes.FirstOrDefault(est => est.NumEstudante == numEstudante);
                            if (estudanteFromDB != null)
                            {
                                estudanteFromDB.Name = txtNome.Text;
                                estudanteFromDB.Nif = int.Parse(txtNif.Text);
                                estudanteFromDB.Saldo = float.Parse(txtSaldo.Text);
                            }
                            else
                            {
                                var novoEstudante = new Estudante
                                {
                                    Name = txtNome.Text,
                                    NumEstudante = numEstudante,
                                    Nif = int.Parse(txtNif.Text),
                                    Saldo = float.Parse(txtSaldo.Text)
                                };
                                db.Estudantes.Add(novoEstudante);
                            }
                        }
                    }
                    else if (tipoClienteSelecionado == "Professor")
                    {
                        var professorFromDB = db.Professores.FirstOrDefault(prof => prof.Email == txtEmail.Text);
                        if (professorFromDB != null)
                        {
                            professorFromDB.Name = txtNome.Text;
                            professorFromDB.Nif = int.Parse(txtNif.Text);
                            professorFromDB.Saldo = float.Parse(txtSaldo.Text);
                        }
                        else
                        {
                            var novoProfessor = new Professor
                            {
                                Name = txtNome.Text,
                                Email = txtEmail.Text,
                                Nif = int.Parse(txtNif.Text),
                                Saldo = float.Parse(txtSaldo.Text)
                            };
                            db.Professores.Add(novoProfessor);
                        }
                    }

                    db.SaveChanges();
                }

                ClearEditingControls();
                OrganizeDataGridViewColumns();
                tipoClienteSelecionado = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, preencha os dados e selecione um tipo de cliente para salvar.");
            }
        }
    }
}
