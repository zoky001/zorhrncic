namespace ZapisivanjeLog
{
    partial class frmIzrcun
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
            this.lblPrviBroj = new System.Windows.Forms.Label();
            this.lblDrugiBroj = new System.Windows.Forms.Label();
            this.txtPrviBroj = new System.Windows.Forms.TextBox();
            this.txtDrugiBroj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.butIzracunaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrviBroj
            // 
            this.lblPrviBroj.AutoSize = true;
            this.lblPrviBroj.Location = new System.Drawing.Point(45, 45);
            this.lblPrviBroj.Name = "lblPrviBroj";
            this.lblPrviBroj.Size = new System.Drawing.Size(60, 17);
            this.lblPrviBroj.TabIndex = 0;
            this.lblPrviBroj.Text = "Prvi broj";
            // 
            // lblDrugiBroj
            // 
            this.lblDrugiBroj.AutoSize = true;
            this.lblDrugiBroj.Location = new System.Drawing.Point(45, 95);
            this.lblDrugiBroj.Name = "lblDrugiBroj";
            this.lblDrugiBroj.Size = new System.Drawing.Size(70, 17);
            this.lblDrugiBroj.TabIndex = 1;
            this.lblDrugiBroj.Text = "Drugi broj";
            // 
            // txtPrviBroj
            // 
            this.txtPrviBroj.Location = new System.Drawing.Point(139, 42);
            this.txtPrviBroj.Name = "txtPrviBroj";
            this.txtPrviBroj.Size = new System.Drawing.Size(100, 22);
            this.txtPrviBroj.TabIndex = 2;
            // 
            // txtDrugiBroj
            // 
            this.txtDrugiBroj.Location = new System.Drawing.Point(139, 95);
            this.txtDrugiBroj.Name = "txtDrugiBroj";
            this.txtDrugiBroj.Size = new System.Drawing.Size(100, 22);
            this.txtDrugiBroj.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.log);
            this.groupBox1.Location = new System.Drawing.Point(312, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 266);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(24, 21);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(334, 220);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(12, 284);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // butIzracunaj
            // 
            this.butIzracunaj.Location = new System.Drawing.Point(231, 284);
            this.butIzracunaj.Name = "butIzracunaj";
            this.butIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.butIzracunaj.TabIndex = 6;
            this.butIzracunaj.Text = "Izracunaj";
            this.butIzracunaj.UseVisualStyleBackColor = true;
            this.butIzracunaj.Click += new System.EventHandler(this.butIzracunaj_Click);
            // 
            // frmIzrcun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 339);
            this.Controls.Add(this.butIzracunaj);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDrugiBroj);
            this.Controls.Add(this.txtPrviBroj);
            this.Controls.Add(this.lblDrugiBroj);
            this.Controls.Add(this.lblPrviBroj);
            this.Name = "frmIzrcun";
            this.Text = "Izracun";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrviBroj;
        private System.Windows.Forms.Label lblDrugiBroj;
        private System.Windows.Forms.TextBox txtPrviBroj;
        private System.Windows.Forms.TextBox txtDrugiBroj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button butIzracunaj;


      

      


    }
}

