namespace ProjetoDA.Views
{
    partial class Menu
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
            this.BtnApagarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarM = new System.Windows.Forms.Button();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrato = new System.Windows.Forms.ComboBox();
            this.mCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnApagarM
            // 
            this.BtnApagarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnApagarM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApagarM.FlatAppearance.BorderSize = 2;
            this.BtnApagarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarM.Location = new System.Drawing.Point(59, 508);
            this.BtnApagarM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagarM.Name = "BtnApagarM";
            this.BtnApagarM.Size = new System.Drawing.Size(228, 33);
            this.BtnApagarM.TabIndex = 17;
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
            this.btnEditarM.Location = new System.Drawing.Point(175, 467);
            this.btnEditarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(112, 37);
            this.btnEditarM.TabIndex = 16;
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
            this.cbHorario.Location = new System.Drawing.Point(124, 125);
            this.cbHorario.Margin = new System.Windows.Forms.Padding(2);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(206, 24);
            this.cbHorario.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selecionar Horário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecionar Prato:";
            // 
            // btnAdicionarM
            // 
            this.btnAdicionarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarM.FlatAppearance.BorderSize = 2;
            this.btnAdicionarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarM.Location = new System.Drawing.Point(59, 467);
            this.btnAdicionarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarM.Name = "btnAdicionarM";
            this.btnAdicionarM.Size = new System.Drawing.Size(112, 37);
            this.btnAdicionarM.TabIndex = 11;
            this.btnAdicionarM.Text = "Adicionar Menu";
            this.btnAdicionarM.UseVisualStyleBackColor = false;
            // 
            // dtgMenu
            // 
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Location = new System.Drawing.Point(343, 86);
            this.dtgMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 24;
            this.dtgMenu.Size = new System.Drawing.Size(409, 455);
            this.dtgMenu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestão do Menu";
            // 
            // cbPrato
            // 
            this.cbPrato.FormattingEnabled = true;
            this.cbPrato.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.cbPrato.Location = new System.Drawing.Point(124, 86);
            this.cbPrato.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrato.Name = "cbPrato";
            this.cbPrato.Size = new System.Drawing.Size(206, 24);
            this.cbPrato.TabIndex = 18;
            // 
            // mCalendar
            // 
            this.mCalendar.Location = new System.Drawing.Point(59, 225);
            this.mCalendar.Name = "mCalendar";
            this.mCalendar.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(59, 433);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(227, 30);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Alterações";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 554);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestão do Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApagarM;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarM;
        private System.Windows.Forms.ComboBox cbPrato;
        private System.Windows.Forms.MonthCalendar mCalendar;
        private System.Windows.Forms.Button btnGuardar;
    }
}