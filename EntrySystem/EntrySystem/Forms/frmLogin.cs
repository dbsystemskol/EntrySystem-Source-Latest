using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class frmLogin : Form
    {
        UserMaster objuser = new UserMaster();
        clsUser objLogin = new clsUser();
       protected static ILog log = LogManager.GetLogger(typeof(frmLogin));

        public frmLogin()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmLogin_Load);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0)
            {
                lblMsg.Text = "UserName cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            if (txtPassword.Text.Length == 0)
            {
                lblMsg.Text = "Password cannot be blank";
                lblMsg.ForeColor = Color.Red;
                return;
            }

            try
            {
                objuser.UserName = txtUserName.Text.Trim().ToString();
                objuser.Password = txtPassword.Text.Trim().ToString();
                var _mList = objLogin.UserLogin(objuser);

                if (_mList.Count > 0)
                {
                    if ((_mList[0].UserName == txtUserName.Text))
                    {
                        if (_mList[0].Password == txtPassword.Text)
                        {
                            CommonVariables.isConnect = true;
                            CommonVariables.UserName = _mList[0].UserName;
                            CommonVariables.UserID = Convert.ToInt32(_mList[0].UserId.ToString());
                            CommonVariables.RoleName = _mList[0].UserInRole;
                            CommonVariables.RoleAliasName = _mList[0].UserInRoleAlias;
                            Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", CommonVariables.msgTitle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username", CommonVariables.msgTitle);
                    }
                }
                else if (_mList.Count == 0)
                {
                    MessageBox.Show("Wrong username or password", CommonVariables.msgTitle);
                }
                else
                {
                    MessageBox.Show("Invalid Login", CommonVariables.msgTitle);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }          
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
