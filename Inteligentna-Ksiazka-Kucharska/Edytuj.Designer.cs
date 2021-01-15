
namespace Inteligentna_Ksiazka_Kucharska
{
    partial class Edytuj
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
            this.listBoxwyswietl = new System.Windows.Forms.ListBox();
            this.bedytuj = new System.Windows.Forms.Button();
            this.banuluj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBprzygotowanie = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nczasp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bwybierz = new System.Windows.Forms.Button();
            this.CLBSkladniki = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxwyswietl
            // 
            this.listBoxwyswietl.FormattingEnabled = true;
            this.listBoxwyswietl.ItemHeight = 16;
            this.listBoxwyswietl.Location = new System.Drawing.Point(12, 6);
            this.listBoxwyswietl.Name = "listBoxwyswietl";
            this.listBoxwyswietl.Size = new System.Drawing.Size(484, 356);
            this.listBoxwyswietl.TabIndex = 1;
            this.listBoxwyswietl.SelectedIndexChanged += new System.EventHandler(this.listBoxwyswietl_SelectedIndexChanged);
            // 
            // bedytuj
            // 
            this.bedytuj.Location = new System.Drawing.Point(31, 388);
            this.bedytuj.Margin = new System.Windows.Forms.Padding(4);
            this.bedytuj.Name = "bedytuj";
            this.bedytuj.Size = new System.Drawing.Size(206, 60);
            this.bedytuj.TabIndex = 9;
            this.bedytuj.Text = "Zapisz";
            this.bedytuj.UseVisualStyleBackColor = true;
            this.bedytuj.Click += new System.EventHandler(this.bedytuj_Click);
            // 
            // banuluj
            // 
            this.banuluj.Location = new System.Drawing.Point(269, 388);
            this.banuluj.Margin = new System.Windows.Forms.Padding(4);
            this.banuluj.Name = "banuluj";
            this.banuluj.Size = new System.Drawing.Size(206, 60);
            this.banuluj.TabIndex = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nczasp, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bwybierz, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CLBSkladniki, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(502, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.11055F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.88945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 460);
            this.tableLayoutPanel1.TabIndex = 11;
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
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(274, 6);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(497, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Składniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Czas Przygotowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Przygotowanie";
            // 
            // nczasp
            // 
            this.nczasp.Location = new System.Drawing.Point(274, 138);
            this.nczasp.Name = "nczasp";
            this.nczasp.Size = new System.Drawing.Size(496, 22);
            this.nczasp.TabIndex = 13;
            this.nczasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zdjecie";
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
            // CLBSkladniki
            // 
            this.CLBSkladniki.FormattingEnabled = true;
            this.CLBSkladniki.Location = new System.Drawing.Point(274, 37);
            this.CLBSkladniki.Name = "CLBSkladniki";
            this.CLBSkladniki.Size = new System.Drawing.Size(340, 89);
            this.CLBSkladniki.TabIndex = 17;
            // 
            // Edytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.banuluj);
            this.Controls.Add(this.bedytuj);
            this.Controls.Add(this.listBoxwyswietl);
            this.Name = "Edytuj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj";
            this.Load += new System.EventHandler(this.Edytuj_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nczasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxwyswietl;
        private System.Windows.Forms.Button bedytuj;
        private System.Windows.Forms.Button banuluj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBprzygotowanie;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nczasp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bwybierz;
        private System.Windows.Forms.CheckedListBox CLBSkladniki;
    }
}