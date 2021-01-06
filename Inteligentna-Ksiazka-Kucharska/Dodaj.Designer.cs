
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBtytul = new System.Windows.Forms.TextBox();
            this.textBprzygotowanie = new System.Windows.Forms.TextBox();
            this.listBskladniki = new System.Windows.Forms.ListBox();
            this.bdodaj = new System.Windows.Forms.Button();
            this.banuluj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bwybierz = new System.Windows.Forms.Button();
            this.nczasp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(478, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Składniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Przygotowanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czas Przygotowania";
            // 
            // textBtytul
            // 
            this.textBtytul.Location = new System.Drawing.Point(48, 59);
            this.textBtytul.Margin = new System.Windows.Forms.Padding(4);
            this.textBtytul.Name = "textBtytul";
            this.textBtytul.Size = new System.Drawing.Size(268, 22);
            this.textBtytul.TabIndex = 4;
            // 
            // textBprzygotowanie
            // 
            this.textBprzygotowanie.Location = new System.Drawing.Point(51, 230);
            this.textBprzygotowanie.Margin = new System.Windows.Forms.Padding(4);
            this.textBprzygotowanie.Multiline = true;
            this.textBprzygotowanie.Name = "textBprzygotowanie";
            this.textBprzygotowanie.Size = new System.Drawing.Size(769, 203);
            this.textBprzygotowanie.TabIndex = 5;
            // 
            // listBskladniki
            // 
            this.listBskladniki.FormattingEnabled = true;
            this.listBskladniki.ItemHeight = 16;
            this.listBskladniki.Location = new System.Drawing.Point(484, 47);
            this.listBskladniki.Margin = new System.Windows.Forms.Padding(4);
            this.listBskladniki.Name = "listBskladniki";
            this.listBskladniki.Size = new System.Drawing.Size(390, 148);
            this.listBskladniki.TabIndex = 6;
            this.listBskladniki.SelectedIndexChanged += new System.EventHandler(this.listBskladniki_SelectedIndexChanged);
            // 
            // bdodaj
            // 
            this.bdodaj.Location = new System.Drawing.Point(964, 311);
            this.bdodaj.Margin = new System.Windows.Forms.Padding(4);
            this.bdodaj.Name = "bdodaj";
            this.bdodaj.Size = new System.Drawing.Size(280, 57);
            this.bdodaj.TabIndex = 8;
            this.bdodaj.Text = "Dodaj";
            this.bdodaj.UseVisualStyleBackColor = true;
            this.bdodaj.Click += new System.EventHandler(this.bdodaj_Click);
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(964, 376);
            this.banuluj.Margin = new System.Windows.Forms.Padding(4);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(280, 57);
            this.banuluj.TabIndex = 9;
            this.banuluj.Text = "Anuluj";
            this.banuluj.UseVisualStyleBackColor = true;
            this.banuluj.Click += new System.EventHandler(this.banuluj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(914, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 204);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bwybierz
            // 
            this.bwybierz.Location = new System.Drawing.Point(1000, 247);
            this.bwybierz.Margin = new System.Windows.Forms.Padding(4);
            this.bwybierz.Name = "bwybierz";
            this.bwybierz.Size = new System.Drawing.Size(231, 34);
            this.bwybierz.TabIndex = 11;
            this.bwybierz.Text = "Dodaj zdjęcie";
            this.bwybierz.UseVisualStyleBackColor = true;
            this.bwybierz.Click += new System.EventHandler(this.bwybierz_Click);
            // 
            // nczasp
            // 
            this.nczasp.Location = new System.Drawing.Point(47, 144);
            this.nczasp.Name = "nczasp";
            this.nczasp.Size = new System.Drawing.Size(269, 22);
            this.nczasp.TabIndex = 12;
            this.nczasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 484);
            this.Controls.Add(this.nczasp);
            this.Controls.Add(this.bwybierz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bdodaj);
            this.Controls.Add(this.listBskladniki);
            this.Controls.Add(this.textBprzygotowanie);
            this.Controls.Add(this.textBtytul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Przepis";
            this.Load += new System.EventHandler(this.Dodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBtytul;
        private System.Windows.Forms.TextBox textBprzygotowanie;
        private System.Windows.Forms.ListBox listBskladniki;
        private System.Windows.Forms.Button bdodaj;
        private System.Windows.Forms.Button banuluj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bwybierz;
        private System.Windows.Forms.NumericUpDown nczasp;
    }
}