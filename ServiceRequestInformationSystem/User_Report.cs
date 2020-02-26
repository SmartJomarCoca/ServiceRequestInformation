using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace ServiceRequestInformationSystem
{
    public partial class User_Report : DevExpress.XtraEditors.XtraUserControl
    {
        public User_Report()
        {
            InitializeComponent();

            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        //public BindingList<Customer> GetDataSource()
        //{
        //    BindingList<Customer> result = new BindingList<Customer>();
        //    result.Add(new Customer()
        //    {
        //        ID = 1,
        //        Name = "ACME",
        //        Address = "2525 E El Segundo Blvd",
        //        City = "El Segundo",
        //        State = "CA",
        //        ZipCode = "90245",
        //        Phone = "(310) 536-0611"
        //    });
        //    result.Add(new Customer()
        //    {
        //        ID = 2,
        //        Name = "Electronics Depot",
        //        Address = "2455 Paces Ferry Road NW",
        //        City = "Atlanta",
        //        State = "GA",
        //        ZipCode = "30339",
        //        Phone = "(800) 595-3232"
        //    });
        //    return result;
        //}
        //public class Customer
        //{
        //    [Key, Display(AutoGenerateField = false)]
        //    public int ID { get; set; }
        //    [Required]
        //    public string Name { get; set; }
        //    public string Address { get; set; }
        //    public string City { get; set; }
        //    public string State { get; set; }
        //    [Display(Name = "Zip Code")]
        //    public string ZipCode { get; set; }
        //    public string Phone { get; set; }
        //}

        private void gridControl_Load(object sender, EventArgs e)
        {
            try
            {
                SQLCon.DbCon();
                //SQLCon.sqlDataApater = new SqlDataAdapter("SELECT TypeOfServiceProvided AS [Type Of Service Provided], RequestedBy AS [Requested By], " +
                //    "NameOfOficce AS [Office], DateRequested AS [Date Requested], DateAccomplished AS [Date Accomplished], ServiceProvidedBy AS [Service Provided By] " +
                //    "FROM ServiceRequestInfoes AS T1, TypeOfServices AS T2" +
                //" ORDER BY SR_ID DESC", SQLCon.sqlConnection);
                SQLCon.sqlDataApater = new SqlDataAdapter("SELECT T2.TypeOfServiceProvided AS [Type Of Service Provided], T1.RequestedBy AS [Requested By], " +
                    "T3.OfficeDepartmentName AS [Office], T1.DateRequested AS [Date Requested], T1.DateAccomplished AS [Date Accomplished], T4.spName AS [Service Provided By] " +
                    "FROM ServiceRequestInfoes AS T1, TypeOfServices AS T2, OfficeDepartments AS T3, ServiceProvidedBies AS T4" +
                " WHERE T1.TS_ID=T2.TS_ID AND T1.OD_ID=T3.OD_ID AND T1.SP_ID=T4.SP_ID", SQLCon.sqlConnection);
                SQLCon.dataTable = new DataTable();
                SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
                gridControl.DataSource = SQLCon.dataTable;

               
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
