namespace domMyHome
{
    partial class frmHome
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
            this.btnSticenici = new System.Windows.Forms.Button();
            this.btnDjelatnici = new System.Windows.Forms.Button();
            this.btnPregledSoba = new System.Windows.Forms.Button();
            this.btnUredjenjeSoba = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSticenici
            // 
            this.btnSticenici.Location = new System.Drawing.Point(79, 40);
            this.btnSticenici.Name = "btnSticenici";
            this.btnSticenici.Size = new System.Drawing.Size(392, 90);
            this.btnSticenici.TabIndex = 0;
            this.btnSticenici.Text = "Rad sa korisnicima";
            this.btnSticenici.UseVisualStyleBackColor = true;
            // 
            // btnDjelatnici
            // 
            this.btnDjelatnici.Location = new System.Drawing.Point(79, 155);
            this.btnDjelatnici.Name = "btnDjelatnici";
            this.btnDjelatnici.Size = new System.Drawing.Size(392, 90);
            this.btnDjelatnici.TabIndex = 1;
            this.btnDjelatnici.Text = "Rad s djelatnicima";
            this.btnDjelatnici.UseVisualStyleBackColor = true;
            this.btnDjelatnici.Click += new System.EventHandler(this.btnDjelatnici_Click);
            // 
            // btnPregledSoba
            // 
            this.btnPregledSoba.Location = new System.Drawing.Point(79, 272);
            this.btnPregledSoba.Name = "btnPregledSoba";
            this.btnPregledSoba.Size = new System.Drawing.Size(392, 90);
            this.btnPregledSoba.TabIndex = 2;
            this.btnPregledSoba.Text = "Pregled soba";
            this.btnPregledSoba.UseVisualStyleBackColor = true;
            this.btnPregledSoba.Click += new System.EventHandler(this.btnPregledSoba_Click);
            // 
            // btnUredjenjeSoba
            // 
            this.btnUredjenjeSoba.Location = new System.Drawing.Point(79, 386);
            this.btnUredjenjeSoba.Name = "btnUredjenjeSoba";
            this.btnUredjenjeSoba.Size = new System.Drawing.Size(392, 90);
            this.btnUredjenjeSoba.TabIndex = 3;
            this.btnUredjenjeSoba.Text = "Uređenje soba i odjela";
            this.btnUredjenjeSoba.UseVisualStyleBackColor = true;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(79, 498);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(392, 90);
            this.btnRegistracija.TabIndex = 4;
            this.btnRegistracija.Text = "Registracija novog djelatnika";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 623);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnUredjenjeSoba);
            this.Controls.Add(this.btnPregledSoba);
            this.Controls.Add(this.btnDjelatnici);
            this.Controls.Add(this.btnSticenici);
            this.Name = "frmHome";
            this.Text = "Početna - domMyHome";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSticenici;
        private System.Windows.Forms.Button btnDjelatnici;
        private System.Windows.Forms.Button btnPregledSoba;
        private System.Windows.Forms.Button btnUredjenjeSoba;
        private System.Windows.Forms.Button btnRegistracija;
    }
}