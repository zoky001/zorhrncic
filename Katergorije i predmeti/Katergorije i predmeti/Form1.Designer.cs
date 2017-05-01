namespace Katergorije_i_predmeti
{
    partial class Form1
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
            this.listBoxKategorije = new System.Windows.Forms.ListBox();
            this.listBoxPredmeti = new System.Windows.Forms.ListBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxECTS = new System.Windows.Forms.TextBox();
            this.butDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxUpisani = new System.Windows.Forms.ListBox();
            this.popisUpisanih = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxKategorije
            // 
            this.listBoxKategorije.FormattingEnabled = true;
            this.listBoxKategorije.ItemHeight = 16;
            this.listBoxKategorije.Location = new System.Drawing.Point(12, 57);
            this.listBoxKategorije.Name = "listBoxKategorije";
            this.listBoxKategorije.Size = new System.Drawing.Size(247, 180);
            this.listBoxKategorije.TabIndex = 0;
            this.listBoxKategorije.SelectedIndexChanged += new System.EventHandler(this.listBoxKategorije_SelectedIndexChanged);
            // 
            // listBoxPredmeti
            // 
            this.listBoxPredmeti.FormattingEnabled = true;
            this.listBoxPredmeti.ItemHeight = 16;
            this.listBoxPredmeti.Location = new System.Drawing.Point(296, 57);
            this.listBoxPredmeti.Name = "listBoxPredmeti";
            this.listBoxPredmeti.Size = new System.Drawing.Size(256, 180);
            this.listBoxPredmeti.TabIndex = 1;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(728, 72);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(178, 22);
            this.textBoxNaziv.TabIndex = 2;
            // 
            // textBoxECTS
            // 
            this.textBoxECTS.Location = new System.Drawing.Point(728, 112);
            this.textBoxECTS.Name = "textBoxECTS";
            this.textBoxECTS.Size = new System.Drawing.Size(174, 22);
            this.textBoxECTS.TabIndex = 3;
            // 
            // butDodaj
            // 
            this.butDodaj.Location = new System.Drawing.Point(728, 154);
            this.butDodaj.Name = "butDodaj";
            this.butDodaj.Size = new System.Drawing.Size(178, 23);
            this.butDodaj.TabIndex = 4;
            this.butDodaj.Text = "dodaj";
            this.butDodaj.UseVisualStyleBackColor = true;
            this.butDodaj.Click += new System.EventHandler(this.butDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategorije";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRedmeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Naziv predmeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Broj ECTS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upiši odabrani predmet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxUpisani
            // 
            this.listBoxUpisani.FormattingEnabled = true;
            this.listBoxUpisani.ItemHeight = 16;
            this.listBoxUpisani.Location = new System.Drawing.Point(12, 295);
            this.listBoxUpisani.Name = "listBoxUpisani";
            this.listBoxUpisani.Size = new System.Drawing.Size(247, 148);
            this.listBoxUpisani.TabIndex = 10;
            // 
            // popisUpisanih
            // 
            this.popisUpisanih.FormattingEnabled = true;
            this.popisUpisanih.ItemHeight = 16;
            this.popisUpisanih.Location = new System.Drawing.Point(296, 295);
            this.popisUpisanih.Name = "popisUpisanih";
            this.popisUpisanih.Size = new System.Drawing.Size(329, 132);
            this.popisUpisanih.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 455);
            this.Controls.Add(this.popisUpisanih);
            this.Controls.Add(this.listBoxUpisani);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDodaj);
            this.Controls.Add(this.textBoxECTS);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.listBoxPredmeti);
            this.Controls.Add(this.listBoxKategorije);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKategorije;
        private System.Windows.Forms.ListBox listBoxPredmeti;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxECTS;
        private System.Windows.Forms.Button butDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxUpisani;
        private System.Windows.Forms.ListBox popisUpisanih;
    }
}

