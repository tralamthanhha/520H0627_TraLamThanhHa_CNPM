namespace _520H0627_TraLamThanhHa
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Rid = new System.Windows.Forms.Label();
            this.Cid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.Ridtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt ID";
            // 
            // Rid
            // 
            this.Rid.AutoSize = true;
            this.Rid.Location = new System.Drawing.Point(371, 40);
            this.Rid.Name = "Rid";
            this.Rid.Size = new System.Drawing.Size(0, 20);
            this.Rid.TabIndex = 1;
            // 
            // Cid
            // 
            this.Cid.AutoSize = true;
            this.Cid.Location = new System.Drawing.Point(371, 79);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(0, 20);
            this.Cid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer ID";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(371, 123);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 20);
            this.total.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Location = new System.Drawing.Point(371, 164);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(0, 20);
            this.barcode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Barcode";
            // 
            // ticketID
            // 
            this.ticketID.AutoSize = true;
            this.ticketID.Location = new System.Drawing.Point(371, 202);
            this.ticketID.Name = "ticketID";
            this.ticketID.Size = new System.Drawing.Size(0, 20);
            this.ticketID.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ticket ID";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(231, 237);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(190, 29);
            this.OKBtn.TabIndex = 10;
            this.OKBtn.Text = "Xác nhận hóa đơn";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // Ridtxt
            // 
            this.Ridtxt.Location = new System.Drawing.Point(373, 41);
            this.Ridtxt.Name = "Ridtxt";
            this.Ridtxt.Size = new System.Drawing.Size(125, 27);
            this.Ridtxt.TabIndex = 11;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ridtxt);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ticketID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rid);
            this.Controls.Add(this.label1);
            this.Name = "Receipt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Rid;
        private Label Cid;
        private Label label4;
        private Label total;
        private Label label6;
        private Label barcode;
        private Label label8;
        private Label ticketID;
        private Label label10;
        private Button OKBtn;
        private TextBox Ridtxt;
    }
}