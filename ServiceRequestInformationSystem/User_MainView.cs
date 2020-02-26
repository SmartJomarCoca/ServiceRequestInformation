using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    public partial class User_MainView : UserControl
    {
        public User_MainView()
        {
            InitializeComponent();
        }

        private void gridControl_RequestList_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SQLCon.DbCon();
            //    SQLCon.sqlDataApater = new SqlDataAdapter("SELECT NameOfOficce AS [Name Of Oficce], PersonConcerned AS [Person Concerned], DateTime AS [Date/Time], NatureOfRequest AS [Nature Of Request], CallReceivedBy AS [Call Received By] FROM ServiceRequestInfoes ORDER BY SR_ID DESC", SQLCon.sqlConnection);
            //    SQLCon.dataTable = new DataTable();
            //    SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            //    gridControl_RequestList.DataSource = SQLCon.dataTable;
            //    //firstDisplayUserLogHistory();
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
                SQLCon.sqlDataApater = new SqlDataAdapter("SELECT T2.TypeOfServiceProvided AS [Type Of Service Provided], T1.RequestedBy AS [Requested By], " +
                     "T3.OfficeDepartmentName AS [Office], T1.DateRequested AS [Date Requested], T1.DateAccomplished AS [Date Accomplished], T4.spName AS [Service Provided By], T1.Status " +
                     "FROM ServiceRequestInfoes AS T1, TypeOfServices AS T2, OfficeDepartments AS T3, ServiceProvidedBies AS T4" +
                 " WHERE T1.TS_ID=T2.TS_ID " +
                 "AND T1.OD_ID=T3.OD_ID " +
                 "AND T1.SP_ID=T4.SP_ID " +
                 "AND T1.Status=1", SQLCon.sqlConnection);
                SQLCon.dataTable = new DataTable();

                SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                gridControl_RequestList.DataSource = SQLCon.dataTable;


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
