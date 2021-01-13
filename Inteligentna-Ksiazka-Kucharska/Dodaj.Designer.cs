
namespace Inteligentna_Ksiazka_Kucharska
{
    partial class Dodaj
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
            this.banuluj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBprzygotowanie = new System.Windows.Forms.TextBox();
            this.textBtytul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nczasp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bwybierz = new System.Windows.Forms.Button();
            this.cLBSkladniki = new System.Windows.Forms.CheckedListBox();
            this.bdodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(446, 489);
            this.banuluj.Margin = new System.Windows.Forms.Padding(4);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(280, 57);
            this.banuluj.TabIndex = 9;
            this.banuluj.Text = "Anuluj";
            this.banuluj.UseVisualStyleBackColor = true;
            this.banuluj.Click += new System.EventHandler(this.banuluj_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56677F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.43323F));
            this.tableLayoutPanel1.Controls.Add(this.textBprzygotowanie, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBtytul, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nczasp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bwybierz, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cLBSkladniki, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.11055F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.88945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 460);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // textBprzygotowanie
            // 
            this.textBprzygotowanie.Location = new System.Drawing.Point(275, 169);
            this.textBprzygotowanie.Margin = new System.Windows.Forms.Padding(4);
            this.textBprzygotowanie.Multiline = true;
            this.textBprzygotowanie.Name = "textBprzygotowanie";
            this.textBprzygotowanie.Size = new System.Drawing.Size(495, 148);
            this.textBprzygotowanie.TabIndex = 11;
            // 
            // textBtytul
            // 
            this.textBtytul.Location = new System.Drawing.Point(274, 6);
            this.textBtytul.Multiline = true;
            this.textBtytul.Name = "textBtytul";
            this.textBtytul.Size = new System.Drawing.Size(497, 22);
            this.textBtytul.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tytuł";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Składniki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Czas Przygotowania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Przygotowanie";
            // 
            // nczasp
            // 
            this.nczasp.Location = new System.Drawing.Point(274, 138);
            this.nczasp.Name = "nczasp";
            this.nczasp.Size = new System.Drawing.Size(496, 22);
            this.nczasp.TabIndex = 13;
            this.nczasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Zdjecie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(274, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 127);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bwybierz
            // 
            this.bwybierz.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bwybierz.Location = new System.Drawing.Point(124, 328);
            this.bwybierz.Margin = new System.Windows.Forms.Padding(4);
            this.bwybierz.Name = "bwybierz";
            this.bwybierz.Size = new System.Drawing.Size(140, 38);
            this.bwybierz.TabIndex = 16;
            this.bwybierz.Text = "Dodaj zdjęcie";
            this.bwybierz.UseVisualStyleBackColor = true;
            this.bwybierz.Click += new System.EventHandler(this.bwybierz_Click);
            // 
            // cLBSkladniki
            // 
            this.cLBSkladniki.FormattingEnabled = true;
            this.cLBSkladniki.Location = new System.Drawing.Point(274, 37);
            this.cLBSkladniki.Name = "cLBSkladniki";
            this.cLBSkladniki.Size = new System.Drawing.Size(497, 89);
            this.cLBSkladniki.TabIndex = 17;
            // 
            // bdodaj
            // 
            this.bdodaj.Location = new System.Drawing.Point(76, 489);
            this.bdodaj.Margin = new System.Windows.Forms.Padding(4);
            this.bdodaj.Name = "bdodaj";
            this.bdodaj.Size = new System.Drawing.Size(280, 57);
            this.bdodaj.TabIndex = 8;
            this.bdodaj.Text = "Dodaj";
            this.bdodaj.UseVisualStyleBackColor = true;
            this.bdodaj.Click += new System.EventHandler(this.bdodaj_Click);
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bdodaj);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Przepis";
            this.Load += new System.EventHandler(this.Dodaj_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button banuluj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBprzygotowanie;
        private System.Windows.Forms.TextBox textBtytul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nczasp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bwybierz;
        private System.Windows.Forms.CheckedListBox cLBSkladniki;
        private System.Windows.Forms.Button bdodaj;
    }
}