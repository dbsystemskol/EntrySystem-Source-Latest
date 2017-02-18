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
    public partial class UserMasterList : Form
    {
        protected static ILog log = LogManager.GetLogger(typeof(UserMasterList));
        UserMaster objuser = new UserMaster();
        clsUser objLogin = new clsUser();
        public static UserMasterList publicUserList;
        Int32 UserMasterId = 0;

        public UserMasterList()
        {
            InitializeComponent();
        }

        private void UserMasterList_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;
            MDIParent frmMain = (MDIParent)this.Tag;
            frmMain.MDIREFRESH();
            publicUserList = this;
            DisplaylstUserRecords();
        }

        public void DisplaylstUserRecords()
        {
            try
            {
                lstUserInfo.Items.Clear();
                var mDisplayList = objLogin.GetAllUserMasterInfo();
                foreach (var s in mDisplayList)
                {
                    lstUserInfo.Items.Add(Convert.ToString(s.UserId), 0);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.Name);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.UserName);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.ContactNo);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.UserInRole);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void lstUserInfo_DoubleClick(object sender, EventArgs e)
        {
            UserMasterId = 0;
            frmUserMasterAdd.UserID = Convert.ToInt32(lstUserInfo.FocusedItem.SubItems[0].Text);
            frmUserMasterAdd.isAdd = false;
            frmUserMasterAdd UserAdd = new frmUserMasterAdd();
            UserAdd.ShowDialog();
        }

        private void lstUserInfo_Click(object sender, EventArgs e)
        {
            MDIParent.UserMasterID = Convert.ToInt32(lstUserInfo.FocusedItem.SubItems[0].Text);
            UserMasterId = Convert.ToInt32(lstUserInfo.FocusedItem.SubItems[0].Text);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(UserMasterId) > 0)
            {
                grpChangePassword.Visible = true;
                populatePasswordRecord();
            }
        }

        public void populatePasswordRecord()
        {
            try
            {
                if ((Convert.ToInt32(UserMasterId) > 0))
                {
                    List<UserMaster> _mList = new List<UserMaster>();
                    _mList = objLogin.UserMasterSelectById(UserMasterId);
                    if (_mList.Count > 0)
                    {
                        lblName.Text = _mList[0].Name;
                        lblUserName.Text = _mList[0].UserName;
                        txtOldPassword.Text = _mList[0].Password;
                        txtOldPassword.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpChangePassword.Visible = false;
            UserMasterId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (txtNewPassword.Text == string.Empty)
            {
                lblMsg.Text = "new password cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtRetypePassword.Text == string.Empty)
            {
                lblMsg.Text = "Confirm Password cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtNewPassword.Text.Trim() != txtRetypePassword.Text.Trim())
            {
                lblMsg.Text = "Password not matched with Confirm Password";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            try
            {
                Int32 ReturnVal = objLogin.ChangeUserPassword(Convert.ToInt32(UserMasterId), txtNewPassword.Text.ToString());
                if (ReturnVal > 0)
                {
                    lblMsg.Text = "Password changed of user " + lblUserName.Text.ToString();
                    lblMsg.ForeColor = Color.Green;
                    txtNewPassword.Text = "";
                    txtRetypePassword.Text = "";
                }
                else
                {
                    lblMsg.Text = "Password not changed";
                    lblMsg.ForeColor = Color.Red;
                    txtNewPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }

            UserMasterId = 0;
        }

        private void cmdCancelSearch_Click(object sender, EventArgs e)
        {
            txtSearchText.Text = String.Empty;
            grpSearchList.Visible = false;
        }

        private void cmdGoSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchText.Text.Length > 0)
            {
                var mSearchList = objLogin.GetUserMasterInfoById(txtSearchText.Text);
                lstUserInfo.Items.Clear();
                foreach (var s in mSearchList)
                {
                    lstUserInfo.Items.Add(Convert.ToString(s.UserId), 0);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.Name);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.UserName);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.ContactNo);
                    lstUserInfo.Items[lstUserInfo.Items.Count - 1].SubItems.Add(s.UserInRole);
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
            txtSearchText.Text = String.Empty;
            grpSearchList.Visible = false;
            UserMasterList_Load(this, e);
        }

    }
}
