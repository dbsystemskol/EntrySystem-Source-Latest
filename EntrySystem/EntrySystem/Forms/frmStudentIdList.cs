using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using EntrySystem.Class;
using EntrySystem.DataLayer.Type;
using EntrySystem.DataLayer;
using log4net;
using log4net.Config;

namespace EntrySystem.Forms
{
    public partial class frmStudentIdList : Form
    {
        protected static ILog log = LogManager.GetLogger(typeof(frmStudentIdList));
        UserMaster objuser = new UserMaster();
        clsUser objLogin = new clsUser();
        String StudentId = "";

        public static frmStudentIdList publicStudentIDList;

        public frmStudentIdList()
        {
            InitializeComponent();
        }

        private void frmStudentIdList_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            MDIParent frmMain = (MDIParent)this.Tag;
            frmMain.MDIREFRESH();
            publicStudentIDList = this;
            DisplaylstStudentIDRecords();

            frmMain.MDIDISABLED_FORSTUDENT();
        }

        public void DisplaylstStudentIDRecords()
        {
            String DOB = "";
            String GEN = "";
            try
            {
                lstStudentIDInfo.Items.Clear();
                var mDisplayList = objLogin.GetAllStudentMasterInfo();
                foreach (var s in mDisplayList)
                {
                    if (s.DOB.ToString() != "")
                        DOB = (s.DOB.ToString().Substring(0, 2)) + "-" + (s.DOB.ToString().Substring(2, 2)) + "-" + (s.DOB.ToString().Substring(4, 4));
                    else
                        DOB = "";

                    if (s.Gender.ToString() != "")
                        GEN = (s.Gender.ToString() == "M" ? "MALE" : "FEMALE");
                    else
                        GEN = "";

                    lstStudentIDInfo.Items.Add(Convert.ToString(s.ID), 0);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.StudentID);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.RegistrationNo);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.candidateName);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.FatherName);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(DOB);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(GEN);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void cmdGoSearch_Click(object sender, EventArgs e)
        {
            //lblMsg.Text = "";
            String DOB = "";
            String GEN = "";
            if (txtStudentId.Text.Length > 0)
            {
                var mSearchList = objLogin.GetStudentMasterInfoById(txtStudentId.Text);
                lstStudentIDInfo.Items.Clear();
                foreach (var s in mSearchList)
                {
                    if (s.DOB.ToString() != "")
                        DOB = (s.DOB.ToString().Substring(0, 2)) + "-" + (s.DOB.ToString().Substring(2, 2)) + "-" + (s.DOB.ToString().Substring(4, 4));
                    else
                        DOB = "";

                    if (s.Gender.ToString() != "")
                        GEN = (s.Gender.ToString() == "M" ? "MALE" : "FEMALE");
                    else
                        GEN = "";

                    lstStudentIDInfo.Items.Add(Convert.ToString(s.ID), 0);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.StudentID);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.RegistrationNo);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.candidateName);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(s.FatherName);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(DOB);
                    lstStudentIDInfo.Items[lstStudentIDInfo.Items.Count - 1].SubItems.Add(GEN);
                }
                grpSearchList.Visible = false;
                lblSearchMsg.Text = String.Empty;
            }
            else
            {
                lblSearchMsg.Text = "Enter Keyword to search record";
                lblSearchMsg.ForeColor = Color.Red;
            }
        }

        private void picListRefresh_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = String.Empty;
            frmStudentIdList_Load(this, e);
        }

        private void cmdCancelSearch_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = String.Empty;
            grpSearchList.Visible = false;
        }

        private void lstStudentIDInfo_DoubleClick(object sender, EventArgs e)
        {
            StudentId = "";
            frmCreateStudentID.StudentMasterID = (lstStudentIDInfo.FocusedItem.SubItems[1].Text);
            frmCreateStudentID.isAdd = false;
            frmCreateStudentID StidentIdAdd = new frmCreateStudentID();
            StidentIdAdd.ShowDialog();
        }

        private void lstStudentIDInfo_Click(object sender, EventArgs e)
        {
            MDIParent.StudentID = (lstStudentIDInfo.FocusedItem.SubItems[1].Text);
            StudentId = (lstStudentIDInfo.FocusedItem.SubItems[1].Text);
        }

    }
}
