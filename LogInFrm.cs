using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace _520H0627_TraLamThanhHa
{
    public partial class LogInFrm : Form
    {
        public static String LoginInFrmCustomerID = "";
        public LogInFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TRALAMTHANHHA-0\SQLEXPRESS; Initial Catalog=TicketSystem;Integrated Security=True";
            conn.Open();

            String sSQL = "SELECT * FROM Customers WHERE Cid = @Cid and password = @password";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@Cid", Cid.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@password", password.Text.ToString().Trim());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                LoginInFrmCustomerID = (String)dt.Rows[0][0];
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!");
            }
        }
    }
}
