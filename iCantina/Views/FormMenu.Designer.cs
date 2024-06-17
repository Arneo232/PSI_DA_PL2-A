namespace iCantina.Views
{
    partial class FormMenu
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.cbPrato = new System.Windows.Forms.ComboBox();
            this.BtnApagarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarM = new System.Windows.Forms.Button();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoF = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(63, 433);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(227, 30);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar Alterações";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(63, 225);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 41;
            // 
            // cbPrato
            // 
            this.cbPrato.FormattingEnabled = true;
            this.cbPrato.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.cbPrato.Location = new System.Drawing.Point(128, 86);
            this.cbPrato.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrato.Name = "cbPrato";
            this.cbPrato.Size = new System.Drawing.Size(206, 24);
            this.cbPrato.TabIndex = 40;
            // 
            // BtnApagarM
            // 
            this.BtnApagarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnApagarM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApagarM.FlatAppearance.BorderSize = 2;
            this.BtnApagarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarM.Location = new System.Drawing.Point(63, 508);
            this.BtnApagarM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagarM.Name = "BtnApagarM";
            this.BtnApagarM.Size = new System.Drawing.Size(228, 33);
            this.BtnApagarM.TabIndex = 39;
            this.BtnApagarM.Text = "Apagar";
            this.BtnApagarM.UseVisualStyleBackColor = false;
            // 
            // btnEditarM
            // 
            this.btnEditarM.BackColor = System.Drawing.Color.Gold;
            this.btnEditarM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarM.FlatAppearance.BorderSize = 2;
            this.btnEditarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarM.Location = new System.Drawing.Point(179, 467);
            this.btnEditarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(112, 37);
            this.btnEditarM.TabIndex = 38;
            this.btnEditarM.Text = "Editar";
            this.btnEditarM.UseVisualStyleBackColor = false;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.cbHorario.Location = new System.Drawing.Point(128, 125);
            this.cbHorario.Margin = new System.Windows.Forms.Padding(2);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(206, 24);
            this.cbHorario.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Selecionar Horário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Selecionar Prato:";
            // 
            // btnAdicionarM
            // 
            this.btnAdicionarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarM.FlatAppearance.BorderSize = 2;
            this.btnAdicionarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarM.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarM.Location = new System.Drawing.Point(63, 467);
            this.btnAdicionarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarM.Name = "btnAdicionarM";
            this.btnAdicionarM.Size = new System.Drawing.Size(112, 37);
            this.btnAdicionarM.TabIndex = 34;
            this.btnAdicionarM.Text = "Adicionar";
            this.btnAdicionarM.UseVisualStyleBackColor = false;
            // 
            // dtgMenu
            // 
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Location = new System.Drawing.Point(347, 86);
            this.dtgMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 24;
            this.dtgMenu.Size = new System.Drawing.Size(409, 455);
            this.dtgMenu.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestão do Menu";
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
            this.TSM.Location = new System.Drawing.Point(20, 36);
            this.TSM.Name = "TSM";
            this.TSM.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSM.Size = new System.Drawing.Size(833, 24);
            this.TSM.TabIndex = 61;
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
            this.TSM_GestaoM.Enabled = false;
            this.TSM_GestaoM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoM.Name = "TSM_GestaoM";
            this.TSM_GestaoM.Size = new System.Drawing.Size(108, 20);
            this.TSM_GestaoM.Text = " Gestão do Menu";
            // 
            // TSM_GestaoF
            // 
            this.TSM_GestaoF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_GestaoF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_GestaoF.Name = "TSM_GestaoF";
            this.TSM_GestaoF.Size = new System.Drawing.Size(115, 20);
            this.TSM_GestaoF.Text = "Gestão de Faturas";
            this.TSM_GestaoF.Click += new System.EventHandler(this.TSM_GestaoF_Click);
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(783, 554);
            this.Controls.Add(this.TSM);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mCalendar);
            this.Controls.Add(this.cbPrato);
            this.Controls.Add(this.BtnApagarM);
            this.Controls.Add(this.btnEditarM);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionarM);
            this.Controls.Add(this.dtgMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = " Gestão do Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.ComboBox cbPrato;
        private System.Windows.Forms.Button BtnApagarM;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionarM;
        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoC;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoP;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoF;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoMulta;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registo;
    }
}