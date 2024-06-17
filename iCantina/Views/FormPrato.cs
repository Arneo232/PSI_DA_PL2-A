using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCantina.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iCantina.Views
{
    public partial class FormPrato : Form
    {
        internal class ComboBoxTipoPratoItem 
        {
            public string Text { get; set; }
            public Prato.TipoPrato Tipo { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        public FormPrato()
        {
            InitializeComponent();
            InitializeComboBox();

            using (var db = new CantinaContext())
            {
                dgvPratos.DataSource = db.Pratos.ToList();
            }
        }

        private void InitializeComboBox()
        {
            cbTipoPrato.Items.Add(new ComboBoxTipoPratoItem()
            {
                Tipo = Prato.TipoPrato.Carne,
                Text = "Carne"
            });

            cbTipoPrato.Items.Add(new ComboBoxTipoPratoItem()
            {
                Tipo = Prato.TipoPrato.Peixe,
                Text = "Peixe"
            });

            cbTipoPrato.Items.Add(new ComboBoxTipoPratoItem()
            {
                Tipo = Prato.TipoPrato.Vegetariano,
                Text = "Vegetariano"
            });
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            var sTipo = cbTipoPrato.SelectedItem;

            if (!(sTipo is ComboBoxTipoPratoItem tipo))
            {
                return;
            }

            bool ativo = cbEstado.Checked;

            Prato prato = new Prato(descricao, tipo.Tipo, ativo);

            using (var db = new CantinaContext())
            {
                db.Pratos.Add(prato);
                db.SaveChanges();
                dgvPratos.DataSource = null;
                dgvPratos.DataSource = db.Pratos.ToList();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvPratos.SelectedRows.Count > 0)
            {
                Prato pratoToDelete = dgvPratos.SelectedRows[0].DataBoundItem as Prato;

                if (pratoToDelete != null)
                {
                    using (var db = new CantinaContext())
                    {
                        if (db.Entry(pratoToDelete).State == EntityState.Detached)
                        {
                            db.Pratos.Attach(pratoToDelete);
                        }
                        db.Pratos.Remove(pratoToDelete);
                        db.SaveChanges();
                        dgvPratos.DataSource = null;
                        dgvPratos.DataSource = db.Pratos.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivel apagar o prato selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um prato para apagar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPratos.SelectedRows.Count > 0)
            {
                Prato pratoEditar = dgvPratos.SelectedRows[0].DataBoundItem as Prato;

                if (pratoEditar != null)
                {
                    txtDescricao.Text = pratoEditar.Descricao;
                    cbTipoPrato.SelectedIndex = (int)pratoEditar.Tipo;
                    cbEstado.Checked = pratoEditar.Ativo;

                    EnableEditingControls();
                }
                else
                {
                    MessageBox.Show("Não foi possivel editar o prato selecionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um prato para editar.");
            }
        }

        private void EnableEditingControls()
        {
            txtDescricao.Enabled = true;
 
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prato pratoEditar = dgvPratos.SelectedRows[0].DataBoundItem as Prato;

            if (pratoEditar != null)
            {
                pratoEditar.Descricao = txtDescricao.Text;
                var sTipo = cbTipoPrato.SelectedItem;

                if (!(sTipo is ComboBoxTipoPratoItem tipo))
                {
                    return;
                }

                pratoEditar.Ativo = cbEstado.Checked;

                using (var db = new CantinaContext())
                {
                    if (db.Entry(pratoEditar).State == EntityState.Detached)
                    {
                        db.Pratos.Attach(pratoEditar);
                    }
                    db.Entry(pratoEditar).State = EntityState.Modified;
                    db.SaveChanges();
                    dgvPratos.DataSource = null;
                    dgvPratos.DataSource = db.Pratos.ToList();
                }
                ClearEditingControls();
            }
        }

        private void ClearEditingControls()
        {
            txtDescricao.Text = "";
            cbTipoPrato.Text = null;
            cbEstado.Checked = false;
 
            btnGuardar.Enabled = false;
        }
    }
}
