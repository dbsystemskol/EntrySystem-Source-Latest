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
using EntrySystem.Class;

namespace EntrySystem.Forms
{
    public partial class frmVerifyStudent : Form
    {
        public frmVerifyStudent()
        {
            InitializeComponent();
        }
        protected static ILog log = LogManager.GetLogger(typeof(frmVerifyStudent));
        clsStudent objStudent = new clsStudent();

        public static frmVerifyStudent publicVerifyStudent;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            populatePendingRecord();
        }

        private void btnVerifiedRecordSearch_Click(object sender, EventArgs e)
        {
            populateVerifiedRecord();
        }

        public void populatePendingRecord()
        {
            lblStatus.Text = "";
            lblVerifiedStatus.Text = "";
            var mList = objStudent.GetUnVerifiedStudentList(txtSearchText.Text, false);
            lblRecord.Text = mList.Count.ToString() + " No. of records found";
            dgvResult.Rows.Clear();
            if (mList.Count > 0)
            {
                int r = 0;
                foreach (StudentMasterInfo m in mList)
                {
                    dgvResult.Rows.Add();
                    dgvResult.Rows[r].Cells[1].Value = m.NatureOfEntry;
                    dgvResult.Rows[r].Cells[2].Value = m.StudentId;
                    dgvResult.Rows[r].Cells[3].Value = m.RegistrationNo;
                    dgvResult.Rows[r].Cells[4].Value = m.Name;
                    dgvResult.Rows[r].Cells[5].Value = m.DateOfBirth;

                    r++;
                }
                lblStatus.Text = "";
                lblVerifiedStatus.Text = "";
            }
            else
            {
                lblStatus.Text = "No Record found";
                lblStatus.ForeColor = Color.Red;
            }
        }

        public void populateVerifiedRecord()
        {
            lblStatus.Text = "";
            lblVerifiedStatus.Text = "";
            var mList = objStudent.GetUnVerifiedStudentList(txtVerifiedSearchText.Text, true);
            lblVerifiedRecordCount.Text = mList.Count.ToString() + " No. of records found";
            dgvVerifiedResult.Rows.Clear();
            if (mList.Count > 0)
            {
                int r = 0;
                foreach (StudentMasterInfo m in mList)
                {
                    dgvVerifiedResult.Rows.Add();
                    dgvVerifiedResult.Rows[r].Cells[0].Value = true;
                    dgvVerifiedResult.Rows[r].Cells[1].Value = m.NatureOfEntry;
                    dgvVerifiedResult.Rows[r].Cells[2].Value = m.StudentId;
                    dgvVerifiedResult.Rows[r].Cells[3].Value = m.RegistrationNo;
                    dgvVerifiedResult.Rows[r].Cells[4].Value = m.Name;
                    dgvVerifiedResult.Rows[r].Cells[5].Value = m.DateOfBirth;

                    r++;
                }
                lblStatus.Text = "";
                lblVerifiedStatus.Text = "";
            }
            else
            {
                lblVerifiedStatus.Text = "No Record found";
                lblVerifiedStatus.ForeColor = Color.Red;
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
                for (int i = 0; i < dgvResult.Rows.Count; i++)
                {
                    dgvResult.Rows[i].Cells[0].Value = true;
                }

            else
                for (int i = 0; i < dgvResult.Rows.Count; i++)
                {
                    dgvResult.Rows[i].Cells[0].Value = false;
                }
        }

        private void chkVerifiedSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerifiedSelectAll.Checked)
                for (int i = 0; i < dgvVerifiedResult.Rows.Count; i++)
                {
                    dgvVerifiedResult.Rows[i].Cells[0].Value = false;
                }

            else
                for (int i = 0; i < dgvVerifiedResult.Rows.Count; i++)
                {
                    dgvVerifiedResult.Rows[i].Cells[0].Value = true;
                }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Boolean _flag = false;
            Int32 ReturnVal = 0;

            for (int i = 0; i < dgvResult.Rows.Count; i++)
            {
                if (dgvResult.Rows[i].Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dgvResult.Rows[i].Cells[0].Value.ToString()) == true)
                    {
                        _flag = true;
                        break;
                    }
                }
            }

            if (!_flag)
            {
                lblStatus.Text = "Please select atleast one record from the Grid";
                lblStatus.ForeColor = Color.Red;
                return;
            }
            else
            {
                Int32 VerifiedRecord = 0;
                if (MessageBox.Show("Do you want to verify record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = 0; i < dgvResult.Rows.Count; i++)
                    {
                        if (dgvResult.Rows[i].Cells[0].Value != null)
                        {
                            if (Convert.ToBoolean(dgvResult.Rows[i].Cells[0].Value.ToString()) == true)
                            {
                                ReturnVal = objStudent.VerifyStudents(dgvResult.Rows[i].Cells[3].Value.ToString(), Convert.ToInt32(CommonVariables.UserID),true);
                                if (ReturnVal > 0)
                                {
                                    VerifiedRecord += ReturnVal;
                                }
                            }
                        }
                    }
                    lblStatus.Text =  VerifiedRecord.ToString() + " Student(s) verified successfully";
                    lblStatus.ForeColor = Color.Green;
                    populatePendingRecord();
                    populateVerifiedRecord();
                }
            }
        }

        private void btnUnVerify_Click(object sender, EventArgs e)
        {
            Boolean _flag = false;
            Int32 ReturnVal = 0;

            for (int i = 0; i < dgvVerifiedResult.Rows.Count; i++)
            {
                if (dgvVerifiedResult.Rows[i].Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dgvVerifiedResult.Rows[i].Cells[0].Value.ToString()) == false)
                    {
                        _flag = true;
                        break;
                    }
                }
            }

            if (!_flag)
            {
                lblVerifiedStatus.Text = "Please un-select atleast one record from the Grid";
                lblVerifiedStatus.ForeColor = Color.Red;
                return;
            }
            else
            {
                Int32 UnVerifiedRecord = 0;
                if (MessageBox.Show("Do you want to un-verify record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = 0; i < dgvVerifiedResult.Rows.Count; i++)
                    {
                        if (dgvVerifiedResult.Rows[i].Cells[0].Value != null)
                        {
                            if (Convert.ToBoolean(dgvVerifiedResult.Rows[i].Cells[0].Value.ToString()) == false)
                            {
                                ReturnVal = objStudent.VerifyStudents(dgvVerifiedResult.Rows[i].Cells[3].Value.ToString(), Convert.ToInt32(CommonVariables.UserID),false);
                                if (ReturnVal > 0)
                                {
                                    UnVerifiedRecord += ReturnVal;
                                }
                            }
                        }
                    }
                    lblVerifiedStatus.Text = UnVerifiedRecord.ToString() + " Student(s) un-verified successfully";
                    lblVerifiedStatus.ForeColor = Color.Green;
                    populateVerifiedRecord();
                    populatePendingRecord();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerifyStudent_Load(object sender, EventArgs e)
        {
            publicVerifyStudent = this;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            MDIParent frmMain = (MDIParent)this.Tag;
            frmMain.MDIREFRESH();
            frmMain.MDIDISABLED();
            populatePendingRecord();
            populateVerifiedRecord();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean _flag = false;
            String StudentId = String.Empty;
            for (int i = 0; i < dgvResult.Rows.Count; i++)
            {
                if (dgvResult.Rows[i].Cells[0].Value != null)
                {
                    if (Convert.ToBoolean(dgvResult.Rows[i].Cells[0].Value.ToString()) == true)
                    {
                        _flag = true;
                        StudentId = dgvResult.Rows[i].Cells[2].Value.ToString();
                        break;
                    }
                }
            }

            if (!_flag)
            {
                lblStatus.Text = "Please select one record to update.";
                lblStatus.ForeColor = Color.Red;
                return;
            }
            else
            {
                frmStudent.StudentId = StudentId;
                frmStudent frm = new frmStudent();
                frm.ShowDialog();
            }
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == dgvResult.Columns["clmPendingview"].Index && e.RowIndex >= 0)
            {
                String RegNo = "";
                RegNo = dgvResult.CurrentRow.Cells[3].Value.ToString();
               // MessageBox.Show(RegNo);

                frmEditVerifiedOrUnverified.RegistrationNo = RegNo.ToString();
                //frmEditVerifiedOrUnverified.isAdd = false;
                frmEditVerifiedOrUnverified EditVerifiedOrUnverified = new frmEditVerifiedOrUnverified();
                EditVerifiedOrUnverified.ShowDialog();
            }
        }

        private void dgvVerifiedResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == dgvVerifiedResult.Columns["clmVerifiedView"].Index && e.RowIndex >= 0)
            {
                String RegNo = "";
                RegNo = dgvVerifiedResult.CurrentRow.Cells[3].Value.ToString();
                // MessageBox.Show(RegNo);

                frmEditVerifiedOrUnverified.RegistrationNo = RegNo.ToString();
                //frmEditVerifiedOrUnverified.isAdd = false;
                frmEditVerifiedOrUnverified EditVerifiedOrUnverified = new frmEditVerifiedOrUnverified();
                EditVerifiedOrUnverified.ShowDialog();
            }
        }

    }
}
