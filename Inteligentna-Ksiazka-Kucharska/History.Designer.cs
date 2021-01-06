
namespace Inteligentna_Ksiazka_Kucharska
{
    partial class History
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
            this.listBoxhistoria = new System.Windows.Forms.ListBox();
            this.listBoxwyswietl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historia ostatnich przepisów:";
            // 
            // listBoxhistoria
            // 
            this.listBoxhistoria.FormattingEnabled = true;
            this.listBoxhistoria.ItemHeight = 16;
            this.listBoxhistoria.Location = new System.Drawing.Point(33, 58);
            this.listBoxhistoria.Name = "listBoxhistoria";
            this.listBoxhistoria.Size = new System.Drawing.Size(575, 452);
            this.listBoxhistoria.TabIndex = 1;
            this.listBoxhistoria.SelectedIndexChanged += new System.EventHandler(this.listBoxhistoria_SelectedIndexChanged);
            // 
            // listBoxwyswietl
            // 
            this.listBoxwyswietl.FormattingEnabled = true;
            this.listBoxwyswietl.ItemHeight = 16;
            this.listBoxwyswietl.Location = new System.Drawing.Point(690, 58);
            this.listBoxwyswietl.Name = "listBoxwyswietl";
            this.listBoxwyswietl.Size = new System.Drawing.Size(575, 452);
            this.listBoxwyswietl.TabIndex = 2;
            this.listBoxwyswietl.SelectedIndexChanged += new System.EventHandler(this.listBoxwyswietl_SelectedIndexChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 558);
            this.Controls.Add(this.listBoxwyswietl);
            this.Controls.Add(this.listBoxhistoria);
            this.Controls.Add(this.label1);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxhistoria;
        private System.Windows.Forms.ListBox listBoxwyswietl;
    }
}