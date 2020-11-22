namespace Inteligentna_Ksiazka_Kucharska
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonArtykol = new System.Windows.Forms.Button();
            this.buttonPrzepisy = new System.Windows.Forms.Button();
            this.userControl11 = new Inteligentna_Ksiazka_Kucharska.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonPrzepisy);
            this.panel1.Controls.Add(this.buttonArtykol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 20);
            this.panel2.TabIndex = 1;
            // 
            // buttonArtykol
            // 
            this.buttonArtykol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtykol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArtykol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonArtykol.Location = new System.Drawing.Point(13, 111);
            this.buttonArtykol.Name = "buttonArtykol";
            this.buttonArtykol.Size = new System.Drawing.Size(170, 53);
            this.buttonArtykol.TabIndex = 0;
            this.buttonArtykol.Text = "Artykuły";
            this.buttonArtykol.UseVisualStyleBackColor = true;
            this.buttonArtykol.Click += new System.EventHandler(this.buttonArtykol_Click);
            // 
            // buttonPrzepisy
            // 
            this.buttonPrzepisy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrzepisy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrzepisy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrzepisy.Location = new System.Drawing.Point(13, 180);
            this.buttonPrzepisy.Name = "buttonPrzepisy";
            this.buttonPrzepisy.Size = new System.Drawing.Size(170, 53);
            this.buttonPrzepisy.TabIndex = 1;
            this.buttonPrzepisy.Text = "Przepisy";
            this.buttonPrzepisy.UseVisualStyleBackColor = true;
            this.buttonPrzepisy.Click += new System.EventHandler(this.buttonPrzepisy_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(200, 26);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(767, 380);
            this.userControl11.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonArtykol;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button buttonPrzepisy;
    }
}