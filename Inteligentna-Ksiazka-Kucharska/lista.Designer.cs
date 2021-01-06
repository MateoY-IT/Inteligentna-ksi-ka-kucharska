
namespace Inteligentna_Ksiazka_Kucharska
{
    partial class lista
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonusun = new System.Windows.Forms.Button();
            this.buttonedytuj = new System.Windows.Forms.Button();
            this.buttondodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Zakupów";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(406, 70);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(373, 412);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 91);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonusun
            // 
            this.buttonusun.Location = new System.Drawing.Point(29, 304);
            this.buttonusun.Name = "buttonusun";
            this.buttonusun.Size = new System.Drawing.Size(280, 57);
            this.buttonusun.TabIndex = 5;
            this.buttonusun.Text = "Usuń";
            this.buttonusun.UseVisualStyleBackColor = true;
            this.buttonusun.Click += new System.EventHandler(this.buttonusun_Click);
            // 
            // buttonedytuj
            // 
            this.buttonedytuj.Location = new System.Drawing.Point(29, 381);
            this.buttonedytuj.Name = "buttonedytuj";
            this.buttonedytuj.Size = new System.Drawing.Size(280, 57);
            this.buttonedytuj.TabIndex = 6;
            this.buttonedytuj.Text = "Edytuj";
            this.buttonedytuj.UseVisualStyleBackColor = true;
            this.buttonedytuj.Click += new System.EventHandler(this.buttonedytuj_Click);
            // 
            // buttondodaj
            // 
            this.buttondodaj.Location = new System.Drawing.Point(29, 227);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(280, 57);
            this.buttondodaj.TabIndex = 7;
            this.buttondodaj.Text = "Dodaj";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Podaj produkt:";
            // 
            // lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.buttonedytuj);
            this.Controls.Add(this.buttonusun);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Zakupów";
            this.Load += new System.EventHandler(this.lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonusun;
        private System.Windows.Forms.Button buttonedytuj;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.Label label2;
    }
}