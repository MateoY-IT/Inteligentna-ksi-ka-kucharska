namespace Inteligentna_Ksiazka_Kucharska
{
    partial class Login
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
            this.textlogin = new System.Windows.Forms.TextBox();
            this.texthaslo = new System.Windows.Forms.TextBox();
            this.panellogowania = new System.Windows.Forms.Label();
            this.buttonzaloguj = new System.Windows.Forms.Button();
            this.niepamietaszhasla = new System.Windows.Forms.LinkLabel();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.zarejestruj = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textlogin
            // 
            this.textlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textlogin.Location = new System.Drawing.Point(42, 72);
            this.textlogin.Multiline = true;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(464, 30);
            this.textlogin.TabIndex = 1;
            this.textlogin.Text = "Login";
            this.textlogin.Enter += new System.EventHandler(this.textlogin_Enter);
            this.textlogin.Leave += new System.EventHandler(this.textlogin_Leave);
            // 
            // texthaslo
            // 
            this.texthaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.texthaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texthaslo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.texthaslo.Location = new System.Drawing.Point(42, 131);
            this.texthaslo.Multiline = true;
            this.texthaslo.Name = "texthaslo";
            this.texthaslo.Size = new System.Drawing.Size(464, 30);
            this.texthaslo.TabIndex = 2;
            this.texthaslo.Text = "Hasło";
            this.texthaslo.Enter += new System.EventHandler(this.texthaslo_Enter);
            this.texthaslo.Leave += new System.EventHandler(this.texthaslo_Leave);
            // 
            // panellogowania
            // 
            this.panellogowania.AutoSize = true;
            this.panellogowania.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panellogowania.Location = new System.Drawing.Point(146, 9);
            this.panellogowania.Name = "panellogowania";
            this.panellogowania.Size = new System.Drawing.Size(244, 33);
            this.panellogowania.TabIndex = 3;
            this.panellogowania.Text = "Panel Logowania";
            // 
            // buttonzaloguj
            // 
            this.buttonzaloguj.BackColor = System.Drawing.Color.DarkGray;
            this.buttonzaloguj.FlatAppearance.BorderSize = 0;
            this.buttonzaloguj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonzaloguj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonzaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonzaloguj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonzaloguj.Location = new System.Drawing.Point(42, 194);
            this.buttonzaloguj.Name = "buttonzaloguj";
            this.buttonzaloguj.Size = new System.Drawing.Size(464, 40);
            this.buttonzaloguj.TabIndex = 4;
            this.buttonzaloguj.Text = "Zaloguj";
            this.buttonzaloguj.UseVisualStyleBackColor = false;
            this.buttonzaloguj.Click += new System.EventHandler(this.buttonzaloguj_Click);
            // 
            // niepamietaszhasla
            // 
            this.niepamietaszhasla.ActiveLinkColor = System.Drawing.Color.Gray;
            this.niepamietaszhasla.AutoSize = true;
            this.niepamietaszhasla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niepamietaszhasla.LinkColor = System.Drawing.Color.Black;
            this.niepamietaszhasla.Location = new System.Drawing.Point(39, 250);
            this.niepamietaszhasla.Name = "niepamietaszhasla";
            this.niepamietaszhasla.Size = new System.Drawing.Size(147, 17);
            this.niepamietaszhasla.TabIndex = 5;
            this.niepamietaszhasla.TabStop = true;
            this.niepamietaszhasla.Text = "Nie pamiętasz hasła?";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorMessage.Location = new System.Drawing.Point(39, 164);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(99, 16);
            this.ErrorMessage.TabIndex = 6;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // zarejestruj
            // 
            this.zarejestruj.ActiveLinkColor = System.Drawing.Color.Gray;
            this.zarejestruj.AutoSize = true;
            this.zarejestruj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zarejestruj.LinkColor = System.Drawing.Color.Black;
            this.zarejestruj.Location = new System.Drawing.Point(359, 250);
            this.zarejestruj.Name = "zarejestruj";
            this.zarejestruj.Size = new System.Drawing.Size(91, 17);
            this.zarejestruj.TabIndex = 8;
            this.zarejestruj.TabStop = true;
            this.zarejestruj.Text = "Zarejestruj się";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(580, 330);
            this.Controls.Add(this.zarejestruj);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.niepamietaszhasla);
            this.Controls.Add(this.buttonzaloguj);
            this.Controls.Add(this.panellogowania);
            this.Controls.Add(this.texthaslo);
            this.Controls.Add(this.textlogin);
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inteligentna Ksiażka Kucharska";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox texthaslo;
        private System.Windows.Forms.Label panellogowania;
        private System.Windows.Forms.Button buttonzaloguj;
        private System.Windows.Forms.LinkLabel niepamietaszhasla;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.LinkLabel zarejestruj;
    }
}