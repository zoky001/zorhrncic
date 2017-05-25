using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recept
{
    public partial class FrmRecept : Form
    {
        public FrmRecept()
        {
            InitializeComponent();
        }

        public void OsvjeziRecepte()
        {
            List<Recept> listaRecepta = Recept.DohvatiRecepte(txtKljucnaRijec.Text);
            dgvRecepti.DataSource = listaRecepta;
        }

        public void OsvjeziArtikle(int receptId)
        {
            List<Artikl> listaArtikla = Artikl.DohvatiArtikle(receptId);
            dgvArtikli.DataSource = listaArtikla;
        }

        private void btnLoadRecepte_Click(object sender, EventArgs e)
        {
            OsvjeziRecepte();
        }

        private void dgvRecepti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count > 0)
            {
                Recept recept = dgvRecepti.SelectedRows[0].DataBoundItem as Recept;
                OsvjeziArtikle(recept.Id);
            }
        }
    }
}
