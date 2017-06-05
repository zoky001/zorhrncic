namespace Lab_3_1_EvidencijaStudenata
{
    partial class FrmEvidencijaStudenata
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisStudenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kataloziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviAktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacijaToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.kataloziToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(916, 28);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisStudenataToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // popisStudenataToolStripMenuItem
            // 
            this.popisStudenataToolStripMenuItem.Name = "popisStudenataToolStripMenuItem";
            this.popisStudenataToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.popisStudenataToolStripMenuItem.Text = "Popis studenata";
            this.popisStudenataToolStripMenuItem.Click += new System.EventHandler(this.popisStudenataToolStripMenuItem_Click);
            // 
            // kataloziToolStripMenuItem
            // 
            this.kataloziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoviAktivnostiToolStripMenuItem,
            this.aktivnostiToolStripMenuItem});
            this.kataloziToolStripMenuItem.Name = "kataloziToolStripMenuItem";
            this.kataloziToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.kataloziToolStripMenuItem.Text = "Katalozi";
            // 
            // tipoviAktivnostiToolStripMenuItem
            // 
            this.tipoviAktivnostiToolStripMenuItem.Name = "tipoviAktivnostiToolStripMenuItem";
            this.tipoviAktivnostiToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.tipoviAktivnostiToolStripMenuItem.Text = "Tipovi aktivnosti";
            // 
            // aktivnostiToolStripMenuItem
            // 
            this.aktivnostiToolStripMenuItem.Name = "aktivnostiToolStripMenuItem";
            this.aktivnostiToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.aktivnostiToolStripMenuItem.Text = "Aktivnosti";
            // 
            // FrmEvidencijaStudenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 474);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEvidencijaStudenata";
            this.Text = "Evidencija studenata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisStudenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kataloziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviAktivnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivnostiToolStripMenuItem;
    }
}

