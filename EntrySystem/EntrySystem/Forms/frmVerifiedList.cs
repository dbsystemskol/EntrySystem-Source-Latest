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
using log4net;
using log4net.Config;
namespace EntrySystem.Forms
{
    public partial class frmVerifiedList : Form
    {
        public frmVerifiedList()
        {
            InitializeComponent();
        }
        protected static ILog log = LogManager.GetLogger(typeof(frmVerifiedList));
        clsStudent objStudent = new clsStudent();
        public static frmVerifiedList publicfrmVerifiedList;
        public Boolean isRefreshed = false;
        #region "paging"
        private Int32 PageCount;
        public Int32 PageNo;
        private Int32 PageSize;
        #endregion

        private void frmVerifiedList_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            MDIParent frmMain = (MDIParent)this.Tag;
            //frmMain.MDIREFRESH();
            frmMain.MDIDISABLED();

            PageSize = 10;
            PageCount = objStudent.VerifiedStudentTotalPages("", PageSize);
            btnFirstPage.Enabled = (PageCount > 1) ? true : false;
            btnPrevPage.Enabled = (PageCount > 1) ? true : false;
            btnNxtPage.Enabled = (PageCount > 1) ? true : false;
            btnLastPage.Enabled = (PageCount > 1) ? true : false;
            PageNo = 1;

           
            ddlPageSize.Text = "10";
        }

        public void PopulateVerifiedList(String StudentId, int pagesize, int pageno)
        {
            if (isRefreshed == true)
            {
                txtStudentId.Text = String.Empty;
                ddlPageSize.Text = "10";
            }
            try
            {
                lstStudent.Items.Clear();
                var mDisplayList = objStudent.GetVerifiedStudentList(StudentId, pagesize, pageno);
                foreach (var s in mDisplayList)
                {
                    lstStudent.Items.Add(s.StudentId, 0);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Name);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.RegistrationNo);

                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.NatureOfEntry);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.FatherName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.MotherName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add((Convert.ToDateTime(s.DateOfBirth).ToString("dd-MM-yyyy") == "01-01-1900" ? "" : Convert.ToDateTime(s.DateOfBirth).ToString("dd-MM-yyyy")));
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Gender);

                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Category);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.PhysicallyChallengedInText);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.TypeOfChallange);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.FamilyIncomeInText);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Medium);

                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.MIL_Subject);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.MILGroup);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.LIEUSubject);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.ElectiveSubject);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Remarks);

                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.CreatedByName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add((s.CreatedOn.ToString("dd-MM-yyyy") == "01-01-1900" ? "" : s.CreatedOn.ToString("dd-MM-yyyy")));
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.ModifiedByName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add((s.ModifiedOn.ToString("dd-MM-yyyy") == "01-01-1900" ? "" : s.ModifiedOn.ToString("dd-MM-yyyy")));
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.DeletedByName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add((s.DeletedOn.ToString("dd-MM-yyyy") == "01-01-1900" ? "" : s.DeletedOn.ToString("dd-MM-yyyy")));

                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.VerifiedUserName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add((s.VerifiedOn.ToString("dd-MM-yyyy") == "01-01-1900" ? "" : s.VerifiedOn.ToString("dd-MM-yyyy")));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void cmdGoSearch_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            if (txtStudentId.Text.Length > 0)
            {

                PageNo = 1;
                var mSearchList = objStudent.GetVerifiedStudentList(txtStudentId.Text, PageSize, PageNo);
                lstStudent.Items.Clear();
                foreach (var s in mSearchList)
                {
                    lstStudent.Items.Add(s.StudentId, 0);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.Name);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.RegistrationNo);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.VerifiedUserName);
                    lstStudent.Items[lstStudent.Items.Count - 1].SubItems.Add(s.VerifiedOn.ToString("dd-MM-yyyy"));
                }
                grpSearchList.Visible = false;
                lblSearchMsg.Text = String.Empty;
            }
            else
            {
                lblSearchMsg.Text = "Enter student id to search record";
                lblSearchMsg.ForeColor = Color.Red;
            }
        }

        private void cmdCancelSearch_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            lblSearchMsg.Text = String.Empty;
            grpSearchList.Visible = false;
        }

        private void frmVerifiedList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MDIParent._MdiParent.MDIDISABLED();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            PageNo = 1;
            PopulateVerifiedList(txtStudentId.Text, PageSize, PageNo);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            if (PageNo > 1)
            {
                PageNo = PageNo - 1;
                PopulateVerifiedList(txtStudentId.Text, PageSize, PageNo);
            }
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            PageCount = objStudent.VerifiedStudentTotalPages(txtStudentId.Text, PageSize);
            if (PageNo < PageCount)
            {
                PageNo = PageNo + 1;
                PopulateVerifiedList(txtStudentId.Text, PageSize, PageNo);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            isRefreshed = false;
            PageCount = objStudent.VerifiedStudentTotalPages(txtStudentId.Text, PageSize);
            PageNo = PageCount;
            PopulateVerifiedList(txtStudentId.Text, PageSize, PageNo);
        }

        private void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            isRefreshed = false;
            PageSize = Convert.ToInt32(ddlPageSize.Text);
            PageNo = 1;
            PopulateVerifiedList(txtStudentId.Text.ToString(), PageSize, PageNo);
        }
    }
}
