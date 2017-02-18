using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntrySystem.DataLayer.Type;
using EntrySystem.DataLayer;
using EntrySystem.Class;
using log4net;
using log4net.Config;
//using EntrySystem.Reports;
using System.Reflection;

namespace EntrySystem.Forms
{
    public partial class frmRptDateWiseActivity : Form
    {
        DataTable rptDt = null;
        clsReport objReport = new clsReport();

        public frmRptDateWiseActivity()
        {
            InitializeComponent();
        }

        private void frmRptDateWiseActivity_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            MDIParent frmMain = (MDIParent)this.Tag;
            frmMain.MDIREFRESH();
        }

        private void frmRptDateWiseActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            MDIParent._MdiParent.MDIDISABLED();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                clsUser objUser = new clsUser();
                ExcelUtilities Obj = new ExcelUtilities();
                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                var pass = objUser.GetExcelPassword();
               // frmRptDateWiseActivity RptDateWiseActivity = new frmRptDateWiseActivity();
                String FromDate = ""; String ToDate = "";
               // List<MemberEnrollment> _mEnrollmentInfo = new List<MemberEnrollment>();
                FromDate = dtpFromDate.Value.ToString("dd-MM-yyyy");
                ToDate = dtpToDate.Value.ToString("dd-MM-yyyy");

                rptDt = objReport.DateWiseActivityReport(FromDate, ToDate);

                String _Path = System.Configuration.ConfigurationManager.AppSettings["ReportPath"].ToString();
                String _FileName = "Activity_Log_" + DateTime.Now.ToString("dd-MM-yyyy") + "-" + DateTime.Now.ToString("HH-mm-ss")  +".xlsx";
                Cursor.Current = Cursors.AppStarting;
                if (Obj.WriteDataTableToExcel(rptDt, "Activity_Log", _Path + _FileName, "Details", pass[0].Password))
                {
                    MessageBox.Show("Data has been exported successfully & stored in " + _Path + _FileName, "Activity Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to export the data", "Activity_log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;

                //if (rptDt.Rows.Count > 0)
                //{
                //    rptDateWiseActivityDetails DateWise = new rptDateWiseActivityDetails();
                //    DateWise.SetDataSource(rptDt);
                //    crystalReportViewer1.ReportSource = DateWise;
                //}
                //else
                //{
                //    crystalReportViewer1.ReportSource = null;
                //    MessageBox.Show("No record found..");
                //}
            }
            catch (Exception ex)
            {
                //log.Error(ex.ToString());
            }
        }
        public class ListtoDataTableConverter
        {
            public DataTable ToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                //put a breakpoint here and check datatable
                return dataTable;
            }
        }
    }
}
