using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm f = new ManageCategoriesForm();
            f.ShowDialog();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProductsForm f = new ManageProductsForm();
            f.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome" + " " + Globals.username);
        }

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleInvoiceForm f = new SaleInvoiceForm();
            f.ShowDialog();
        }
    }
}
