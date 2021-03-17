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
    public partial class SaleInvoiceForm : Form
    {
        public SaleInvoiceForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaleInvoiceForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Globals.username;
            txtDateTime.Text = DateTime.Now.ToString("dd-MMMMM-yyyy hh:mm:ss tt");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                String input = txtSearch.Text;
                if(input.Length == 0)
                {
                    return;
                }
                String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                SqlCommand cmd;
                if (Regex.IsMatch(input, "^[0-9]+$"))
                {
                    //query against pid
                    String query = "SELECT * FROM product WHERE p_id = @pid";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("pid", input));
                }
                else
                {
                    //query against pname and barcode
                    String query = "SELECT * FROM product WHERE p_name LIKE @pname OR p_barcode = @pbarcode";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("pname", "%" + input + "%"));
                    cmd.Parameters.Add(new SqlParameter("pbarcode", input));

                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("product not found");
                    txtSearch.Clear();
                    txtName.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();
                    txtQuantity.Text = "1";
                }
                else if(dt.Rows.Count == 1)
                {
                    txtName.Text = dt.Rows[0]["p_name"].ToString();
                    txtPrice.Text = dt.Rows[0]["sales_price"].ToString();
                    txtStock.Text = dt.Rows[0]["p_stock"].ToString();
                    txtProductId.Text = dt.Rows[0]["p_id"].ToString();
                    txtQuantity.Focus();
                }
                else
                {

                }
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(txtQuantity.Text.Length == 0)
                {
                    return;
                }
                int qty = Convert.ToInt32(txtQuantity.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                if(qty>stock)
                {
                    MessageBox.Show("insufficient stock");
                }
                else
                {
                    int pid = Convert.ToInt32(txtProductId.Text);
                    String name = txtName.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    int amount = qty * price;

                    dgvCart.Rows.Add(pid, name, price, qty, amount);
                    calculateBill();
                    txtSearch.Clear();
                    txtQuantity.Text = "1";
                    txtProductId.Clear();
                    txtName.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();
                    txtSearch.Focus();

                }
            }
        }

        private void calculateBill()
        {
            int totalBill = 0;
            for(int i = 0;i<dgvCart.Rows.Count;i++)
            {
                totalBill = totalBill + Convert.ToInt32(dgvCart.Rows[i].Cells["amount"].Value);
            }

            txtTotal.Text = totalBill.ToString();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int userid = Globals.userid;
            DateTime invoicedate = DateTime.Now;
            int totalAmount = Convert.ToInt32(txtTotal.Text);

            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "INSERT INTO sale_invoice(user_id,invoice_date,total_amount)output INSERTED.invoice_id VALUES(@uid,@date,@total)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("uid", userid));
            cmd.Parameters.Add(new SqlParameter("date", invoicedate));
            cmd.Parameters.Add(new SqlParameter("total", totalAmount));
            int invoiceId = (int)cmd.ExecuteScalar();
            if(invoiceId>0)
            {
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    query = "INSERT INTO sale_invoice_items(invoice_id,p_id,price,qty) VALUES(@invoiceid,@pid,@price,@qty)";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.Add(new SqlParameter("invoiceid", invoiceId));
                    cmd2.Parameters.Add(new SqlParameter("pid", dgvCart.Rows[i].Cells["p_id"].Value));
                    cmd2.Parameters.Add(new SqlParameter("price", dgvCart.Rows[i].Cells["price"].Value));
                    cmd2.Parameters.Add(new SqlParameter("qty", dgvCart.Rows[i].Cells["qty"].Value));
                    cmd2.ExecuteNonQuery();


                }
                txtName.Clear();
                txtPrice.Clear();
                txtProductId.Clear();
                txtQuantity.Clear();
                txtSearch.Clear();
                txtStock.Clear();
                txtTotal.Clear();
                txtDateTime.Text = DateTime.Now.ToString();
                dgvCart.Rows.Clear();
                MessageBox.Show("Invoice saved successfully");




            }


        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
