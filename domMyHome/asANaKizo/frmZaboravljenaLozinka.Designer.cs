namespace domMyHome
{
    partial class frmZaboravljenaLozinka
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
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.lblTajnoPitanje = new System.Windows.Forms.Label();
            this.lblOdgovor = new System.Windows.Forms.Label();
            this.lblNLozinka = new System.Windows.Forms.Label();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka2 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.btnPotvrdaOdgovora = new System.Windows.Forms.Button();
            this.btnPromjenaLozinke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(17, 109);
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.Size = new System.Drawing.Size(517, 22);
            this.txtOdgovor.TabIndex = 2;
            // 
            // lblTajnoPitanje
            // 
            this.lblTajnoPitanje.AutoSize = true;
            this.lblTajnoPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTajnoPitanje.Location = new System.Drawing.Point(12, 23);
            this.lblTajnoPitanje.Name = "lblTajnoPitanje";
            this.lblTajnoPitanje.Size = new System.Drawing.Size(383, 29);
            this.lblTajnoPitanje.TabIndex = 4;
            this.lblTajnoPitanje.Text = "Navedite prezime vaše majke:";
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.Location = new System.Drawing.Point(19, 86);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(168, 17);
            this.lblOdgovor.TabIndex = 5;
            this.lblOdgovor.Text = "Odgovor na tajno pitanje:";
            // 
            // lblNLozinka
            // 
            this.lblNLozinka.AutoSize = true;
            this.lblNLozinka.Location = new System.Drawing.Point(14, 188);
            this.lblNLozinka.Name = "lblNLozinka";
            this.lblNLozinka.Size = new System.Drawing.Size(93, 17);
            this.lblNLozinka.TabIndex = 7;
            this.lblNLozinka.Text = "Nova lozinka:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Enabled = false;
            this.txtNovaLozinka.Location = new System.Drawing.Point(122, 183);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.Size = new System.Drawing.Size(179, 22);
            this.txtNovaLozinka.TabIndex = 6;
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.Location = new System.Drawing.Point(14, 216);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(103, 17);
            this.lblLozinka2.TabIndex = 9;
            this.lblLozinka2.Text = "Ponovi lozinku:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Enabled = false;
            this.txtLozinka2.Location = new System.Drawing.Point(122, 211);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(179, 22);
            this.txtLozinka2.TabIndex = 8;
            // 
            // btnPotvrdaOdgovora
            // 
            this.btnPotvrdaOdgovora.Location = new System.Drawing.Point(17, 137);
            this.btnPotvrdaOdgovora.Name = "btnPotvrdaOdgovora";
            this.btnPotvrdaOdgovora.Size = new System.Drawing.Size(170, 23);
            this.btnPotvrdaOdgovora.TabIndex = 10;
            this.btnPotvrdaOdgovora.Text = "Potvrdi odgovor";
            this.btnPotvrdaOdgovora.UseVisualStyleBackColor = true;
            this.btnPotvrdaOdgovora.Click += new System.EventHandler(this.btnPotvrdaOdgovora_Click);
            // 
            // btnPromjenaLozinke
            // 
            this.btnPromjenaLozinke.Enabled = false;
            this.btnPromjenaLozinke.Location = new System.Drawing.Point(19, 262);
            this.btnPromjenaLozinke.Name = "btnPromjenaLozinke";
            this.btnPromjenaLozinke.Size = new System.Drawing.Size(514, 32);
            this.btnPromjenaLozinke.TabIndex = 11;
            this.btnPromjenaLozinke.Text = "Promjeni lozinku";
            this.btnPromjenaLozinke.UseVisualStyleBackColor = true;
            this.btnPromjenaLozinke.Click += new System.EventHandler(this.btnPromjenaLozinke_Click);
            // 
            // frmZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 339);
            this.Controls.Add(this.btnPromjenaLozinke);
            this.Controls.Add(this.btnPotvrdaOdgovora);
            this.Controls.Add(this.lblLozinka2);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.lblNLozinka);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.lblTajnoPitanje);
            this.Controls.Add(this.txtOdgovor);
            this.Name = "frmZaboravljenaLozinka";
            this.Text = "Zaboravljena lozinka";
            this.Load += new System.EventHandler(this.frmZaboravljenaLozinka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOdgovor;
        private System.Windows.Forms.Label lblTajnoPitanje;
        private System.Windows.Forms.Label lblOdgovor;
        private System.Windows.Forms.Label lblNLozinka;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.Label lblLozinka2;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Button btnPotvrdaOdgovora;
        private System.Windows.Forms.Button btnPromjenaLozinke;
    }
}