namespace Recept
{
    partial class FrmRecept
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
            this.txtKljucnaRijec = new System.Windows.Forms.TextBox();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnLoadRecepte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ključna riječ:";
            // 
            // txtKljucnaRijec
            // 
            this.txtKljucnaRijec.Location = new System.Drawing.Point(85, 17);
            this.txtKljucnaRijec.Name = "txtKljucnaRijec";
            this.txtKljucnaRijec.Size = new System.Drawing.Size(100, 20);
            this.txtKljucnaRijec.TabIndex = 1;
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(12, 59);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.Size = new System.Drawing.Size(614, 150);
            this.dgvRecepti.TabIndex = 2;
            this.dgvRecepti.SelectionChanged += new System.EventHandler(this.dgvRecepti_SelectionChanged);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 228);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(614, 150);
            this.dgvArtikli.TabIndex = 3;
            // 
            // btnLoadRecepte
            // 
            this.btnLoadRecepte.Location = new System.Drawing.Point(204, 15);
            this.btnLoadRecepte.Name = "btnLoadRecepte";
            this.btnLoadRecepte.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRecepte.TabIndex = 4;
            this.btnLoadRecepte.Text = "Load";
            this.btnLoadRecepte.UseVisualStyleBackColor = true;
            this.btnLoadRecepte.Click += new System.EventHandler(this.btnLoadRecepte_Click);
            // 
            // FrmRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 399);
            this.Controls.Add(this.btnLoadRecepte);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.txtKljucnaRijec);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecept";
            this.Text = "Recepti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKljucnaRijec;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnLoadRecepte;
    }
}

