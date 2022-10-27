namespace _520H0627_TraLamThanhHa
{
    partial class TicketFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.FromcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this.bookTicket = new System.Windows.Forms.Button();
            this.TransID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transport ID";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(127, 157);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(250, 27);
            this.dateTimeStart.TabIndex = 2;
            // 
            // FromcomboBox
            // 
            this.FromcomboBox.FormattingEnabled = true;
            this.FromcomboBox.Location = new System.Drawing.Point(127, 243);
            this.FromcomboBox.Name = "FromcomboBox";
            this.FromcomboBox.Size = new System.Drawing.Size(151, 28);
            this.FromcomboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Booking Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Place from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Place to";
            // 
            // TocomboBox
            // 
            this.TocomboBox.FormattingEnabled = true;
            this.TocomboBox.Location = new System.Drawing.Point(127, 289);
            this.TocomboBox.Name = "TocomboBox";
            this.TocomboBox.Size = new System.Drawing.Size(151, 28);
            this.TocomboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "startTime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Payment";
            // 
            // PaymentcomboBox
            // 
            this.PaymentcomboBox.FormattingEnabled = true;
            this.PaymentcomboBox.Location = new System.Drawing.Point(127, 333);
            this.PaymentcomboBox.Name = "PaymentcomboBox";
            this.PaymentcomboBox.Size = new System.Drawing.Size(151, 28);
            this.PaymentcomboBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "endTime";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(127, 200);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(250, 27);
            this.dateTimeEnd.TabIndex = 11;
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.AllowUserToAddRows = false;
            this.dataGridViewTransport.AllowUserToDeleteRows = false;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Location = new System.Drawing.Point(439, 30);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.ReadOnly = true;
            this.dataGridViewTransport.RowHeadersWidth = 51;
            this.dataGridViewTransport.RowTemplate.Height = 29;
            this.dataGridViewTransport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransport.Size = new System.Drawing.Size(297, 154);
            this.dataGridViewTransport.TabIndex = 13;
            // 
            // bookTicket
            // 
            this.bookTicket.Location = new System.Drawing.Point(108, 382);
            this.bookTicket.Name = "bookTicket";
            this.bookTicket.Size = new System.Drawing.Size(94, 29);
            this.bookTicket.TabIndex = 14;
            this.bookTicket.Text = "Đặt vé";
            this.bookTicket.UseVisualStyleBackColor = true;
            this.bookTicket.Click += new System.EventHandler(this.bookTicket_Click);
            // 
            // TransID
            // 
            this.TransID.Location = new System.Drawing.Point(127, 103);
            this.TransID.Name = "TransID";
            this.TransID.Size = new System.Drawing.Size(250, 27);
            this.TransID.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ticket ID";
            // 
            // TicketID
            // 
            this.TicketID.Location = new System.Drawing.Point(127, 67);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(250, 27);
            this.TicketID.TabIndex = 16;
            // 
            // TicketFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bookTicket);
            this.Controls.Add(this.dataGridViewTransport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PaymentcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TocomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FromcomboBox);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransID);
            this.Name = "TicketFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TicketFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimeStart;
        private ComboBox FromcomboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox TocomboBox;
        private Label label5;
        private Label label6;
        private ComboBox PaymentcomboBox;
        private Label label7;
        private DateTimePicker dateTimeEnd;
        private DataGridView dataGridViewTransport;
        private Button bookTicket;
        private TextBox TransID;
        private Label label8;
        private TextBox TicketID;
    }
}