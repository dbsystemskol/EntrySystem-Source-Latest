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
using System.Collections;
namespace EntrySystem.Forms
{
    public partial class frmCreateStudentID : Form
    {
        protected static ILog log = LogManager.GetLogger(typeof(frmCreateStudentID));
        public static Boolean isAdd;
        public static String StudentID;
        public static String StudentMasterID;

       // UserMaster objUserMasterInfo = new UserMaster();
        clsUser objUser = new clsUser();

        public frmCreateStudentID()
        {
            InitializeComponent();
        }

        private void frmCreateStudentID_Load(object sender, EventArgs e)
        {
            //MdiParent.MDIDISABLED_FORSTUDENT();
            if (StudentMasterID != "" && isAdd == false)
            {
                List<StudentIDMasterInfo> _mList = new List<StudentIDMasterInfo>();
                _mList = objUser.StudentMasterInfoById(StudentMasterID);
                if (_mList.Count > 0)
                {
                    txtStudentID.Text = _mList[0].StudentID;
                    txtRegistrationNo.Text = _mList[0].RegistrationNo;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String CreateStudentID = "";
            lblMsg.Text = "";

            if (txtStudentID.Text == "")
            {
                lblMsg.Text = "Student ID cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtRegistrationNo.Text == "")
            {
                lblMsg.Text = "Registration No cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtStudentID.Text.Length != 13)
            {
                lblMsg.Text = "Student ID not in correct format";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtRegistrationNo.Text.Length < 16)
            {
                lblMsg.Text = "Registration No not in correct format";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            ArrayList list = new ArrayList();
            list.Add("01"); list.Add("02"); list.Add("03"); list.Add("04"); list.Add("05"); list.Add("06"); list.Add("07"); list.Add("08"); list.Add("09"); list.Add("10");
            list.Add("11"); list.Add("12"); list.Add("13"); list.Add("14"); list.Add("15"); list.Add("16"); list.Add("17"); list.Add("18"); list.Add("19"); list.Add("20");
            list.Add("21"); list.Add("22"); list.Add("23"); list.Add("24"); list.Add("25"); list.Add("26"); list.Add("27");

            ArrayList list1 = new ArrayList();
            list1.Add("M"); list1.Add("H"); 

            if (list.Contains(txtStudentID.Text.Trim().Substring(0, 2)) && list1.Contains(txtStudentID.Text.Trim().Substring(2, 1)))
            {
                CreateStudentID = txtStudentID.Text.Trim().Substring(0, 2);
                CreateStudentID += txtStudentID.Text.Trim().Substring(2, 1);
                CreateStudentID += txtStudentID.Text.Trim().Substring(3, 10);
            }
            else
            {
                lblMsg.Text = "Student ID not in correct format";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            Int32 _returnvalue = 0;
            if (isAdd)
            {
                try
                {
                    _returnvalue = objUser.InsertStudentMasterID(CreateStudentID.ToString(), Convert.ToInt32(CommonVariables.UserID),txtRegistrationNo.Text);
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully inserted the data";
                        lblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMsg.Text = "Registration no already exists..!!";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }
                catch (Exception ex) { log.Error(ex.ToString()); MessageBox.Show(ex.Message, CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                try
                {
                    _returnvalue = objUser.UpdateStudentMasterID(StudentMasterID.ToString(), CreateStudentID.ToString(),txtRegistrationNo.Text);
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully updated";
                        frmStudentIdList.publicStudentIDList.DisplaylstStudentIDRecords();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Record is in use", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                }
                catch (Exception ex) { log.Error(ex.ToString()); MessageBox.Show(ex.Message, CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtRegistrationNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblMsg.Text = "";
            if (txtStudentID.Text.Length == 13)
            {
                //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                if (txtStudentID.Text.Substring(2, 1) == "M")
                    txtRegistrationNo.MaxLength = 17;
                else
                    txtRegistrationNo.MaxLength = 16;
            }
            else
            {
                txtRegistrationNo.Text = "";
                lblMsg.Text = "Please type student id first";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}
