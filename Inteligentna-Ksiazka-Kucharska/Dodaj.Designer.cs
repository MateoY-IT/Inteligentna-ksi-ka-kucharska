
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
            this.textBczas = new System.Windows.Forms.TextBox();
            this.bdodaj = new System.Windows.Forms.Button();
            this.banuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Składniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Przygotowanie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(698, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czas Przygotowania";
            // 
            // textBtytul
            // 
            this.textBtytul.Location = new System.Drawing.Point(36, 48);
            this.textBtytul.Name = "textBtytul";
            this.textBtytul.Size = new System.Drawing.Size(202, 20);
            this.textBtytul.TabIndex = 4;
            // 
            // textBprzygotowanie
            // 
            this.textBprzygotowanie.Location = new System.Drawing.Point(38, 187);
            this.textBprzygotowanie.Multiline = true;
            this.textBprzygotowanie.Name = "textBprzygotowanie";
            this.textBprzygotowanie.Size = new System.Drawing.Size(578, 166);
            this.textBprzygotowanie.TabIndex = 5;
            // 
            // listBskladniki
            // 
            this.listBskladniki.FormattingEnabled = true;
            this.listBskladniki.Location = new System.Drawing.Point(363, 48);
            this.listBskladniki.Name = "listBskladniki";
            this.listBskladniki.Size = new System.Drawing.Size(232, 43);
            this.listBskladniki.TabIndex = 6;
            // 
            // textBczas
            // 
            this.textBczas.Location = new System.Drawing.Point(712, 71);
            this.textBczas.Name = "textBczas";
            this.textBczas.Size = new System.Drawing.Size(221, 20);
            this.textBczas.TabIndex = 7;
            // 
            // bdodaj
            // 
            this.bdodaj.Location = new System.Drawing.Point(723, 205);
            this.bdodaj.Name = "bdodaj";
            this.bdodaj.Size = new System.Drawing.Size(210, 46);
            this.bdodaj.TabIndex = 8;
            this.bdodaj.Text = "Dodaj";
            this.bdodaj.UseVisualStyleBackColor = true;
            this.bdodaj.Click += new System.EventHandler(this.bdodaj_Click);
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(723, 281);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(210, 46);
            this.banuluj.TabIndex = 9;
            this.banuluj.Text = "Anuluj";
            this.banuluj.UseVisualStyleBackColor = true;
            this.banuluj.Click += new System.EventHandler(this.banuluj_Click);
            // 
            // Dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 393);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bdodaj);
            this.Controls.Add(this.textBczas);
            this.Controls.Add(this.listBskladniki);
            this.Controls.Add(this.textBprzygotowanie);
            this.Controls.Add(this.textBtytul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dodaj";
            this.Text = "Dodaj Przepis";
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
        private System.Windows.Forms.TextBox textBczas;
        private System.Windows.Forms.Button bdodaj;
        private System.Windows.Forms.Button banuluj;
    }
}