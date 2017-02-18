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
    public partial class frmUserMasterAdd : Form
    {
        protected static ILog log = LogManager.GetLogger(typeof(frmUserMasterAdd));
        public static Boolean isAdd;
        public static Int32 UserID;

        UserMaster objUserMasterInfo = new UserMaster();
        clsUser objUser = new clsUser();

        public frmUserMasterAdd()
        {
            InitializeComponent();
        }

        private void frmUserMasterAdd_Load(object sender, EventArgs e)
        {
            txtUserName.Enabled = true; txtPassword.Enabled = true;
            BindUserRole();
            if (UserID > 0 && isAdd == false)
            {
                List<UserMaster> _mList = new List<UserMaster>();
                _mList = objUser.UserMasterSelectById(UserID);
                if (_mList.Count > 0)
                {
                    txtUserName.Enabled = false; txtPassword.Enabled = false;

                    txtUserName.Text = _mList[0].UserName;
                    txtPassword.Text = _mList[0].Password;
                    txtName.Text = _mList[0].Name;
                    txtContactNo.Text = _mList[0].ContactNo;
                    ddlRole.Text = (_mList[0].UserInRoleAlias == "EO" ? "Entry Operator" : "Verifier");
                }
            }
           
        }

        public void BindUserRole()
        {
            try
            {
                List<RoleInfo> list = new List<RoleInfo>
                {
                    new RoleInfo{ UserInRoleAlias = "EO" , Rolename = "Entry Operator"},
                    new RoleInfo{ UserInRoleAlias = "VR" , Rolename = "Verifier"},
                };

                ddlRole.DataSource = list;
                ddlRole.DisplayMember = "Rolename";
                ddlRole.ValueMember = "UserInRoleAlias";
                ddlRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtContactNo.Text = "";
            ddlRole.SelectedIndex = -1;
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                lblMsg.Text = "User name cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                lblMsg.Text = "Password cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (txtName.Text.Length == 0)
            {
                lblMsg.Text = "Name cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }
            if (ddlRole.SelectedIndex < 0)
            {
                lblMsg.Text = "Please select user role";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            Int32 _returnvalue = 0;
            if (isAdd)
            {
                try
                {
                    _returnvalue = objUser.InsertUserMaster(txtUserName.Text, txtPassword.Text, txtName.Text,txtContactNo.Text,ddlRole.Text.ToString(),ddlRole.SelectedValue.ToString(),Convert.ToInt32(CommonVariables.UserID));
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully inserted the data";
                        lblMsg.ForeColor = Color.Green;
                        UserMasterList.publicUserList.DisplaylstUserRecords();
                        Close();
                    }
                    else
                    {
                        lblMsg.Text = "User already exists..!!";
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
                    _returnvalue = objUser.UpdateUserMaster(UserID, txtUserName.Text, txtName.Text, txtContactNo.Text, ddlRole.Text.ToString(), ddlRole.SelectedValue.ToString(), Convert.ToInt32(CommonVariables.UserID));
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully updated";
                        UserMasterList.publicUserList.DisplaylstUserRecords();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Please verify your record", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                }
                catch (Exception ex) { log.Error(ex.ToString()); MessageBox.Show(ex.Message, CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }


    }
}
