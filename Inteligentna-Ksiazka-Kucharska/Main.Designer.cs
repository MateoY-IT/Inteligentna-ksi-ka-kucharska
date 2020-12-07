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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZakupówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przepisyDataSet = new Inteligentna_Ksiazka_Kucharska.PrzepisyDataSet();
            this.listbprzepis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxopis = new System.Windows.Forms.TextBox();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonusun = new System.Windows.Forms.Button();
            this.buttonedytuj = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 20);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przepisyToolStripMenuItem,
            this.ulubioneToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.listaZakupówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // przepisyToolStripMenuItem
            // 
            this.przepisyToolStripMenuItem.Name = "przepisyToolStripMenuItem";
            this.przepisyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.przepisyToolStripMenuItem.Text = "Przepisy";
            // 
            // ulubioneToolStripMenuItem
            // 
            this.ulubioneToolStripMenuItem.Name = "ulubioneToolStripMenuItem";
            this.ulubioneToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ulubioneToolStripMenuItem.Text = "Ulubione";
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.historiaToolStripMenuItem.Text = "Historia";
            // 
            // listaZakupówToolStripMenuItem
            // 
            this.listaZakupówToolStripMenuItem.Name = "listaZakupówToolStripMenuItem";
            this.listaZakupówToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listaZakupówToolStripMenuItem.Text = "Lista Zakupów";
            // 
            // przepisyDataSet
            // 
            this.przepisyDataSet.DataSetName = "PrzepisyDataSet";
            this.przepisyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listbprzepis
            // 
            this.listbprzepis.FormattingEnabled = true;
            this.listbprzepis.Location = new System.Drawing.Point(206, 47);
            this.listbprzepis.Name = "listbprzepis";
            this.listbprzepis.Size = new System.Drawing.Size(309, 303);
            this.listbprzepis.TabIndex = 2;
            this.listbprzepis.SelectedIndexChanged += new System.EventHandler(this.listbprzepis_SelectedIndexChanged);
            this.listbprzepis.SelectedValueChanged += new System.EventHandler(this.listbprzepis_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przepisy";
            // 
            // textBoxopis
            // 
            this.textBoxopis.Location = new System.Drawing.Point(521, 47);
            this.textBoxopis.Multiline = true;
            this.textBoxopis.Name = "textBoxopis";
            this.textBoxopis.Size = new System.Drawing.Size(446, 305);
            this.textBoxopis.TabIndex = 4;
            // 
            // buttondodaj
            // 
            this.buttondodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondodaj.Location = new System.Drawing.Point(222, 375);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(210, 46);
            this.buttondodaj.TabIndex = 5;
            this.buttondodaj.Text = "Dodaj Przepis";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonusun
            // 
            this.buttonusun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonusun.Location = new System.Drawing.Point(454, 375);
            this.buttonusun.Name = "buttonusun";
            this.buttonusun.Size = new System.Drawing.Size(210, 46);
            this.buttonusun.TabIndex = 6;
            this.buttonusun.Text = "Usuń Przepis";
            this.buttonusun.UseVisualStyleBackColor = true;
            // 
            // buttonedytuj
            // 
            this.buttonedytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonedytuj.Location = new System.Drawing.Point(688, 375);
            this.buttonedytuj.Name = "buttonedytuj";
            this.buttonedytuj.Size = new System.Drawing.Size(210, 46);
            this.buttonedytuj.TabIndex = 7;
            this.buttonedytuj.Text = "Edytuj Przepis";
            this.buttonedytuj.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.buttonedytuj);
            this.Controls.Add(this.buttonusun);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.textBoxopis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbprzepis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przepisyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZakupówToolStripMenuItem;
        private PrzepisyDataSet przepisyDataSet;
        private System.Windows.Forms.ListBox listbprzepis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxopis;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonusun;
        private System.Windows.Forms.Button buttonedytuj;
    }
}