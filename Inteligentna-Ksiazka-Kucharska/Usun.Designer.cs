
namespace Inteligentna_Ksiazka_Kucharska
{
    partial class Usun
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
            this.bpotwierdz = new System.Windows.Forms.Button();
            this.banuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bpotwierdz
            // 
            this.bpotwierdz.Location = new System.Drawing.Point(35, 251);
            this.bpotwierdz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bpotwierdz.Name = "bpotwierdz";
            this.bpotwierdz.Size = new System.Drawing.Size(280, 57);
            this.bpotwierdz.TabIndex = 0;
            this.bpotwierdz.Text = "Potwierdź";
            this.bpotwierdz.UseVisualStyleBackColor = true;
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(383, 251);
            this.banuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(280, 57);
            this.banuluj.TabIndex = 1;
            this.banuluj.Text = "Anuluj";
            this.banuluj.UseVisualStyleBackColor = true;
            this.banuluj.Click += new System.EventHandler(this.banuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz Przepis:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(35, 68);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 148);
            this.listBox1.TabIndex = 3;
            // 
            // Usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 359);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bpotwierdz);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usun";
            this.Text = "Usuń Przepis";
            this.Load += new System.EventHandler(this.Usun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bpotwierdz;
        private System.Windows.Forms.Button banuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}