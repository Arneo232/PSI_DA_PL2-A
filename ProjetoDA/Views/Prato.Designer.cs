namespace ProjetoDA.Views
{
    partial class Prato
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgPrato = new System.Windows.Forms.DataGridView();
            this.btnAdicionarP = new System.Windows.Forms.Button();
            this.txtPrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoPrato = new System.Windows.Forms.ComboBox();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.BtnApagarP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão dos Pratos";
            // 
            // dtgPrato
            // 
            this.dtgPrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrato.Location = new System.Drawing.Point(240, 68);
            this.dtgPrato.Margin = new System.Windows.Forms.Padding(2);
            this.dtgPrato.Name = "dtgPrato";
            this.dtgPrato.RowHeadersWidth = 51;
            this.dtgPrato.RowTemplate.Height = 24;
            this.dtgPrato.Size = new System.Drawing.Size(450, 370);
            this.dtgPrato.TabIndex = 1;
            // 
            // btnAdicionarP
            // 
            this.btnAdicionarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarP.FlatAppearance.BorderSize = 2;
            this.btnAdicionarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarP.Location = new System.Drawing.Point(96, 142);
            this.btnAdicionarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarP.Name = "btnAdicionarP";
            this.btnAdicionarP.Size = new System.Drawing.Size(70, 30);
            this.btnAdicionarP.TabIndex = 2;
            this.btnAdicionarP.Text = "Adicionar";
            this.btnAdicionarP.UseVisualStyleBackColor = false;
            // 
            // txtPrato
            // 
            this.txtPrato.Location = new System.Drawing.Point(96, 68);
            this.txtPrato.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrato.Name = "txtPrato";
            this.txtPrato.Size = new System.Drawing.Size(132, 22);
            this.txtPrato.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do prato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(57, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // cbTipoPrato
            // 
            this.cbTipoPrato.FormattingEnabled = true;
            this.cbTipoPrato.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.cbTipoPrato.Location = new System.Drawing.Point(96, 101);
            this.cbTipoPrato.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoPrato.Name = "cbTipoPrato";
            this.cbTipoPrato.Size = new System.Drawing.Size(132, 24);
            this.cbTipoPrato.TabIndex = 6;
            // 
            // btnEditarP
            // 
            this.btnEditarP.BackColor = System.Drawing.Color.Gold;
            this.btnEditarP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarP.FlatAppearance.BorderSize = 2;
            this.btnEditarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarP.Location = new System.Drawing.Point(170, 142);
            this.btnEditarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(58, 30);
            this.btnEditarP.TabIndex = 7;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.UseVisualStyleBackColor = false;
            // 
            // BtnApagarP
            // 
            this.BtnApagarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnApagarP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApagarP.FlatAppearance.BorderSize = 2;
            this.BtnApagarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarP.Location = new System.Drawing.Point(96, 176);
            this.BtnApagarP.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagarP.Name = "BtnApagarP";
            this.BtnApagarP.Size = new System.Drawing.Size(133, 27);
            this.BtnApagarP.TabIndex = 8;
            this.BtnApagarP.Text = "Apagar";
            this.BtnApagarP.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoDA.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 177);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(96, 207);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 30);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Alterações";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // Prato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnApagarP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.cbTipoPrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrato);
            this.Controls.Add(this.btnAdicionarP);
            this.Controls.Add(this.dtgPrato);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prato";
            this.Text = "Gestão dos Pratos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPrato;
        private System.Windows.Forms.Button btnAdicionarP;
        private System.Windows.Forms.TextBox txtPrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoPrato;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button BtnApagarP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
    }
}