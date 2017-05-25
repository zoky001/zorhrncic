namespace Lab_3_1_EvidencijaStudenata
{
    partial class FrmPopisStudenata
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnObrisiTim = new System.Windows.Forms.Button();
            this.btnIzmijeniTim = new System.Windows.Forms.Button();
            this.btnNoviTim = new System.Windows.Forms.Button();
            this.lblTimovi = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnIzmijeniStudenta = new System.Windows.Forms.Button();
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaTimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivProjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisProjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odabraniModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostStudentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brnbrisitim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.brnbrisitim);
            this.splitContainer.Panel1.Controls.Add(this.button3);
            this.splitContainer.Panel1.Controls.Add(this.button1);
            this.splitContainer.Panel1.Controls.Add(this.btnObrisiTim);
            this.splitContainer.Panel1.Controls.Add(this.btnIzmijeniTim);
            this.splitContainer.Panel1.Controls.Add(this.lblTimovi);
            this.splitContainer.Panel1.Controls.Add(this.dgvTimovi);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel1_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.button2);
            this.splitContainer.Panel2.Controls.Add(this.btnObrisiStudenta);
            this.splitContainer.Panel2.Controls.Add(this.btnIzmijeniStudenta);
            this.splitContainer.Panel2.Controls.Add(this.btnNoviStudent);
            this.splitContainer.Panel2.Controls.Add(this.lblStudenti);
            this.splitContainer.Panel2.Controls.Add(this.dgvStudenti);
            this.splitContainer.Size = new System.Drawing.Size(1185, 597);
            this.splitContainer.SplitterDistance = 281;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiTim.Location = new System.Drawing.Point(1072, 238);
            this.btnObrisiTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(100, 28);
            this.btnObrisiTim.TabIndex = 4;
            this.btnObrisiTim.Text = "Obriši";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniTim
            // 
            this.btnIzmijeniTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniTim.Location = new System.Drawing.Point(885, 226);
            this.btnIzmijeniTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmijeniTim.Name = "btnIzmijeniTim";
            this.btnIzmijeniTim.Size = new System.Drawing.Size(100, 28);
            this.btnIzmijeniTim.TabIndex = 3;
            this.btnIzmijeniTim.Text = "Izmijeni";
            this.btnIzmijeniTim.UseVisualStyleBackColor = true;
            // 
            // btnNoviTim
            // 
            this.btnNoviTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviTim.Location = new System.Drawing.Point(847, 238);
            this.btnNoviTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoviTim.Name = "btnNoviTim";
            this.btnNoviTim.Size = new System.Drawing.Size(100, 28);
            this.btnNoviTim.TabIndex = 2;
            this.btnNoviTim.Text = "Novi";
            this.btnNoviTim.UseVisualStyleBackColor = true;
            this.btnNoviTim.Click += new System.EventHandler(this.btnNoviTim_Click);
            // 
            // lblTimovi
            // 
            this.lblTimovi.AutoSize = true;
            this.lblTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimovi.Location = new System.Drawing.Point(16, 11);
            this.lblTimovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimovi.Name = "lblTimovi";
            this.lblTimovi.Size = new System.Drawing.Size(60, 17);
            this.lblTimovi.TabIndex = 1;
            this.lblTimovi.Text = "Timovi:";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimovi.AutoGenerateColumns = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.oznakaTimaDataGridViewTextBoxColumn,
            this.nazivProjektaDataGridViewTextBoxColumn,
            this.opisProjektaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn});
            this.dgvTimovi.DataSource = this.timBindingSource;
            this.dgvTimovi.Location = new System.Drawing.Point(20, 31);
            this.dgvTimovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTimovi.MultiSelect = false;
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(328, 124);
            this.dgvTimovi.TabIndex = 0;
            this.dgvTimovi.SelectionChanged += new System.EventHandler(this.dgvTimovi_SelectionChanged);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiStudenta.Location = new System.Drawing.Point(1072, 268);
            this.btnObrisiStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(100, 28);
            this.btnObrisiStudenta.TabIndex = 9;
            this.btnObrisiStudenta.Text = "Obriši";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniStudenta
            // 
            this.btnIzmijeniStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniStudenta.Location = new System.Drawing.Point(964, 268);
            this.btnIzmijeniStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmijeniStudenta.Name = "btnIzmijeniStudenta";
            this.btnIzmijeniStudenta.Size = new System.Drawing.Size(100, 28);
            this.btnIzmijeniStudenta.TabIndex = 8;
            this.btnIzmijeniStudenta.Text = "Izmijeni";
            this.btnIzmijeniStudenta.UseVisualStyleBackColor = true;
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviStudent.Location = new System.Drawing.Point(856, 268);
            this.btnNoviStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(100, 28);
            this.btnNoviStudent.TabIndex = 7;
            this.btnNoviStudent.Text = "Novi";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.btnNoviStudent_Click);
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudenti.Location = new System.Drawing.Point(16, 12);
            this.lblStudenti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(73, 17);
            this.lblStudenti.TabIndex = 6;
            this.lblStudenti.Text = "Studenti:";
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudenti.AutoGenerateColumns = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.odabraniModelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn1,
            this.timIdDataGridViewTextBoxColumn,
            this.aktivnostStudentaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn});
            this.dgvStudenti.DataSource = this.studentBindingSource;
            this.dgvStudenti.Location = new System.Drawing.Point(23, 51);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudenti.MultiSelect = false;
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(364, 122);
            this.dgvStudenti.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "novi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "izmjeni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // oznakaTimaDataGridViewTextBoxColumn
            // 
            this.oznakaTimaDataGridViewTextBoxColumn.DataPropertyName = "OznakaTima";
            this.oznakaTimaDataGridViewTextBoxColumn.HeaderText = "OznakaTima";
            this.oznakaTimaDataGridViewTextBoxColumn.Name = "oznakaTimaDataGridViewTextBoxColumn";
            // 
            // nazivProjektaDataGridViewTextBoxColumn
            // 
            this.nazivProjektaDataGridViewTextBoxColumn.DataPropertyName = "NazivProjekta";
            this.nazivProjektaDataGridViewTextBoxColumn.HeaderText = "NazivProjekta";
            this.nazivProjektaDataGridViewTextBoxColumn.Name = "nazivProjektaDataGridViewTextBoxColumn";
            // 
            // opisProjektaDataGridViewTextBoxColumn
            // 
            this.opisProjektaDataGridViewTextBoxColumn.DataPropertyName = "OpisProjekta";
            this.opisProjektaDataGridViewTextBoxColumn.HeaderText = "OpisProjekta";
            this.opisProjektaDataGridViewTextBoxColumn.Name = "opisProjektaDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Visible = false;
            // 
            // timBindingSource
            // 
            this.timBindingSource.DataSource = typeof(Lab_3_1_EvidencijaStudenata.Tim);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // odabraniModelDataGridViewTextBoxColumn
            // 
            this.odabraniModelDataGridViewTextBoxColumn.DataPropertyName = "OdabraniModel";
            this.odabraniModelDataGridViewTextBoxColumn.HeaderText = "OdabraniModel";
            this.odabraniModelDataGridViewTextBoxColumn.Name = "odabraniModelDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn1
            // 
            this.napomenaDataGridViewTextBoxColumn1.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.Name = "napomenaDataGridViewTextBoxColumn1";
            // 
            // timIdDataGridViewTextBoxColumn
            // 
            this.timIdDataGridViewTextBoxColumn.DataPropertyName = "TimId";
            this.timIdDataGridViewTextBoxColumn.HeaderText = "TimId";
            this.timIdDataGridViewTextBoxColumn.Name = "timIdDataGridViewTextBoxColumn";
            this.timIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktivnostStudentaDataGridViewTextBoxColumn
            // 
            this.aktivnostStudentaDataGridViewTextBoxColumn.DataPropertyName = "AktivnostStudenta";
            this.aktivnostStudentaDataGridViewTextBoxColumn.HeaderText = "AktivnostStudenta";
            this.aktivnostStudentaDataGridViewTextBoxColumn.Name = "aktivnostStudentaDataGridViewTextBoxColumn";
            this.aktivnostStudentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // timDataGridViewTextBoxColumn
            // 
            this.timDataGridViewTextBoxColumn.DataPropertyName = "Tim";
            this.timDataGridViewTextBoxColumn.HeaderText = "Tim";
            this.timDataGridViewTextBoxColumn.Name = "timDataGridViewTextBoxColumn";
            this.timDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Lab_3_1_EvidencijaStudenata.Student);
            // 
            // brnbrisitim
            // 
            this.brnbrisitim.Location = new System.Drawing.Point(789, 91);
            this.brnbrisitim.Name = "brnbrisitim";
            this.brnbrisitim.Size = new System.Drawing.Size(75, 23);
            this.brnbrisitim.TabIndex = 7;
            this.brnbrisitim.Text = "obrisi";
            this.brnbrisitim.UseVisualStyleBackColor = true;
            this.brnbrisitim.Click += new System.EventHandler(this.brnbrisitim_Click);
            // 
            // FrmPopisStudenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 597);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnNoviTim);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPopisStudenata";
            this.Text = "Popis studenata";
            this.Load += new System.EventHandler(this.FrmPopisStudenata_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnObrisiTim;
        private System.Windows.Forms.Button btnIzmijeniTim;
        private System.Windows.Forms.Button btnNoviTim;
        private System.Windows.Forms.Label lblTimovi;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnIzmijeniStudenta;
        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaTimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisProjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odabraniModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivnostStudentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button brnbrisitim;
    }
}