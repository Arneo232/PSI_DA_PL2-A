namespace ProjetoDA.Views
{
    partial class Fatura
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
            this.dtgCFatura = new System.Windows.Forms.DataGridView();
            this.txtNFatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.dtgFaturas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoF = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).BeginInit();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCFatura
            // 
            this.dtgCFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCFatura.Location = new System.Drawing.Point(396, 244);
            this.dtgCFatura.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCFatura.Name = "dtgCFatura";
            this.dtgCFatura.RowHeadersWidth = 51;
            this.dtgCFatura.RowTemplate.Height = 24;
            this.dtgCFatura.Size = new System.Drawing.Size(525, 350);
            this.dtgCFatura.TabIndex = 11;
            // 
            // txtNFatura
            // 
            this.txtNFatura.Location = new System.Drawing.Point(12, 144);
            this.txtNFatura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNFatura.Name = "txtNFatura";
            this.txtNFatura.Size = new System.Drawing.Size(231, 22);
            this.txtNFatura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Numero da Fatura:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(12, 572);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(231, 22);
            this.txtValorTotal.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 250);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(231, 22);
            this.txtCliente.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cliente:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 196);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(231, 22);
            this.txtData.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 554);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data:";
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(694, 78);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 22;
            // 
            // dtgFaturas
            // 
            this.dtgFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFaturas.Location = new System.Drawing.Point(12, 315);
            this.dtgFaturas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFaturas.Name = "dtgFaturas";
            this.dtgFaturas.RowHeadersWidth = 51;
            this.dtgFaturas.RowTemplate.Height = 24;
            this.dtgFaturas.Size = new System.Drawing.Size(350, 227);
            this.dtgFaturas.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gestão de Faturas";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(396, 205);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(187, 22);
            this.txtPesquisa.TabIndex = 25;
            this.txtPesquisa.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPesquisar.Location = new System.Drawing.Point(588, 205);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label6.Location = new System.Drawing.Point(14, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Faturas:";
            // 
            // TSM
            // 
            this.TSM.Dock = System.Windows.Forms.DockStyle.None;
            this.TSM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_GestaoC,
            this.TSM_GestaoP,
            this.TSM_GestaoM,
            this.TSM_GestaoF,
            this.TSM_GestaoMulta,
            this.TSM_Registo});
            this.TSM.Location = new System.Drawing.Point(116, 45);
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(673, 24);
            this.TSM.TabIndex = 43;
            this.TSM.Text = "TSM Tabs";
            // 
            // TSM_GestaoC
            // 
            this.TSM_GestaoC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoC.Name = "TSM_GestaoC";
            this.TSM_GestaoC.Size = new System.Drawing.Size(102, 20);
            this.TSM_GestaoC.Text = "Gestâo do Cliente";
            // 
            // TSM_GestaoP
            // 
            this.TSM_GestaoP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoP.Name = "TSM_GestaoP";
            this.TSM_GestaoP.Size = new System.Drawing.Size(105, 20);
            this.TSM_GestaoP.Text = "Gestão dos Pratos";
            // 
            // TSM_GestaoM
            // 
            this.TSM_GestaoM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoM.Name = "TSM_GestaoM";
            this.TSM_GestaoM.Size = new System.Drawing.Size(100, 20);
            this.TSM_GestaoM.Text = " Gestão do Menu";
            // 
            // TSM_GestaoF
            // 
            this.TSM_GestaoF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoF.Name = "TSM_GestaoF";
            this.TSM_GestaoF.Size = new System.Drawing.Size(106, 20);
            this.TSM_GestaoF.Text = "Gestão de Faturas";
            // 
            // TSM_GestaoMulta
            // 
            this.TSM_GestaoMulta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_GestaoMulta.Name = "TSM_GestaoMulta";
            this.TSM_GestaoMulta.Size = new System.Drawing.Size(100, 20);
            this.TSM_GestaoMulta.Text = "Gestão de Multas";
            // 
            // TSM_Registo
            // 
            this.TSM_Registo.Name = "TSM_Registo";
            this.TSM_Registo.Size = new System.Drawing.Size(152, 20);
            this.TSM_Registo.Text = "Registo de Funcionário";
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.TSM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgFaturas);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.txtNFatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgCFatura);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fatura";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestão de Faturas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCFatura;
        private System.Windows.Forms.TextBox txtNFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.DataGridView dtgFaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoC;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoP;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoF;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoMulta;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registo;
    }
}