using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATASet.DataBrowseForms
{
    public partial class frmBrowseOrders : Form
    {
        public frmBrowseOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.ordersBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void frmBrowseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            //    this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwndDataSet.Orders);

        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.RowCount > 0)
            {
                int orderID = int.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.order_DetailsTableAdapter.FillByOrderID(this.northwndDataSet.Order_Details, orderID);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Želite li bristi??", "Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //delete order details
                for (int i = 0; i < order_DetailsDataGridView.Rows.Count; i++)
                {
                    order_DetailsDataGridView.Rows.RemoveAt(i);

                }

                ordersDataGridView.Rows.RemoveAt(ordersDataGridView.CurrentRow.Index);


            }

        }

        private void ordersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataCreateForms.frmCreateOrder frmOrder = new DataCreateForms.frmCreateOrder();
            frmOrder.ShowDialog(); //ne dozvoljava gokus drugoj kontorli
        }
    }
}
