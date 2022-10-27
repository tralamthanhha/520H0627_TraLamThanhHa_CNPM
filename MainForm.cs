using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _520H0627_TraLamThanhHa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogInFrm loginF = new LogInFrm();
            loginF.ShowDialog();
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketFrm ticketF = new TicketFrm();
            ticketF.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpFrm signUpF = new SignUpFrm();
            signUpF.ShowDialog();
        }

        private void xácNhậnHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt receipt=new Receipt();
            receipt.ShowDialog();
        }
    }
}
