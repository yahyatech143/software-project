using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            String connStr = @"Data Source=DESKTOP-7JVI354\SQLEXPRESS;Initial Catalog=ITStoreDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            String query = "SELECT * FROM user_info WHERE username = @u AND password = @p";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("u", username));
            cmd.Parameters.Add(new SqlParameter("p", password));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if(dt.Rows.Count>0)
            {
                // MessageBox.Show("Login successful");
                Globals.userid = Convert.ToInt32(dt.Rows[0]["user_id"]);
                Globals.username = dt.Rows[0]["username"].ToString();
                Globals.rolesid = Convert.ToInt32(dt.Rows[0]["roles_id"]);
                this.Hide();


                DashboardForm f = new DashboardForm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
