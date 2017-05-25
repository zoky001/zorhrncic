using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATASet.DataCreateForms
{
    public partial class frmCreateOrder : Form
    {
        public frmCreateOrder()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Customers' table. You can move, or remove it, as needed.
        //  this.employeeesTableAdapter.Fill(this.northwndDataSet.Employees);

            this.customersTableAdapter.Fill(this.northwndDataSet.Customers);

            ordersBindingSource.AddNew();
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
           // this.order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Orders' table. You can move, or remove it, as needed.
           // this.ordersTableAdapter.Fill(this.northwndDataSet.Orders);
            // TODO: This line of code loads data into the 'northwndDataSet.Orders' table. You can move, or remove it, as needed.
           // this.ordersTableAdapter.Fill(this.northwndDataSet.Orders);

        }

        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void btnAddDetails_MouseUp(object sender, MouseEventArgs e)
        {
            createNewEntry();
            int OrderID = (int)northwndDataSet.Orders.Rows[0]["OrderID"];
            //  frmCreateDetails frmCreateDetails = new frmCreateDetails(OrderID);
            //if (Editing) frmCreateDetails.Editing = true;
            //frmCreateDetails.ShowDialog();
        }

        private void btnCreate_MouseUp(object sender, MouseEventArgs e)
        {
            createNewEntry();
        }
        private void createNewEntry() {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);



        }

        private void btnClear_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
