﻿namespace iCantina.Views
{
    partial class FormExtra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDosExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvExtras = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TSM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::iCantina.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(19, 322);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 242);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(130, 282);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(142, 32);
            this.btnApagar.TabIndex = 84;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Yellow;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(209, 248);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 32);
            this.btnEditar.TabIndex = 83;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Cyan;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(130, 248);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 32);
            this.btnGuardar.TabIndex = 82;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(130, 213);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 32);
            this.btnAdicionar.TabIndex = 81;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Ativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Preço:";
            // 
            // TSM
            // 
            this.TSM.Dock = System.Windows.Forms.DockStyle.None;
            this.TSM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_GestaoC,
            this.TSM_GestaoP,
            this.gestãoDosExtrasToolStripMenuItem,
            this.TSM_GestaoM,
            this.TSM_GestaoMulta,
            this.TSM_Registo,
            this.gestãoDeReservasToolStripMenuItem});
            this.TSM.Location = new System.Drawing.Point(38, 44);
            this.TSM.Name = "TSM";
            this.TSM.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.TSM.Size = new System.Drawing.Size(837, 24);
            this.TSM.TabIndex = 76;
            this.TSM.Text = "TSM Tabs";
            // 
            // TSM_GestaoC
            // 
            this.TSM_GestaoC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoC.Name = "TSM_GestaoC";
            this.TSM_GestaoC.Size = new System.Drawing.Size(113, 20);
            this.TSM_GestaoC.Text = "Gestâo do Cliente";
            this.TSM_GestaoC.Click += new System.EventHandler(this.TSM_GestaoC_Click);
            // 
            // TSM_GestaoP
            // 
            this.TSM_GestaoP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoP.Name = "TSM_GestaoP";
            this.TSM_GestaoP.Size = new System.Drawing.Size(116, 20);
            this.TSM_GestaoP.Text = "Gestão dos Pratos";
            this.TSM_GestaoP.Click += new System.EventHandler(this.TSM_GestaoP_Click);
            // 
            // gestãoDosExtrasToolStripMenuItem
            // 
            this.gestãoDosExtrasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gestãoDosExtrasToolStripMenuItem.Enabled = false;
            this.gestãoDosExtrasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.gestãoDosExtrasToolStripMenuItem.Name = "gestãoDosExtrasToolStripMenuItem";
            this.gestãoDosExtrasToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestãoDosExtrasToolStripMenuItem.Text = "Gestão dos Extras";
            // 
            // TSM_GestaoM
            // 
            this.TSM_GestaoM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoM.Name = "TSM_GestaoM";
            this.TSM_GestaoM.Size = new System.Drawing.Size(108, 20);
            this.TSM_GestaoM.Text = " Gestão do Menu";
            this.TSM_GestaoM.Click += new System.EventHandler(this.TSM_GestaoM_Click);
            // 
            // TSM_GestaoMulta
            // 
            this.TSM_GestaoMulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoMulta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoMulta.Name = "TSM_GestaoMulta";
            this.TSM_GestaoMulta.Size = new System.Drawing.Size(110, 20);
            this.TSM_GestaoMulta.Text = "Gestão de Multas";
            this.TSM_GestaoMulta.Click += new System.EventHandler(this.TSM_GestaoMulta_Click);
            // 
            // TSM_Registo
            // 
            this.TSM_Registo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_Registo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_Registo.Name = "TSM_Registo";
            this.TSM_Registo.Size = new System.Drawing.Size(143, 20);
            this.TSM_Registo.Text = "Registo de Funcionário";
            this.TSM_Registo.Click += new System.EventHandler(this.TSM_Registo_Click);
            // 
            // gestãoDeReservasToolStripMenuItem
            // 
            this.gestãoDeReservasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gestãoDeReservasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.gestãoDeReservasToolStripMenuItem.Name = "gestãoDeReservasToolStripMenuItem";
            this.gestãoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestãoDeReservasToolStripMenuItem.Text = "Gestão de Reservas";
            this.gestãoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeReservasToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 32);
            this.label5.TabIndex = 75;
            this.label5.Text = "Gestão dos Extras";
            // 
            // dgvExtras
            // 
            this.dgvExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtras.Location = new System.Drawing.Point(322, 98);
            this.dgvExtras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExtras.Name = "dgvExtras";
            this.dgvExtras.Size = new System.Drawing.Size(631, 466);
            this.dgvExtras.TabIndex = 74;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(130, 98);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(142, 22);
            this.txtDescricao.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Descrição:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(129, 140);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(142, 22);
            this.txtPreco.TabIndex = 86;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(129, 186);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 87;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // FormExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 580);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TSM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvExtras);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExtra";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Gestão dos Extras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoC;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoP;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoMulta;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvExtras;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ToolStripMenuItem gestãoDosExtrasToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeReservasToolStripMenuItem;
    }
}