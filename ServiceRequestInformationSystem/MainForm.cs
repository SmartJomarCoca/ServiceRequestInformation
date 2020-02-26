using System;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

            SQLCon.DbCon();
            user_AddRequest1.LoadTypeOfService();
            user_AddRequest1.LoadTechnician();
            user_AddRequest1.LoadOfficeDepartment();

        }




        private void bt_AddRequest_Click(object sender, EventArgs e)
        {
            user_AddRequest1.BringToFront();



        }

        private void bt_ListOfRequest_Click(object sender, EventArgs e)
        {
            user_MainView1.BringToFront();



        }

        private void bt_Reports_Click(object sender, EventArgs e)
        {
            user_Report1.BringToFront();
        }
    }
}
