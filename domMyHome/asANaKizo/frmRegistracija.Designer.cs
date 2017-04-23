namespace domMyHome
{
    partial class frmRegistracija
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblRM = new System.Windows.Forms.Label();
            this.comboBoxRM = new System.Windows.Forms.ComboBox();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka2 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.lblOvlasti = new System.Windows.Forms.Label();
            this.comboBoxOvlasti = new System.Windows.Forms.ComboBox();
            this.lblTajnoPitanje = new System.Windows.Forms.Label();
            this.richTxtTajnoPitanje = new System.Windows.Forms.RichTextBox();
            this.lblOdgovor = new System.Windows.Forms.Label();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(120, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(179, 22);
            this.txtIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 34);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 62);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(120, 57);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(179, 22);
            this.txtPrezime.TabIndex = 2;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Location = new System.Drawing.Point(12, 90);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(99, 17);
            this.lblRM.TabIndex = 5;
            this.lblRM.Text = "Radno mjesto:";
            // 
            // comboBoxRM
            // 
            this.comboBoxRM.FormattingEnabled = true;
            this.comboBoxRM.Location = new System.Drawing.Point(120, 90);
            this.comboBoxRM.Name = "comboBoxRM";
            this.comboBoxRM.Size = new System.Drawing.Size(179, 24);
            this.comboBoxRM.TabIndex = 6;
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(12, 120);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(103, 17);
            this.lblKorIme.TabIndex = 8;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(120, 120);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(179, 22);
            this.txtKorIme.TabIndex = 7;
            this.txtKorIme.TextChanged += new System.EventHandler(this.txtKorIme_TextChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(12, 155);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 10;
            this.lblLozinka.Text = "Lozinka:";
            this.lblLozinka.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(120, 152);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(179, 22);
            this.txtLozinka.TabIndex = 9;
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.Location = new System.Drawing.Point(12, 192);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(103, 17);
            this.lblLozinka2.TabIndex = 12;
            this.lblLozinka2.Text = "Ponovi lozinka:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(120, 189);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(179, 22);
            this.txtLozinka2.TabIndex = 11;
            // 
            // lblOvlasti
            // 
            this.lblOvlasti.AutoSize = true;
            this.lblOvlasti.Location = new System.Drawing.Point(12, 220);
            this.lblOvlasti.Name = "lblOvlasti";
            this.lblOvlasti.Size = new System.Drawing.Size(100, 17);
            this.lblOvlasti.TabIndex = 14;
            this.lblOvlasti.Text = "Razina ovlasti:";
            // 
            // comboBoxOvlasti
            // 
            this.comboBoxOvlasti.FormattingEnabled = true;
            this.comboBoxOvlasti.Location = new System.Drawing.Point(120, 220);
            this.comboBoxOvlasti.Name = "comboBoxOvlasti";
            this.comboBoxOvlasti.Size = new System.Drawing.Size(179, 24);
            this.comboBoxOvlasti.TabIndex = 15;
            // 
            // lblTajnoPitanje
            // 
            this.lblTajnoPitanje.AutoSize = true;
            this.lblTajnoPitanje.Location = new System.Drawing.Point(12, 255);
            this.lblTajnoPitanje.Name = "lblTajnoPitanje";
            this.lblTajnoPitanje.Size = new System.Drawing.Size(139, 17);
            this.lblTajnoPitanje.TabIndex = 17;
            this.lblTajnoPitanje.Text = "Postavi tajno pitanje:";
            // 
            // richTxtTajnoPitanje
            // 
            this.richTxtTajnoPitanje.Location = new System.Drawing.Point(157, 255);
            this.richTxtTajnoPitanje.Name = "richTxtTajnoPitanje";
            this.richTxtTajnoPitanje.Size = new System.Drawing.Size(266, 57);
            this.richTxtTajnoPitanje.TabIndex = 18;
            this.richTxtTajnoPitanje.Text = "";
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.Location = new System.Drawing.Point(12, 323);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(67, 17);
            this.lblOdgovor.TabIndex = 20;
            this.lblOdgovor.Text = "Odgovor:";
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(157, 320);
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(179, 22);
            this.txtOdgovor.TabIndex = 19;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(15, 366);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(620, 41);
            this.btnRegistracija.TabIndex = 21;
            this.btnRegistracija.Text = "Registriraj";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 419);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.txtOdgovor);
            this.Controls.Add(this.richTxtTajnoPitanje);
            this.Controls.Add(this.lblTajnoPitanje);
            this.Controls.Add(this.comboBoxOvlasti);
            this.Controls.Add(this.lblOvlasti);
            this.Controls.Add(this.lblLozinka2);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.comboBoxRM);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Name = "frmRegistracija";
            this.Text = "Registracija - domMyHome";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.ComboBox comboBoxRM;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka2;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label lblOvlasti;
        private System.Windows.Forms.ComboBox comboBoxOvlasti;
        private System.Windows.Forms.Label lblTajnoPitanje;
        private System.Windows.Forms.RichTextBox richTxtTajnoPitanje;
        private System.Windows.Forms.Label lblOdgovor;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.Button btnRegistracija;
    }
}