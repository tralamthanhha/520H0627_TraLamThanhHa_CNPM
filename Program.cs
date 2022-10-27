using System.Configuration;

namespace _520H0627_TraLamThanhHa
{
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string strConn = "";
        [STAThread]
        static void Main()
        {
            //String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            string strConn = @"Data Source=TRALAMTHANHHA-0\\SQLEXPRESS;Initial Catalog=TicketSystem; Integrated Security=True";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}