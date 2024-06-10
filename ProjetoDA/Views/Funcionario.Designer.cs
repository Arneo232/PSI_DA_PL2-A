namespace ProjetoDA.Views
{
    partial class Funcionario
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
            this.BtnApagarF = new System.Windows.Forms.Button();
            this.btnEditarF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionarF = new System.Windows.Forms.Button();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnApagarF
            // 
            this.BtnApagarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnApagarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApagarF.FlatAppearance.BorderSize = 2;
            this.BtnApagarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarF.Location = new System.Drawing.Point(29, 287);
            this.BtnApagarF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagarF.Name = "BtnApagarF";
            this.BtnApagarF.Size = new System.Drawing.Size(297, 27);
            this.BtnApagarF.TabIndex = 24;
            this.BtnApagarF.Text = "Apagar Funcionário";
            this.BtnApagarF.UseVisualStyleBackColor = false;
            // 
            // btnEditarF
            // 
            this.btnEditarF.BackColor = System.Drawing.Color.Gold;
            this.btnEditarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarF.FlatAppearance.BorderSize = 2;
            this.btnEditarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarF.Location = new System.Drawing.Point(194, 253);
            this.btnEditarF.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarF.Name = "btnEditarF";
            this.btnEditarF.Size = new System.Drawing.Size(132, 30);
            this.btnEditarF.TabIndex = 23;
            this.btnEditarF.Text = "Editar Funcionário";
            this.btnEditarF.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 76);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 22);
            this.txtNome.TabIndex = 19;
            // 
            // btnAdicionarF
            // 
            this.btnAdicionarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarF.FlatAppearance.BorderSize = 2;
            this.btnAdicionarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarF.Location = new System.Drawing.Point(29, 253);
            this.btnAdicionarF.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarF.Name = "btnAdicionarF";
            this.btnAdicionarF.Size = new System.Drawing.Size(161, 30);
            this.btnAdicionarF.TabIndex = 18;
            this.btnAdicionarF.Text = "Adicionar Funcionário";
            this.btnAdicionarF.UseVisualStyleBackColor = false;
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Location = new System.Drawing.Point(372, 76);
            this.dtgFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.RowHeadersWidth = 51;
            this.dtgFuncionario.RowTemplate.Height = 24;
            this.dtgFuncionario.Size = new System.Drawing.Size(450, 469);
            this.dtgFuncionario.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registo de Funcionários";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjetoDA.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(68, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 177);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Carne",
            "Peixe",
            "Vegan"});
            this.cbCargo.Location = new System.Drawing.Point(84, 145);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(207, 24);
            this.cbCargo.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label4.Location = new System.Drawing.Point(40, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cargo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Location = new System.Drawing.Point(110, 173);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(161, 30);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar Alterações";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 554);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnApagarF);
            this.Controls.Add(this.btnEditarF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdicionarF);
            this.Controls.Add(this.dtgFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Funcionario";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestão de Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnApagarF;
        private System.Windows.Forms.Button btnEditarF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarF;
        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
    }
}