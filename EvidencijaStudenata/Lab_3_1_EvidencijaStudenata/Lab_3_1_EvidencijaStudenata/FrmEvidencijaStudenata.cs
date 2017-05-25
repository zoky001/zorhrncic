using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_1_EvidencijaStudenata
{
    public partial class FrmEvidencijaStudenata : Form
    {
        public FrmEvidencijaStudenata()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje klikom na gumb za Izlaz iz programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Rukuje događajem klika na Popis studenata u izborniku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popisStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPopisStudenata popisStudenata = new FrmPopisStudenata();
            popisStudenata.WindowState = FormWindowState.Maximized;
            popisStudenata.MdiParent = this;
            popisStudenata.Show();
        }
    }
}
