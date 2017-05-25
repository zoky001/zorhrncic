namespace DATASet
{
    partial class frmMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataBrowseOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.miProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.miCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.miSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(282, 28);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataBrowse});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(181, 26);
            this.miExit.Text = "Exit";
            // 
            // miDataBrowse
            // 
            this.miDataBrowse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDataBrowseOrders,
            this.miProducts,
            this.miCategories,
            this.miSuppliers});
            this.miDataBrowse.Name = "miDataBrowse";
            this.miDataBrowse.Size = new System.Drawing.Size(181, 26);
            this.miDataBrowse.Text = "Browse";
            // 
            // miDataBrowseOrders
            // 
            this.miDataBrowseOrders.Name = "miDataBrowseOrders";
            this.miDataBrowseOrders.Size = new System.Drawing.Size(181, 26);
            this.miDataBrowseOrders.Text = "Orders";
            this.miDataBrowseOrders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miDataBrowseOrders_MouseUp);
            // 
            // miProducts
            // 
            this.miProducts.Name = "miProducts";
            this.miProducts.Size = new System.Drawing.Size(181, 26);
            this.miProducts.Text = "Products";
            // 
            // miCategories
            // 
            this.miCategories.Name = "miCategories";
            this.miCategories.Size = new System.Drawing.Size(181, 26);
            this.miCategories.Text = "Categories";
            // 
            // miSuppliers
            // 
            this.miSuppliers.Name = "miSuppliers";
            this.miSuppliers.Size = new System.Drawing.Size(181, 26);
            this.miSuppliers.Text = "Suppliers";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACME d.o.o.";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowse;
        private System.Windows.Forms.ToolStripMenuItem miDataBrowseOrders;
        private System.Windows.Forms.ToolStripMenuItem miProducts;
        private System.Windows.Forms.ToolStripMenuItem miCategories;
        private System.Windows.Forms.ToolStripMenuItem miSuppliers;
    }
}

