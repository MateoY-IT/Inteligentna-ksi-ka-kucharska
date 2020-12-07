
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
            this.bpotwierdz.Location = new System.Drawing.Point(26, 204);
            this.bpotwierdz.Name = "bpotwierdz";
            this.bpotwierdz.Size = new System.Drawing.Size(210, 46);
            this.bpotwierdz.TabIndex = 0;
            this.bpotwierdz.Text = "Potwierdź";
            this.bpotwierdz.UseVisualStyleBackColor = true;
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(287, 204);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(210, 46);
            this.banuluj.TabIndex = 1;
            this.banuluj.Text = "Anuluj";
            this.banuluj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz Przepis:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 121);
            this.listBox1.TabIndex = 3;
            // 
            // Usun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 292);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bpotwierdz);
            this.Name = "Usun";
            this.Text = "Usuń Przepis";
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