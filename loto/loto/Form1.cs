using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class Lotto : Form
    {
        private Loto loto;
        public Lotto()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<String> vrijednosti = new List<string>();
            vrijednosti.Add(textBox1.Text);
            vrijednosti.Add(textBox2.Text);
            vrijednosti.Add(textBox3.Text);
            vrijednosti.Add(textBox4.Text);
            vrijednosti.Add(textBox5.Text);
            vrijednosti.Add(textBox6.Text);
            vrijednosti.Add(textBox7.Text);

            bool ispravnakombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnakombinacija == true)
            {
                btnOdigraj.Enabled = true;

            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Kombinacija  uplačenih bojrva nije ispravna!!");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();

            textBox8.Text = loto.DobitniBrojevi[0].ToString();
            textBox9.Text = loto.DobitniBrojevi[1].ToString();
            textBox10.Text = loto.DobitniBrojevi[2].ToString();
            textBox11.Text = loto.DobitniBrojevi[3].ToString();
            textBox12.Text = loto.DobitniBrojevi[4].ToString();
            textBox13.Text = loto.DobitniBrojevi[5].ToString();
            textBox14.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunBrojaPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();
        }
    }
}
