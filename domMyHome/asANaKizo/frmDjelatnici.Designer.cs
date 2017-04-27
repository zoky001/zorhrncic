namespace domMyHome
{
    partial class frmDjelatnici
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtKorisničkoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.lblOdgovor = new System.Windows.Forms.Label();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.richTxtTajnoPitanje = new System.Windows.Forms.RichTextBox();
            this.lblTajnoPitanje = new System.Windows.Forms.Label();
            this.comboBoxOvlasti = new System.Windows.Forms.ComboBox();
            this.lblOvlasti = new System.Windows.Forms.Label();
            this.comboBoxRM = new System.Windows.Forms.ComboBox();
            this.lblRM = new System.Windows.Forms.Label();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(400, 54);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(480, 270);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(7, 17);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 9;
            this.lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(128, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(179, 22);
            this.txtIme.TabIndex = 8;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(7, 54);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 11;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(128, 51);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(179, 22);
            this.txtPrezime.TabIndex = 10;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(7, 92);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(103, 17);
            this.lblKorisnickoIme.TabIndex = 13;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtKorisničkoIme
            // 
            this.txtKorisničkoIme.Location = new System.Drawing.Point(128, 89);
            this.txtKorisničkoIme.Name = "txtKorisničkoIme";
            this.txtKorisničkoIme.Size = new System.Drawing.Size(179, 22);
            this.txtKorisničkoIme.TabIndex = 12;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(7, 131);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(61, 17);
            this.lblLozinka.TabIndex = 15;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(128, 126);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.Size = new System.Drawing.Size(179, 22);
            this.txtNovaLozinka.TabIndex = 14;
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.Location = new System.Drawing.Point(7, 305);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(67, 17);
            this.lblOdgovor.TabIndex = 38;
            this.lblOdgovor.Text = "Odgovor:";
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(128, 302);
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(179, 22);
            this.txtOdgovor.TabIndex = 37;
            this.txtOdgovor.TextChanged += new System.EventHandler(this.txtOdgovor_TextChanged);
            // 
            // richTxtTajnoPitanje
            // 
            this.richTxtTajnoPitanje.Location = new System.Drawing.Point(128, 237);
            this.richTxtTajnoPitanje.Name = "richTxtTajnoPitanje";
            this.richTxtTajnoPitanje.Size = new System.Drawing.Size(230, 57);
            this.richTxtTajnoPitanje.TabIndex = 36;
            this.richTxtTajnoPitanje.Text = "";
            this.richTxtTajnoPitanje.TextChanged += new System.EventHandler(this.richTxtTajnoPitanje_TextChanged);
            // 
            // lblTajnoPitanje
            // 
            this.lblTajnoPitanje.AutoSize = true;
            this.lblTajnoPitanje.Location = new System.Drawing.Point(7, 237);
            this.lblTajnoPitanje.Name = "lblTajnoPitanje";
            this.lblTajnoPitanje.Size = new System.Drawing.Size(94, 17);
            this.lblTajnoPitanje.TabIndex = 35;
            this.lblTajnoPitanje.Text = "Tajno pitanje:";
            // 
            // comboBoxOvlasti
            // 
            this.comboBoxOvlasti.FormattingEnabled = true;
            this.comboBoxOvlasti.Location = new System.Drawing.Point(128, 202);
            this.comboBoxOvlasti.Name = "comboBoxOvlasti";
            this.comboBoxOvlasti.Size = new System.Drawing.Size(179, 24);
            this.comboBoxOvlasti.TabIndex = 34;
            // 
            // lblOvlasti
            // 
            this.lblOvlasti.AutoSize = true;
            this.lblOvlasti.Location = new System.Drawing.Point(7, 202);
            this.lblOvlasti.Name = "lblOvlasti";
            this.lblOvlasti.Size = new System.Drawing.Size(100, 17);
            this.lblOvlasti.TabIndex = 33;
            this.lblOvlasti.Text = "Razina ovlasti:";
            // 
            // comboBoxRM
            // 
            this.comboBoxRM.FormattingEnabled = true;
            this.comboBoxRM.Location = new System.Drawing.Point(128, 164);
            this.comboBoxRM.Name = "comboBoxRM";
            this.comboBoxRM.Size = new System.Drawing.Size(179, 24);
            this.comboBoxRM.TabIndex = 26;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Location = new System.Drawing.Point(7, 164);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(99, 17);
            this.lblRM.TabIndex = 25;
            this.lblRM.Text = "Radno mjesto:";
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(610, 22);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(61, 17);
            this.lblPretrazi.TabIndex = 40;
            this.lblPretrazi.Text = "Pretraži:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(701, 17);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(179, 22);
            this.txtTrazi.TabIndex = 39;
            this.txtTrazi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(10, 352);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(348, 29);
            this.btnIzmjeni.TabIndex = 41;
            this.btnIzmjeni.Text = "Pohrani izmjene";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(10, 387);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(348, 27);
            this.btnObrisi.TabIndex = 42;
            this.btnObrisi.Text = "Obriši korisnika";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(10, 420);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(348, 28);
            this.btnRegistracija.TabIndex = 43;
            this.btnRegistracija.Text = "Registriraj novog korisnika";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // frmDjelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 480);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.txtOdgovor);
            this.Controls.Add(this.richTxtTajnoPitanje);
            this.Controls.Add(this.lblTajnoPitanje);
            this.Controls.Add(this.comboBoxOvlasti);
            this.Controls.Add(this.lblOvlasti);
            this.Controls.Add(this.comboBoxRM);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtKorisničkoIme);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "frmDjelatnici";
            this.Text = "Djelatnici";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDjelatnici_FormClosed);
            this.Load += new System.EventHandler(this.frmDjelatnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtKorisničkoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.Label lblOdgovor;
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.RichTextBox richTxtTajnoPitanje;
        private System.Windows.Forms.Label lblTajnoPitanje;
        private System.Windows.Forms.ComboBox comboBoxOvlasti;
        private System.Windows.Forms.Label lblOvlasti;
        private System.Windows.Forms.ComboBox comboBoxRM;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnRegistracija;
    }
}