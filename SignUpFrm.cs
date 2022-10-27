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

namespace _520H0627_TraLamThanhHa
{

    public partial class SignUpFrm : Form
    {
        public SignUpFrm()
        {
            InitializeComponent();
        }

        /*private void SignUpFrm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Customers");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data");
            }
        }*/


        private void signUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TRALAMTHANHHA-0\SQLEXPRESS; Initial Catalog=TicketSystem;Integrated Security=True";
            conn.Open();
            String sql = "insert into Customers values(@Cid,@Cname,@password)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.Add(new SqlParameter());
            cmd.Parameters.AddWithValue("@Cid",Cid.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Cname",Cname.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@password",password.Text.ToString().Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Save successfully!");
            }
            else
            {
                MessageBox.Show("Save Fail");
            }
            
            dataGridView1.Refresh();
        }
    }
}
