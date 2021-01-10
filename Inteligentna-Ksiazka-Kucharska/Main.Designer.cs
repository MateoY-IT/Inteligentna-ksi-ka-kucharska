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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZakupówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbprzepis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxopis = new System.Windows.Forms.TextBox();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonusun = new System.Windows.Forms.Button();
            this.buttonedytuj = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 558);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timery:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.toolStripContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 25);
            this.panel2.TabIndex = 1;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1038, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1038, 28);
            this.toolStripContainer1.TabIndex = 10;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przepisyToolStripMenuItem,
            this.ulubioneToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.listaZakupówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // przepisyToolStripMenuItem
            // 
            this.przepisyToolStripMenuItem.Name = "przepisyToolStripMenuItem";
            this.przepisyToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.przepisyToolStripMenuItem.Text = "Przepisy";
            this.przepisyToolStripMenuItem.Click += new System.EventHandler(this.przepisyToolStripMenuItem_Click);
            // 
            // ulubioneToolStripMenuItem
            // 
            this.ulubioneToolStripMenuItem.Name = "ulubioneToolStripMenuItem";
            this.ulubioneToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ulubioneToolStripMenuItem.Text = "Ulubione";
            this.ulubioneToolStripMenuItem.Click += new System.EventHandler(this.ulubioneToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // listaZakupówToolStripMenuItem
            // 
            this.listaZakupówToolStripMenuItem.Name = "listaZakupówToolStripMenuItem";
            this.listaZakupówToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.listaZakupówToolStripMenuItem.Text = "Lista Zakupów";
            this.listaZakupówToolStripMenuItem.Click += new System.EventHandler(this.listaZakupówToolStripMenuItem_Click);
            // 
            // listbprzepis
            // 
            this.listbprzepis.FormattingEnabled = true;
            this.listbprzepis.ItemHeight = 16;
            this.listbprzepis.Location = new System.Drawing.Point(275, 80);
            this.listbprzepis.Margin = new System.Windows.Forms.Padding(4);
            this.listbprzepis.Name = "listbprzepis";
            this.listbprzepis.Size = new System.Drawing.Size(411, 372);
            this.listbprzepis.TabIndex = 2;
            this.listbprzepis.SelectedIndexChanged += new System.EventHandler(this.listbprzepis_SelectedIndexChanged);
            this.listbprzepis.SelectedValueChanged += new System.EventHandler(this.listbprzepis_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przepisy";
            // 
            // textBoxopis
            // 
            this.textBoxopis.Location = new System.Drawing.Point(699, 80);
            this.textBoxopis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxopis.Multiline = true;
            this.textBoxopis.Name = "textBoxopis";
            this.textBoxopis.Size = new System.Drawing.Size(593, 374);
            this.textBoxopis.TabIndex = 4;
            // 
            // buttondodaj
            // 
            this.buttondodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttondodaj.Location = new System.Drawing.Point(295, 476);
            this.buttondodaj.Margin = new System.Windows.Forms.Padding(4);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(280, 57);
            this.buttondodaj.TabIndex = 5;
            this.buttondodaj.Text = "Dodaj Przepis";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // buttonusun
            // 
            this.buttonusun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonusun.Location = new System.Drawing.Point(603, 476);
            this.buttonusun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonusun.Name = "buttonusun";
            this.buttonusun.Size = new System.Drawing.Size(280, 57);
            this.buttonusun.TabIndex = 6;
            this.buttonusun.Text = "Usuń Przepis";
            this.buttonusun.UseVisualStyleBackColor = true;
            this.buttonusun.Click += new System.EventHandler(this.buttonusun_Click);
            // 
            // buttonedytuj
            // 
            this.buttonedytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonedytuj.Location = new System.Drawing.Point(918, 476);
            this.buttonedytuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonedytuj.Name = "buttonedytuj";
            this.buttonedytuj.Size = new System.Drawing.Size(280, 57);
            this.buttonedytuj.TabIndex = 7;
            this.buttonedytuj.Text = "Edytuj Przepis";
            this.buttonedytuj.UseVisualStyleBackColor = true;
            this.buttonedytuj.Click += new System.EventHandler(this.buttonedytuj_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1159, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(817, 34);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 28);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 558);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.buttonedytuj);
            this.Controls.Add(this.buttonusun);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.textBoxopis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbprzepis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza Przepisów";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listbprzepis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxopis;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonusun;
        private System.Windows.Forms.Button buttonedytuj;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przepisyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZakupówToolStripMenuItem;
    }
}