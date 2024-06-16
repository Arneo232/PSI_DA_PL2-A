namespace iCantina
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TSM = new System.Windows.Forms.MenuStrip();
            this.TSM_GestaoC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoM = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoF = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_GestaoMulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Registo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::iCantina.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 359);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Área de Trabalho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.TSM.Location = new System.Drawing.Point(29, 62);
            this.TSM.Name = "TSM";
            this.TSM.Size = new System.Drawing.Size(673, 24);
            this.TSM.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(732, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TSM);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TSM.ResumeLayout(false);
            this.TSM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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

