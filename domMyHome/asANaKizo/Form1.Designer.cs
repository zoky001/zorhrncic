namespace domMyHome
{
    partial class frmPrijava
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.linklblLozinka = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(108, 88);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(280, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(108, 175);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(279, 22);
            this.txtLozinka.TabIndex = 1;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(108, 275);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(280, 23);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(105, 58);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(99, 17);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(105, 144);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 4;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // linklblLozinka
            // 
            this.linklblLozinka.AutoSize = true;
            this.linklblLozinka.Location = new System.Drawing.Point(12, 344);
            this.linklblLozinka.Name = "linklblLozinka";
            this.linklblLozinka.Size = new System.Drawing.Size(149, 17);
            this.linklblLozinka.TabIndex = 5;
            this.linklblLozinka.TabStop = true;
            this.linklblLozinka.Text = "Zaboravili ste lozinku?";
            this.linklblLozinka.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLozinka_LinkClicked);
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 370);
            this.Controls.Add(this.linklblLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtIme);
            this.Name = "frmPrijava";
            this.Text = "Prijava - domMyHome";
            this.Load += new System.EventHandler(this.frmPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.LinkLabel linklblLozinka;
    }
}

