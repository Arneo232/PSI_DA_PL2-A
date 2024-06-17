namespace iCantina.Views
{
    partial class FormFatura
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgFaturas = new System.Windows.Forms.DataGridView();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtNFatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCFatura = new System.Windows.Forms.DataGridView();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoF = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCFatura)).BeginInit();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label6.Location = new System.Drawing.Point(14, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Faturas:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.No;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPesquisar.Location = new System.Drawing.Point(588, 195);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 57;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(396, 195);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(187, 22);
            this.txtPesquisa.TabIndex = 56;
            this.txtPesquisa.Text = "Pesquisa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 31);
            this.label5.TabIndex = 55;
            this.label5.Text = "Gestão de Faturas";
            // 
            // dtgFaturas
            // 
            this.dtgFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFaturas.Location = new System.Drawing.Point(12, 305);
            this.dtgFaturas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFaturas.Name = "dtgFaturas";
            this.dtgFaturas.RowHeadersWidth = 51;
            this.dtgFaturas.RowTemplate.Height = 24;
            this.dtgFaturas.Size = new System.Drawing.Size(350, 227);
            this.dtgFaturas.TabIndex = 54;
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(694, 68);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 53;
            // 
            // txtNFatura
            // 
            this.txtNFatura.Location = new System.Drawing.Point(12, 134);
            this.txtNFatura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNFatura.Name = "txtNFatura";
            this.txtNFatura.Size = new System.Drawing.Size(231, 22);
            this.txtNFatura.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Numero da Fatura:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(12, 562);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(231, 22);
            this.txtValorTotal.TabIndex = 50;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 240);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(231, 22);
            this.txtCliente.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cliente:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 186);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(231, 22);
            this.txtData.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 544);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Valor Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data:";
            // 
            // dtgCFatura
            // 
            this.dtgCFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCFatura.Location = new System.Drawing.Point(396, 234);
            this.dtgCFatura.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCFatura.Name = "dtgCFatura";
            this.dtgCFatura.RowHeadersWidth = 51;
            this.dtgCFatura.RowTemplate.Height = 24;
            this.dtgCFatura.Size = new System.Drawing.Size(525, 350);
            this.dtgCFatura.TabIndex = 44;
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
            this.TSM.Location = new System.Drawing.Point(69, 40);
            this.TSM.Name = "TSM";
            this.TSM.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSM.Size = new System.Drawing.Size(833, 24);
            this.TSM.TabIndex = 59;
            this.TSM.Text = "TSM Tabs";
            // 
            // TSM_GestaoC
            // 
            this.TSM_GestaoC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
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
            // TSM_GestaoM
            // 
            this.TSM_GestaoM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoM.Name = "TSM_GestaoM";
            this.TSM_GestaoM.Size = new System.Drawing.Size(108, 20);
            this.TSM_GestaoM.Text = " Gestão do Menu";
            this.TSM_GestaoM.Click += new System.EventHandler(this.TSM_GestaoM_Click);
            // 
            // TSM_GestaoF
            // 
            this.TSM_GestaoF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoF.Enabled = false;
            this.TSM_GestaoF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoF.Name = "TSM_GestaoF";
            this.TSM_GestaoF.Size = new System.Drawing.Size(115, 20);
            this.TSM_GestaoF.Text = "Gestão de Faturas";
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
            // FormFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 596);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFatura";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestão de Faturas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCFatura)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgFaturas;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.TextBox txtNFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgCFatura;
        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoC;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoP;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoF;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoMulta;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registo;
    }
}