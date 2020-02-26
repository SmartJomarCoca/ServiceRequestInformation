using DevExpress.XtraGrid.Views.Grid;
using ServiceRequestInformationSystem.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class User_AddRequest : DevExpress.XtraEditors.XtraUserControl
    {
        public User_AddRequest()
        {
            InitializeComponent();
        }

        private void User_AddRequest_Load(object sender, EventArgs e)
        {
            LoadOfficeDepartment();
            LoadTypeOfService();
            LoadTechnician();
            LoadRemark();
            LoadDates();
            LoadRequestList();

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveRequest();


        }

        private void LoadDates()
        {

            dtp_Requested.EditValue = DateTime.Now;
            DateTime date = DateTime.Now;

            string dateToday = " " + date.ToString("d");
            DayOfWeek day = DateTime.Now.DayOfWeek;

            //if (day == DayOfWeek.Thursday)
            //{
            //    dtp_Accomplished.EditValue = DateTime.Now.AddDays(4);

            //}
            //else if (day == DayOfWeek.Friday)
            //{
            //    dtp_Accomplished.EditValue = DateTime.Now.AddDays(4);

            //}
            //else
            //{
            //    dtp_Accomplished.EditValue = DateTime.Now.AddDays(2);
            //}

            //DateTime dateTime1 = DateTime.Now;
            //DateTime dateTime2 = DateTime.Now.AddDays(4);
            //TimeSpan hours = dateTime2 - dateTime1;

            //MessageBox.Show("" + hours.TotalHours, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




        }

        private void SaveRequest()
        {
            try
            {
                if (cb_ServiceProvided.SelectedIndex != -1 && cb_OfficeDepartment.SelectedIndex != -1 && cb_TypeOfService.SelectedIndex != -1 && tb_RequestedBy.Text != "")
                {

                    DateTime dateTime1 = DateTime.Now;
                    DateTime dateTime2 = DateTime.Now.AddDays(4);
                    var hours = (dateTime2 - dateTime1).TotalHours;


                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO ServiceRequestInfoes VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9)", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_TypeOfService.SelectedValue);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@2", tb_RequestedBy.Text);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@3", cb_OfficeDepartment.SelectedValue);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@4", dtp_Requested.EditValue);

                    SQLCon.sqlCommand.Parameters.AddWithValue("@5", hours);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@6", DBNull.Value);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@7", cb_ServiceProvided.SelectedValue);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@8", cb_Remarks.SelectedValue);
                    SQLCon.sqlCommand.Parameters.AddWithValue("@9", 0);

                    SQLCon.sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("New request added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText();
                    LoadRequestList();
                }
                else
                {
                    MessageBox.Show("Please input all the required fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {

            ClearText();
        }

        private void ClearText()
        {
            cb_TypeOfService.Text = "";
            tb_RequestedBy.Text = "";
            cb_OfficeDepartment.Text = "";
            dtp_Requested.Text = "";
            dtp_Accomplished.Text = "";
            cb_ServiceProvided.Text = "";
            cb_Remarks.Text = "";
            LoadDates();
        }

        private void pictureEdit_TypeOfService_Click(object sender, EventArgs e)
        {
            SaveTypeOfService();
            LoadTypeOfService();
        }


        private void SaveTypeOfService()
        {
            try
            {

                if (cb_TypeOfService.Text != "")
                {


                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO TypeOfServices VALUES(@1)", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_TypeOfService.Text);

                    SQLCon.sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("New Services added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please input Type of Service!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void LoadTypeOfService()
        {

            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM TypeOfServices", SQLCon.sqlConnection);
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_TypeOfService.DataSource = SQLCon.dataTable;
            cb_TypeOfService.ValueMember = "TS_ID";
            cb_TypeOfService.DisplayMember = "TypeOfServiceProvided";
            cb_TypeOfService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_TypeOfService.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_TypeOfService.SelectedIndex = -1;

            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM ServiceProvidedBies", SQLCon.sqlConnection);
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);


            checkedComboBoxEdit1.Properties.DataSource = SQLCon.dataTable;
            checkedComboBoxEdit1.Properties.ValueMember = "SP_ID";
            checkedComboBoxEdit1.Properties.DisplayMember = "spName";
            //checkedComboBoxEdit1.Properties.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //checkedComboBoxEdit1.Properties.AutoCompleteSource = AutoCompleteSource.ListItems;
            //checkedComboBoxEdit1.Properties.SelectedIndex = -1;

        }




        private void pictureEdit_AddServiceProvided_Click(object sender, EventArgs e)
        {
            SaveServiceProvided();
            LoadTechnician();
        }

        private void SaveServiceProvided()
        {
            try
            {

                if (cb_ServiceProvided.Text != "")
                {


                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO ServiceProvidedBies VALUES(@1)", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_ServiceProvided.Text);

                    SQLCon.sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("New Technician added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please input Technician Name!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {


            }
        }

        public void LoadTechnician()
        {
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM ServiceProvidedBies", SQLCon.sqlConnection);
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_ServiceProvided.DataSource = SQLCon.dataTable;
            cb_ServiceProvided.ValueMember = "SP_ID";
            cb_ServiceProvided.DisplayMember = "spName";
            cb_ServiceProvided.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_ServiceProvided.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_ServiceProvided.SelectedIndex = -1;


        }




        private void pictureEdit_OfficeDepartment_Click(object sender, EventArgs e)
        {

            SaveOfficeDepartment();
            LoadOfficeDepartment();
        }

        private void SaveOfficeDepartment()
        {
            try
            {

                if (cb_OfficeDepartment.Text != "")
                {


                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO OfficeDepartments VALUES(@1)", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_OfficeDepartment.Text);

                    SQLCon.sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("New Office added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please don't leave it blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {


            }
        }

        public void LoadOfficeDepartment()
        {
            try
            {


                SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM OfficeDepartments", SQLCon.sqlConnection);
                SQLCon.DbCon();
                SQLCon.dataTable = new DataTable();
                SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                cb_OfficeDepartment.DataSource = SQLCon.dataTable;
                cb_OfficeDepartment.ValueMember = "OD_ID";
                cb_OfficeDepartment.DisplayMember = "OfficeDepartmentName";
                cb_OfficeDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_OfficeDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
                cb_OfficeDepartment.SelectedIndex = -1;
            }
            catch (Exception)
            {


            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            LoadOfficeDepartment();
            LoadTypeOfService();
            LoadTechnician();
            LoadDates();

        }



        private void gridControl1_Load(object sender, EventArgs e)
        {
            LoadRequestList();
        }

        private void LoadRequestList()
        {
            try
            {
                SQLCon.DbCon();
                //SQLCon.sqlDataApater = new SqlDataAdapter("SELECT TypeOfServiceProvided AS [Type Of Service Provided], RequestedBy AS [Requested By], " +
                //    "NameOfOficce AS [Office], DateRequested AS [Date Requested], DateAccomplished AS [Date Accomplished], ServiceProvidedBy AS [Service Provided By] " +
                //    "FROM ServiceRequestInfoes AS T1, TypeOfServices AS T2" +
                //" ORDER BY SR_ID DESC", SQLCon.sqlConnection);

                //SQLCon.sqlDataApater = new SqlDataAdapter("SELECT T2.TypeOfServiceProvided AS [Type Of Service Provided], T1.RequestedBy AS [Requested By], " +
                //    "T3.OfficeDepartmentName AS [Office], T1.DateRequested AS [Date Requested], T1.TimeLeft AS [Time Left] ,T1.DateAccomplished AS [Date Accomplished], T4.spName AS [Service Provided By], Remars AS [Remarks] ,Status [Status:] " +
                //    "FROM ServiceRequestInfoes AS T1, TypeOfServices AS T2, OfficeDepartments AS T3, ServiceProvidedBies AS T4, RemarkInfoes AS T5" +
                //" WHERE T1.TS_ID=T2.TS_ID AND T1.OD_ID=T3.OD_ID AND T1.SP_ID=T4.SP_ID AND T1.Remark_ID=T5.Remark_ID", SQLCon.sqlConnection);

                SQLCon.sqlDataApater = new SqlDataAdapter("SELECT DateRequested   FROM ServiceRequestInfoes", SQLCon.sqlConnection);
                SQLCon.dataSet = new DataSet();

                //SQLCon.dataTable = new DataTable();


                SQLCon.sqlDataApater.Fill(SQLCon.dataSet, "ServiceRequestInfoes");

                DataTable dt = new DataTable();
                dataGridView1.Columns.Add("newColumnName", "Column Name in Text");
                dataGridView1.Rows.Add("asdas");

                dt.Columns.Add(new DataColumn("colBestBefore", typeof(DateTime)));
                dt.Columns.Add(new DataColumn("colStatus", typeof(string)));

                dt.Columns["colStatus"].Expression = String.Format("IIF(colBestBefore < #{0}#, 'Ok','Not ok')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                dt.Rows.Add(DateTime.Now.AddDays(-1));
                dt.Rows.Add(DateTime.Now.AddDays(1));
                dt.Rows.Add(DateTime.Now.AddDays(2));
                dt.Rows.Add(DateTime.Now.AddDays(-2));

                dataGridView1.DataSource = dt;


                //dataGridView1.DataSource = SQLCon.dataSet.Tables["ServiceRequestInfoes"].DefaultView;



                LoadTechnician();
                LoadTypeOfService();
                LoadOfficeDepartment();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {


            //tb_RequestedBy.Text = gridView1.GetDataRow(gridView1.GetSelectedRows()[1]).ToString();

            //int type = 0;
            //string stringType = "";
            //stringType = (gridView1.GetFocusedRowCellDisplayText("Type Of Service Provided"));

            //SQLCon.sql = "SELECT * FROM TypeOfServices WHERE TypeOfServiceProvided='" + stringType + "'";

            //cb_TypeOfService.SelectedIndex = type - 1;
            //tb_RequestedBy.Text = gridView1.GetFocusedRowCellDisplayText("Requested By");
            //type = Int32.Parse(gridView1.GetFocusedRowCellDisplayText("Office"));
            //cb_OfficeDepartment.SelectedIndex = type - 1;
            //dtp_Requested.Text = gridView1.GetFocusedRowCellDisplayText("Date Requested");
            //dtp_Accomplished.Text = gridView1.GetFocusedRowCellDisplayText("Date Accomplished");
            //type = Int32.Parse(gridView1.GetFocusedRowCellDisplayText("Service Provided By"));
            //cb_ServiceProvided.SelectedIndex = type - 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridView view = sender as GridView;
            //view = gridView1;
            //if (e.Column != view.Columns["Name"])
            //    return;
            //if (Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Date Accomplished"])) > 100)
            //{
            //    e.Appearance.BackColor = Color.Red;
            //}
        }

        private void pictureEdit_Remarks_Click(object sender, EventArgs e)
        {
            SaveRemark();

        }

        private void LoadRemark()
        {
            SQLCon.sqlDataApater = new SqlDataAdapter("SELECT * FROM RemarkInfoes", SQLCon.sqlConnection);
            SQLCon.DbCon();
            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            cb_Remarks.DataSource = SQLCon.dataTable;
            cb_Remarks.ValueMember = "Remark_ID";
            cb_Remarks.DisplayMember = "Remars";
            cb_Remarks.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_Remarks.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Remarks.SelectedIndex = -1;
        }

        private void SaveRemark()
        {
            try
            {

                if (cb_Remarks.Text != "")
                {


                    SQLCon.DbCon();
                    SQLCon.sqlCommand = new SqlCommand("INSERT INTO RemarkInfoes VALUES(@1)", SQLCon.sqlConnection);
                    SQLCon.sqlCommand.CommandType = CommandType.Text;
                    SQLCon.sqlCommand.Parameters.AddWithValue("@1", cb_Remarks.Text);

                    SQLCon.sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("New Remark added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRemark();
                }
                else
                {
                    MessageBox.Show("Please don't leave it blank!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        DateTime endTime = DateTime.Now.AddDays(2);

        //DateTime endTime = new DateTime(2020, 02, 27, 0, 0, 0);
        //DateTime endTime = new DateTime(DateTime.Now);
        private void button1_Click(object sender, EventArgs e)
        {

            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label1.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            t.Start();
            LoadRequestList();
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label1.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
        }
    }
}
