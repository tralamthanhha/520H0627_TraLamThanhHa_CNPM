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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            Cid.Text = LogInFrm.LoginInFrmCustomerID;
            ticketID.Text = TicketFrm.ticketBookedByID;
            String a = LogInFrm.LoginInFrmCustomerID;
            char[] result= a.ToCharArray();
            barcode.Text="B"+ result[result.Length-1];
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cid.Text+" "+ticketID.Text+" "+barcode.Text+" "+total.Text);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TRALAMTHANHHA-0\SQLEXPRESS; Initial Catalog=TicketSystem;Integrated Security=True";
            conn.Open();

            String sSQL = "insert into Receipts values(@Rid,@Cid, @total,@barcode,@ticket)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.Parameters.AddWithValue("@total", 3000);
            cmd.Parameters.AddWithValue("@Rid", Ridtxt.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@Cid", Cid.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@barcode", barcode.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@ticket", ticketID.Text.ToString().Trim());
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

        }
    }
}
