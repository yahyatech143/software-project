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

namespace WindowsFormsApp2
{
    public partial class ManageCategoriesForm : Form
    {
        public ManageCategoriesForm()
        {
            InitializeComponent();
        }

        private void ManageCategoriesForm_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void loadCategories()
        {
            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "SELECT * FROM category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCategories.DataSource = dt;
            dgvCategories.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String catname = txtCatName.Text.Trim();
            int status;
            if(rdoAvailable.Checked)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }

            String connStr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "INSERT INTO category(cat_name,cat_status) VALUES(@cname,@cstatus)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("cname", catname));
            cmd.Parameters.Add(new SqlParameter("cstatus", status));
            int n = cmd.ExecuteNonQuery();
            if(n>0)
            {
               // MessageBox.Show("category added successfully");
                loadCategories();
                resetForm();
            }
            else
            {
                MessageBox.Show("failed to add category");
            }


        }

        private void resetForm()
        {
            txtCatName.Clear();
            rdoAvailable.Checked = true;
            txtCatName.Focus();
        }

        







    }
}
