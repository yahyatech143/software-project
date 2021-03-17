using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class ManageProductsForm : Form
    {
        public ManageProductsForm()
        {
            InitializeComponent();
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadCategories();
        }

        private void loadProducts()
        {
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "SELECT * FROM product";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
            dgvProducts.Refresh();
        }

        private void loadCategories()
        {
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "SELECT * FROM category WHERE cat_status = 1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxCategory.DataSource = dt;
            cbxCategory.DisplayMember = "cat_name";
            cbxCategory.ValueMember = "cat_id";









        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            String barcode = txtBarcode.Text;
            String name = txtName.Text;
            int purchaseprice = Convert.ToInt32(txtPurchaseprice.Text);
            int salesprice = Convert.ToInt32(txtSalesprice.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int status;
            if(rdoAvailable.Checked)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            int catid = Convert.ToInt32(cbxCategory.SelectedValue.ToString());
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "INSERT INTO product(p_barcode,p_name,purchase_price,sales_price,p_status,cat_id,p_stock) VALUES(@barcode,@name,@purchaseprice,@salesprice,@status,@catid,@stock)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("barcode", barcode));
            cmd.Parameters.Add(new SqlParameter("name", name));
            cmd.Parameters.Add(new SqlParameter("purchaseprice", purchaseprice));
            cmd.Parameters.Add(new SqlParameter("salesprice", salesprice));
            cmd.Parameters.Add(new SqlParameter("status", status));
            cmd.Parameters.Add(new SqlParameter("catid", catid));
            cmd.Parameters.Add(new SqlParameter("stock", stock));
           
            int n = cmd.ExecuteNonQuery();
            con.Close();
            if(n>0)
            {
                loadProducts();
                resetForm();
            }
            else
            {
                MessageBox.Show("Failed to add products");
            }

        }

        private void resetForm()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtPurchaseprice.Clear();
            txtSalesprice.Clear();
            txtStock.Clear();
            cbxCategory.SelectedIndex = 0;
            txtName.Focus();


        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchName.Text.Length == 0)
            {
                loadProducts();
                return;
            }

            String input = txtSearchName.Text;
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            SqlCommand cmd;
            if(Regex.IsMatch(input, "^[0-9]+$"))
            {
                //query against pid
                String query = "SELECT * FROM product WHERE p_id LIKE @pid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("pid", input + "%"));

            }
            else
            {
                //query against name and barcode
                String query = "SELECT * FROM product WHERE p_name LIKE @pname OR p_barcode LIKE @barcode";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("pname", "%" + input + "%"));
                cmd.Parameters.Add(new SqlParameter("barcode", input));
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvProducts.DataSource = dt;
            dgvProducts.Refresh();





        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            lblpid.Text = dgvProducts.Rows[rowIndex].Cells["p_id"].Value.ToString();
            txtBarcode.Text = dgvProducts.Rows[rowIndex].Cells["p_barcode"].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells["p_name"].Value.ToString();
            txtPurchaseprice.Text = dgvProducts.Rows[rowIndex].Cells["purchase_price"].Value.ToString();
            txtSalesprice.Text = dgvProducts.Rows[rowIndex].Cells["sales_price"].Value.ToString();
            txtStock.Text = dgvProducts.Rows[rowIndex].Cells["p_stock"].Value.ToString();
            Boolean status = Convert.ToBoolean(dgvProducts.Rows[rowIndex].Cells["p_status"].Value.ToString());
            if(status)
            {
                rdoAvailable.Checked = true;
            }
            else
            {
                rdoUnavailable.Checked = true;
            }

            int catid = Convert.ToInt32(dgvProducts.Rows[rowIndex].Cells["cat_id"].Value);
            for(int i = 0;i<cbxCategory.Items.Count;i++)
            {
                DataRowView drv = (DataRowView)cbxCategory.Items[i];
                if (Convert.ToInt32(drv.Row["cat_id"]) == catid)
                {
                    cbxCategory.SelectedIndex = i;
                    break;
                }
            }







        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int pId = Convert.ToInt32(lblpid.Text);
            String name = txtName.Text;
            String barocde = txtBarcode.Text;
            int purchaseprice = Convert.ToInt32(txtPurchaseprice.Text);
            int salesprice = Convert.ToInt32(txtSalesprice.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int status;
            if(rdoAvailable.Checked)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            int catid = Convert.ToInt32(cbxCategory.SelectedValue);
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "UPDATE product SET p_name = @pname, p_barcode=@barcode, purchase_price=@purchaseprice,sales_price= @salesprice,p_status=@status,cat_id=@catid,p_stock=@stock WHERE p_id=@pId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("pname", name));
            cmd.Parameters.Add(new SqlParameter("barcode", barocde));
            cmd.Parameters.Add(new SqlParameter("purchaseprice", purchaseprice));
            cmd.Parameters.Add(new SqlParameter("salesprice", salesprice));
            cmd.Parameters.Add(new SqlParameter("status", status));
            cmd.Parameters.Add(new SqlParameter("catid", catid));
            cmd.Parameters.Add(new SqlParameter("stock", stock));
            cmd.Parameters.Add(new SqlParameter("pid", pId));

            int n = cmd.ExecuteNonQuery();
            if(n>0)
            {
                MessageBox.Show("product updated successfully");
                loadProducts();
                resetForm();
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
