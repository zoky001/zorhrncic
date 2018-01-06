namespace RSA
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.text_RSA_PRIVATE = new System.Windows.Forms.RichTextBox();
            this.text_RSA_public = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.textBoxDecripted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCrypted = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_3DES = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxVector = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxCrypt3DES = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDECRIPY3DES = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(65, 66);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(195, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Keys";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // text_RSA_PRIVATE
            // 
            this.text_RSA_PRIVATE.Location = new System.Drawing.Point(55, 207);
            this.text_RSA_PRIVATE.Name = "text_RSA_PRIVATE";
            this.text_RSA_PRIVATE.Size = new System.Drawing.Size(283, 220);
            this.text_RSA_PRIVATE.TabIndex = 1;
            this.text_RSA_PRIVATE.Text = "";
            // 
            // text_RSA_public
            // 
            this.text_RSA_public.Location = new System.Drawing.Point(371, 207);
            this.text_RSA_public.Name = "text_RSA_public";
            this.text_RSA_public.Size = new System.Drawing.Size(301, 220);
            this.text_RSA_public.TabIndex = 2;
            this.text_RSA_public.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Public Key";
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(55, 457);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(617, 22);
            this.textBoxEnter.TabIndex = 5;
            // 
            // textBoxDecripted
            // 
            this.textBoxDecripted.Location = new System.Drawing.Point(52, 512);
            this.textBoxDecripted.Name = "textBoxDecripted";
            this.textBoxDecripted.Size = new System.Drawing.Size(617, 22);
            this.textBoxDecripted.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crypted  text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Decrypted  text";
            // 
            // textBoxCrypted
            // 
            this.textBoxCrypted.Location = new System.Drawing.Point(52, 568);
            this.textBoxCrypted.Name = "textBoxCrypted";
            this.textBoxCrypted.Size = new System.Drawing.Size(617, 141);
            this.textBoxCrypted.TabIndex = 11;
            this.textBoxCrypted.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "3DES key";
            // 
            // richTextBox_3DES
            // 
            this.richTextBox_3DES.Location = new System.Drawing.Point(730, 207);
            this.richTextBox_3DES.Name = "richTextBox_3DES";
            this.richTextBox_3DES.Size = new System.Drawing.Size(258, 114);
            this.richTextBox_3DES.TabIndex = 13;
            this.richTextBox_3DES.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "3DES vector";
            // 
            // richTextBoxVector
            // 
            this.richTextBoxVector.Location = new System.Drawing.Point(730, 365);
            this.richTextBoxVector.Name = "richTextBoxVector";
            this.richTextBoxVector.Size = new System.Drawing.Size(258, 114);
            this.richTextBoxVector.TabIndex = 15;
            this.richTextBoxVector.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(727, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Crypted  text";
            // 
            // richTextBoxCrypt3DES
            // 
            this.richTextBoxCrypt3DES.Location = new System.Drawing.Point(730, 532);
            this.richTextBoxCrypt3DES.Name = "richTextBoxCrypt3DES";
            this.richTextBoxCrypt3DES.Size = new System.Drawing.Size(467, 81);
            this.richTextBoxCrypt3DES.TabIndex = 17;
            this.richTextBoxCrypt3DES.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(727, 631);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Decrypted  text";
            // 
            // textBoxDECRIPY3DES
            // 
            this.textBoxDECRIPY3DES.Location = new System.Drawing.Point(730, 661);
            this.textBoxDECRIPY3DES.Name = "textBoxDECRIPY3DES";
            this.textBoxDECRIPY3DES.Size = new System.Drawing.Size(467, 22);
            this.textBoxDECRIPY3DES.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 738);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxDECRIPY3DES);
            this.Controls.Add(this.richTextBoxCrypt3DES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxVector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox_3DES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCrypted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDecripted);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_RSA_public);
            this.Controls.Add(this.text_RSA_PRIVATE);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox text_RSA_PRIVATE;
        private System.Windows.Forms.RichTextBox text_RSA_public;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.TextBox textBoxDecripted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textBoxCrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_3DES;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxVector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxCrypt3DES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDECRIPY3DES;
    }
}

