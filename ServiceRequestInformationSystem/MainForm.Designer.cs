namespace ServiceRequestInformationSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_ListOfRequest = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Reports = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.user_AddRequest1 = new ServiceRequestInformationSystem.User_AddRequest();
            this.user_Report1 = new ServiceRequestInformationSystem.User_Report();
            this.user_MainView1 = new ServiceRequestInformationSystem.User_MainView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_ListOfRequest
            // 
            this.bt_ListOfRequest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_ListOfRequest.ImageOptions.SvgImage")));
            this.bt_ListOfRequest.Location = new System.Drawing.Point(3, 63);
            this.bt_ListOfRequest.Name = "bt_ListOfRequest";
            this.bt_ListOfRequest.Size = new System.Drawing.Size(133, 52);
            this.bt_ListOfRequest.TabIndex = 1;
            this.bt_ListOfRequest.Text = "List of Request";
            this.bt_ListOfRequest.Click += new System.EventHandler(this.bt_ListOfRequest_Click);
            // 
            // bt_Reports
            // 
            this.bt_Reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_Reports.ImageOptions.SvgImage")));
            this.bt_Reports.Location = new System.Drawing.Point(3, 114);
            this.bt_Reports.Name = "bt_Reports";
            this.bt_Reports.Size = new System.Drawing.Size(133, 52);
            this.bt_Reports.TabIndex = 3;
            this.bt_Reports.Text = "Reports";
            this.bt_Reports.Click += new System.EventHandler(this.bt_Reports_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.bt_Reports);
            this.panel1.Controls.Add(this.bt_ListOfRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 491);
            this.panel1.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(3, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(133, 52);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Add Request";
            this.simpleButton2.Click += new System.EventHandler(this.bt_AddRequest_Click);
            // 
            // user_AddRequest1
            // 
            this.user_AddRequest1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_AddRequest1.Location = new System.Drawing.Point(200, 12);
            this.user_AddRequest1.Name = "user_AddRequest1";
            this.user_AddRequest1.Size = new System.Drawing.Size(802, 456);
            this.user_AddRequest1.TabIndex = 7;
            // 
            // user_Report1
            // 
            this.user_Report1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_Report1.Location = new System.Drawing.Point(200, 12);
            this.user_Report1.Name = "user_Report1";
            this.user_Report1.Size = new System.Drawing.Size(802, 456);
            this.user_Report1.TabIndex = 9;
            // 
            // user_MainView1
            // 
            this.user_MainView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_MainView1.Location = new System.Drawing.Point(200, 12);
            this.user_MainView1.Margin = new System.Windows.Forms.Padding(5);
            this.user_MainView1.Name = "user_MainView1";
            this.user_MainView1.Size = new System.Drawing.Size(802, 456);
            this.user_MainView1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user_AddRequest1);
            this.Controls.Add(this.user_Report1);
            this.Controls.Add(this.user_MainView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton bt_ListOfRequest;
        private DevExpress.XtraEditors.SimpleButton bt_Reports;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private User_AddRequest user_AddRequest1;
        private User_MainView user_MainView1;
        private User_Report user_Report1;
    }
}

