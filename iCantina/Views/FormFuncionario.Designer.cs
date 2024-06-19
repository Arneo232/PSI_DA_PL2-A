namespace iCantina.Views
{
    partial class FormFuncionario
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.BtnApagarF = new System.Windows.Forms.Button();
            this.btnEditarF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionarF = new System.Windows.Forms.Button();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Extras = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(113, 244);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 30);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Username:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(113, 138);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(194, 22);
            this.txtNIF.TabIndex = 41;
            // 
            // BtnApagarF
            // 
            this.BtnApagarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnApagarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApagarF.FlatAppearance.BorderSize = 2;
            this.BtnApagarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.BtnApagarF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagarF.Location = new System.Drawing.Point(113, 278);
            this.BtnApagarF.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagarF.Name = "BtnApagarF";
            this.BtnApagarF.Size = new System.Drawing.Size(194, 27);
            this.BtnApagarF.TabIndex = 38;
            this.BtnApagarF.Text = "Apagar";
            this.BtnApagarF.UseVisualStyleBackColor = false;
            this.BtnApagarF.Click += new System.EventHandler(this.BtnApagarF_Click);
            // 
            // btnEditarF
            // 
            this.btnEditarF.BackColor = System.Drawing.Color.Gold;
            this.btnEditarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarF.FlatAppearance.BorderSize = 2;
            this.btnEditarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditarF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarF.Location = new System.Drawing.Point(210, 244);
            this.btnEditarF.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarF.Name = "btnEditarF";
            this.btnEditarF.Size = new System.Drawing.Size(97, 30);
            this.btnEditarF.TabIndex = 37;
            this.btnEditarF.Text = "Editar";
            this.btnEditarF.UseVisualStyleBackColor = false;
            this.btnEditarF.Click += new System.EventHandler(this.btnEditarF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 103);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 22);
            this.txtNome.TabIndex = 34;
            // 
            // btnAdicionarF
            // 
            this.btnAdicionarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarF.FlatAppearance.BorderSize = 2;
            this.btnAdicionarF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdicionarF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarF.Location = new System.Drawing.Point(113, 210);
            this.btnAdicionarF.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarF.Name = "btnAdicionarF";
            this.btnAdicionarF.Size = new System.Drawing.Size(194, 30);
            this.btnAdicionarF.TabIndex = 33;
            this.btnAdicionarF.Text = "Adicionar";
            this.btnAdicionarF.UseVisualStyleBackColor = false;
            this.btnAdicionarF.Click += new System.EventHandler(this.btnAdicionarF_Click);
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Location = new System.Drawing.Point(414, 102);
            this.dtgFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.RowHeadersWidth = 51;
            this.dtgFuncionario.RowTemplate.Height = 24;
            this.dtgFuncionario.Size = new System.Drawing.Size(528, 409);
            this.dtgFuncionario.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Registo de Funcionários";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::iCantina.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(100, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 177);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // TSM
            // 
            this.TSM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM.Dock = System.Windows.Forms.DockStyle.None;
            this.TSM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_GestaoC,
            this.TSM_GestaoP,
            this.TSM_Extras,
            this.TSM_GestaoM,
            this.TSM_GestaoMulta,
            this.TSM_Registo,
            this.gestãoDeReservasToolStripMenuItem});
            this.TSM.Location = new System.Drawing.Point(52, 41);
            this.TSM.Name = "TSM";
            this.TSM.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSM.Size = new System.Drawing.Size(836, 24);
            this.TSM.TabIndex = 44;
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
            // TSM_Extras
            // 
            this.TSM_Extras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TSM_Extras.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_Extras.Name = "TSM_Extras";
            this.TSM_Extras.Size = new System.Drawing.Size(115, 20);
            this.TSM_Extras.Text = "Gestão dos Extras";
            this.TSM_Extras.Click += new System.EventHandler(this.TSM_Extras_Click);
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
            this.TSM_Registo.Enabled = false;
            this.TSM_Registo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.TSM_Registo.Name = "TSM_Registo";
            this.TSM_Registo.Size = new System.Drawing.Size(143, 20);
            this.TSM_Registo.Text = "Registo de Funcionário";
            // 
            // gestãoDeReservasToolStripMenuItem
            // 
            this.gestãoDeReservasToolStripMenuItem.Name = "gestãoDeReservasToolStripMenuItem";
            this.gestãoDeReservasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestãoDeReservasToolStripMenuItem.Text = "Gestão de Reservas";
            this.gestãoDeReservasToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeReservasToolStripMenuItem_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 172);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 22);
            this.txtUsername.TabIndex = 45;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 523);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.TSM);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnApagarF);
            this.Controls.Add(this.btnEditarF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAdicionarF);
            this.Controls.Add(this.dtgFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFuncionario";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Gestão de Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnApagarF;
        private System.Windows.Forms.Button btnEditarF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarF;
        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip TSM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoC;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoP;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoM;
        private System.Windows.Forms.ToolStripMenuItem TSM_GestaoMulta;
        private System.Windows.Forms.ToolStripMenuItem TSM_Registo;
        private System.Windows.Forms.ToolStripMenuItem TSM_Extras;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeReservasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsername;
    }
}