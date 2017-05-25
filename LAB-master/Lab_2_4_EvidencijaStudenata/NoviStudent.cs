using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class NoviStudent : Form
    {
        private Student student = null;
        public NoviStudent()
        {
            InitializeComponent();
        }

        public NoviStudent(int tim)
        {
            InitializeComponent();

            cmbTim.Items.Add(tim);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                student = new Student();
            }
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.Napomena = txtNapomena.Text;
            student.Email = txtEmail.Text;

            if (rbtnRedoviti.Checked)
            {
                student.Status = 'R';
            }
            else { student.Status = 'I'; }



            if (rbtnModelA.Checked)
            {
                student.OdabraniModel = 'A';
            }
            else { student.OdabraniModel = 'B'; }

            List<Tim> n = Tim.DohvatiTimove();


            foreach (var item in n)
            {
                if (item.Id == int.Parse(cmbTim.SelectedItem.ToString()))
                {
                    student.Tim = item;
                }

            }

             


          

           

            student.Spremi();

            this.Close();





        }
    }
}
