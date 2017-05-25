using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            OsvjeziTimove();
        }


        private void OsvjeziTimove() {
            List<Tim> listaTimova = Tim.DohvatiTimove();

            dgvTimovi.DataSource = listaTimova;

        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            NoviTim frmNoviTim = new NoviTim();
            frmNoviTim.ShowDialog();
            OsvjeziTimove();
        }

        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                NoviTim frmNoviTim = new NoviTim(odabraniTim);
                frmNoviTim.ShowDialog();
                
            }
            OsvjeziTimove();

        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTimovi.SelectedRows)
                {
                    Tim odabraniTim = row.DataBoundItem as Tim;
                    odabraniTim.Obrisi();
                }
            }
            OsvjeziTimove();
        }

        private void dgvTimovi_CellContentClick(object sender, DataGridViewCellEventArgs e)



        {/* MessageBox.Show("click na dgv");
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;

                List<Student> lista = Student.DohvatiStudenteTima(odabraniTim.Id);

                dgvStudenti.DataSource = lista;

                
            }

            */

        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
            NoviStudent frmNoviTim = new NoviStudent(odabraniTim.Id);
            frmNoviTim.ShowDialog();
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.SelectedRows.Count > 0)
            {
                Student s = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                Student.Obrisi(s.Id);

            }
        }

        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;

                List<Student> lista = Student.DohvatiStudenteTima(odabraniTim.Id);

                dgvStudenti.DataSource = lista;


            }
        }
    }
}
