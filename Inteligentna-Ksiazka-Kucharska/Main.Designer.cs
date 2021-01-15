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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.przepisyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZakupówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbprzepis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.buttonusun = new System.Windows.Forms.Button();
            this.buttonedytuj = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBprzygotowanie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxczas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSkladniki = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 558);
            this.panel1.TabIndex = 0;
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
            this.listbprzepis.Size = new System.Drawing.Size(315, 372);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.47059F));
            this.tableLayoutPanel2.Controls.Add(this.textBprzygotowanie, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxczas, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelSkladniki, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(597, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(695, 374);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // textBprzygotowanie
            // 
            this.textBprzygotowanie.Location = new System.Drawing.Point(171, 142);
            this.textBprzygotowanie.Margin = new System.Windows.Forms.Padding(4);
            this.textBprzygotowanie.Multiline = true;
            this.textBprzygotowanie.Name = "textBprzygotowanie";
            this.textBprzygotowanie.ReadOnly = true;
            this.textBprzygotowanie.Size = new System.Drawing.Size(517, 109);
            this.textBprzygotowanie.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Składniki:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Czas przygotowania:";
            // 
            // textBoxczas
            // 
            this.textBoxczas.Location = new System.Drawing.Point(171, 104);
            this.textBoxczas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxczas.Multiline = true;
            this.textBoxczas.Name = "textBoxczas";
            this.textBoxczas.ReadOnly = true;
            this.textBoxczas.Size = new System.Drawing.Size(517, 27);
            this.textBoxczas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Przygotowanie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Zdjecie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(170, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelSkladniki
            // 
            this.labelSkladniki.AutoSize = true;
            this.labelSkladniki.Location = new System.Drawing.Point(170, 3);
            this.labelSkladniki.Name = "labelSkladniki";
            this.labelSkladniki.Size = new System.Drawing.Size(46, 17);
            this.labelSkladniki.TabIndex = 16;
            this.labelSkladniki.Text = "label3";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 558);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.buttonedytuj);
            this.Controls.Add(this.buttonusun);
            this.Controls.Add(this.buttondodaj);
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
            this.panel2.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listbprzepis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Button buttonusun;
        private System.Windows.Forms.Button buttonedytuj;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przepisyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZakupówToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBprzygotowanie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxczas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSkladniki;
    }
}