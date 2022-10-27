using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Configuration; 

namespace _520H0627_TraLamThanhHa
{
    public partial class TicketFrm : Form
    {
        public static String ticketBookedByID = "";
        public TicketFrm()
        {
            InitializeComponent();
        }


        private void TicketFrm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void bookTicket_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TRALAMTHANHHA-0\SQLEXPRESS; Initial Catalog=TicketSystem;Integrated Security=True";
            conn.Open();

            String sSQL = "insert into Ticket values(@TicketID,@Cid,@Payment,@endTime," +
                          "@PlaceFrom,@PlaceTo,@TransID,@startTime)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            
            cmd.Parameters.AddWithValue("@Cid", LogInFrm.LoginInFrmCustomerID.ToString().Trim());
            cmd.Parameters.AddWithValue("@endTime", dateTimeEnd.Value);
            cmd.Parameters.AddWithValue("@startTime", dateTimeStart.Value);
            //comboBox
            cmd.Parameters.AddWithValue("@Payment", PaymentcomboBox.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@PlaceFrom", FromcomboBox.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@PlaceTo", TocomboBox.Text.ToString().Trim());
            //TicketID
            cmd.Parameters.AddWithValue("@TicketID",TicketID.Text.ToString().Trim());
            cmd.Parameters.AddWithValue("@TransID", TransID.Text.ToString().Trim());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ticketBookedByID=TicketID.Text.ToString().Trim();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Add Ticket Successfull");
            }
            else
            {
                MessageBox.Show("Add Ticket Fail");
            }
        }

        private void RefreshData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=TRALAMTHANHHA-0\SQLEXPRESS; Initial Catalog=TicketSystem;Integrated Security=True";
            conn.Open();

            String sSQL = "SELECT * FROM Transports";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewTransport.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid Login. Please check userID or Password!");
            }
        }
    }
}