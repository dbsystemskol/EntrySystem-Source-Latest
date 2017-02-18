using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EntrySystem.Class;
using EntrySystem.Forms;
using EntrySystem.DataLayer;
using EntrySystem.DataLayer.Type;
using System.Reflection;

namespace EntrySystem
{
    public partial class MDIParent : Form
    {
        public static MDIParent _MdiParent;

        public static Int32 UserMasterID;
        public static String StudentID;
        public static String StateCode;
        public static String DistrictCode;
        public static String BlockCode;
        public static String PanchayatCode;
        public static String VillageCode;
        public static String SalaryGradeCode;
        public static Int32 DivisionID;
        public static String ZoneID;

        public static String URNNO;
        public static String FamilyID;

        public MDIParent()
        {
            InitializeComponent();
        }

        #region "load MDI"
        private void MDIParent_Load(object sender, EventArgs e)
        {
            _MdiParent = this;
            MenuList();
            //frmDashBoard DashBoard = new frmDashBoard();
            //DashBoard.MdiParent = this;
            //DashBoard.Width = this.Width;
            //DashBoard.Height = this.Height;
            //DashBoard.Show();
            lblUser.Text = CommonVariables.UserName;
            this.lblTodayIs.Text = Convert.ToString(System.DateTime.Today.DayOfWeek) + ", " + System.DateTime.Today.Date.ToString("dd/MM/yyyy");
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            MDIDISABLED();
            lblClock.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = System.DateTime.Now.ToLongTimeString();
        }

        public void MenuList()
        {
            //var mList = objRoleMaster.GetUserRoleDetailSelectActiveRows(CommonVariables.UserRoleMasterId);
            String RoleAlias = CommonVariables.RoleAliasName;
            List<ToolStripMenuItem> myItems = GetAllMenuStripItems.GetItems(this.menuStrip);
            foreach (var item in myItems)
            {
                //var matchList = mList.Find(p => p.ScreenName == item.Text);
                if (RoleAlias == "SA")
                {
                    if (item.ToString() == "User Master" || item.ToString() == "Create Student ID" || item.ToString() == "Reports" || item.ToString() == "Date Wise Activity" || item.ToString()=="Export")
                    {
                        item.Visible = true;
                    }
                }
                if (RoleAlias == "EO")
                {
                    if (item.ToString() == "Student Master")
                    {
                        item.Visible = true;
                    }
                }
                if (RoleAlias == "VR")
                {
                    if (item.ToString() == "Verify Students")
                    {
                        item.Visible = true;
                    }
                }
            }
        }

        public void MDIDISABLED()
        {
            tsToolBar.Items["tsNew"].Enabled = false;
            tsToolBar.Items["tsEdit"].Enabled = false;
            tsToolBar.Items["tsDelete"].Enabled = false;
            tsToolBar.Items["tsSearch"].Enabled = false;
            tsToolBar.Items["tsReload"].Enabled = false;
            tsToolBar.Items["tsExit"].Enabled = true;
        }

        public void MDIDISABLED_FORSTUDENT()
        {
           // tsToolBar.Items["tsEdit"].Enabled = false;
            tsToolBar.Items["tsDelete"].Enabled = false;
            tsToolBar.Items["tsExit"].Enabled = true;
        }

        #endregion

        public void MDIREFRESH()
        {
            if (CommonVariables.UserName != null)
            {
                tsToolBar.Items["tsNew"].Enabled = true;
                tsToolBar.Items["tsEdit"].Enabled = true;
                tsToolBar.Items["tsDelete"].Enabled = true;
                tsToolBar.Items["tsReload"].Enabled = true;
            }
            else
            {
                tsToolBar.Items["tsNew"].Enabled = true;
                tsToolBar.Items["tsEdit"].Enabled = true;
                tsToolBar.Items["tsDelete"].Enabled = true;
                tsToolBar.Items["tsReload"].Enabled = true;
            }

            tsToolBar.Items["tsNew"].Enabled = true;
            tsToolBar.Items["tsEdit"].Enabled = true;
            tsToolBar.Items["tsDelete"].Enabled = true;
            tsToolBar.Items["tsSearch"].Enabled = true;
            tsToolBar.Items["tsExit"].Enabled = true;
            tsToolBar.Items["tsReload"].Enabled = true;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you want to Exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you want to Exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #region "ToolStripMenuItems"
        
        private void stateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmStateList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmStateList stateList = new frmStateList();
            //stateList.Tag = this;
            //stateList.MdiParent = this;
            //stateList.Width = this.Width;
            //stateList.Height = this.Height;
            //stateList.Show();
        }
        private void districtMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmDistrictList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmDistrictList DistrictList = new frmDistrictList();
            //DistrictList.Tag = this;
            //DistrictList.MdiParent = this;
            //DistrictList.Width = this.Width;
            //DistrictList.Height = this.Height;
            //DistrictList.Show();
        }
        private void blockMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmBlockList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmBlockList BlockList = new frmBlockList();
            //BlockList.Tag = this;
            //BlockList.MdiParent = this;
            //BlockList.Width = this.Width;
            //BlockList.Height = this.Height;
            //BlockList.Show();
        }
        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmPanchayatList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmPanchayatList PanchayatList = new frmPanchayatList();
            //PanchayatList.Tag = this;
            //PanchayatList.MdiParent = this;
            //PanchayatList.Width = this.Width;
            //PanchayatList.Height = this.Height;
            //PanchayatList.Show();
        }
        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmVillageList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmVillageList VillageList = new frmVillageList();
            //VillageList.Tag = this;
            //VillageList.MdiParent = this;
            //VillageList.Width = this.Width;
            //VillageList.Height = this.Height;
            //VillageList.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmDivisionList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmDivisionList DivisionList = new frmDivisionList();
            //DivisionList.Tag = this;
            //DivisionList.MdiParent = this;
            //DivisionList.Width = this.Width;
            //DivisionList.Height = this.Height;
            //DivisionList.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmSalaryGradeList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmSalaryGradeList SalaryGradeList = new frmSalaryGradeList();
            //SalaryGradeList.Tag = this;
            //SalaryGradeList.MdiParent = this;
            //SalaryGradeList.Width = this.Width;
            //SalaryGradeList.Height = this.Height;
            //SalaryGradeList.Show();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmZoneMasterList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmZoneMasterList ZoneMasterList = new frmZoneMasterList();
            //ZoneMasterList.Tag = this;
            //ZoneMasterList.MdiParent = this;
            //ZoneMasterList.Width = this.Width;
            //ZoneMasterList.Height = this.Height;
            //ZoneMasterList.Show();
        }
        private void fingerPrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmFingerprint")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmFingerprint Fingerprint = new frmFingerprint();
            //Fingerprint.Tag = this;
            //Fingerprint.MdiParent = this;
            //Fingerprint.Width = this.Width;
            //Fingerprint.Height = this.Height;
            //Fingerprint.Show();
        }
        private void enrollmentMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmEnrollmentList")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmEnrollmentList enrollList = new frmEnrollmentList();
            //enrollList.Tag = this;
            //enrollList.MdiParent = this;
            //enrollList.Width = this.Width;
            //enrollList.Height = this.Height;
            //enrollList.Show();
        }
        private void photoCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmPhotoCapture")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmPhotoCapture PhotoCapture = new frmPhotoCapture();
            //PhotoCapture.Tag = this;
            //PhotoCapture.MdiParent = this;
            //PhotoCapture.Width = this.Width;
            //PhotoCapture.Height = this.Height;
            //PhotoCapture.Show();
        }
        private void listOfCapturedPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmShowPhotoCaptured")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmShowPhotoCaptured ListCapturedPhoto = new frmShowPhotoCaptured();
            //ListCapturedPhoto.Tag = this;
            //ListCapturedPhoto.MdiParent = this;
            //ListCapturedPhoto.Width = this.Width;
            //ListCapturedPhoto.Height = this.Height;
            //ListCapturedPhoto.Show();
        }
        private void verifyFingerPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmVerifyFingerPrint")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmVerifyFingerPrint VerifyFingerPrint = new frmVerifyFingerPrint();
            //VerifyFingerPrint.Tag = this;
            //VerifyFingerPrint.MdiParent = this;
            //VerifyFingerPrint.Width = this.Width;
            //VerifyFingerPrint.Height = this.Height;
            //VerifyFingerPrint.Show();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmFingerPrintAndPhotoCapture")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmFingerPrintAndPhotoCapture FingerPrintAndPhotoCapture = new frmFingerPrintAndPhotoCapture();
            //FingerPrintAndPhotoCapture.Tag = this;
            //FingerPrintAndPhotoCapture.MdiParent = this;
            //FingerPrintAndPhotoCapture.Width = this.Width;
            //FingerPrintAndPhotoCapture.Height = this.Height;
            //FingerPrintAndPhotoCapture.Show();
        }
        private void databaseBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmDatabaseBackUp")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmDatabaseBackUp DBbackUp = new frmDatabaseBackUp();
            //DBbackUp.Tag = this;
            //DBbackUp.MdiParent = this;
            //DBbackUp.Show();
        }
        private void cardIssueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmDatabaseBackUp")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmDatabaseBackUp DBbackUp = new frmDatabaseBackUp();
            //DBbackUp.Tag = this;
            //DBbackUp.MdiParent = this;
            //DBbackUp.Show();
        }

        #endregion

        #region "Menu Exit"

        private void tsExit_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.Name != "frmDashBoard")
                {
                    ActiveMdiChild.Close();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        #endregion

        #region "Open Child forms For Insertion"

        private void tsNew_Click(object sender, EventArgs e)
        {
            FormAdd(ActiveMdiChild.Name);
        }

        private void FormAdd(String frmName)
        {
            switch (frmName)
            {
                case "UserMasterList":
                    frmUserMasterAdd.isAdd = true;
                    frmUserMasterAdd UserAdd = new frmUserMasterAdd();
                    UserAdd.ShowDialog();

                    break;

                case "frmStudentIdList":
                    frmCreateStudentID.isAdd = true;
                    frmCreateStudentID StudentIdAdd = new frmCreateStudentID();
                    StudentIdAdd.ShowDialog();

                    break;

                //case "frmBlockList":
                //    frmBlockAdd.isAdd = true;
                //    frmBlockAdd BlockAdd = new frmBlockAdd();
                //    BlockAdd.ShowDialog();

                //    break;

                //case "frmPanchayatList":
                //    frmPanchayatAdd.isAdd = true;
                //    frmPanchayatAdd PanchayatAdd = new frmPanchayatAdd();
                //    PanchayatAdd.ShowDialog();

                //    break;

                //case "frmVillageList":
                //    frmVillageAdd.isAdd = true;
                //    frmVillageAdd VillageAdd = new frmVillageAdd();
                //    VillageAdd.ShowDialog();

                //    break;

                //case "frmDivisionList":
                //    frmDivisionAdd.isAdd = true;
                //    frmDivisionAdd DivisionAdd = new frmDivisionAdd();
                //    DivisionAdd.ShowDialog();

                //    break;

                //case "frmSalaryGradeList":
                //    frmSalaryGradeAdd.isAdd = true;
                //    frmSalaryGradeAdd SalaryGradeAdd = new frmSalaryGradeAdd();
                //    SalaryGradeAdd.ShowDialog();

                //    break;

                //case "frmZoneMasterList":
                //    frmZoneMasterAdd.isAdd = true;
                //    frmZoneMasterAdd ZoneMasterAdd = new frmZoneMasterAdd();
                //    ZoneMasterAdd.ShowDialog();

                //    break;

                //case "frmEnrollmentList":
                //    frmEnrollmentAdd.isAdd = true;
                //    frmEnrollmentAdd EnrollmentAdd = new frmEnrollmentAdd();
                //    EnrollmentAdd.ShowDialog();

                //    break;
            }
        }

        #endregion

        #region "Delete Record"

        private void tsDelete_Click(object sender, EventArgs e)
        {
            FormDelete(ActiveMdiChild.Name);
        }

        private void FormDelete(String frmName)
        {
            switch (frmName)
            {

                case "UserMasterList":
                    if (UserMasterID != 0 )
                        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            clsUser objLogin = new clsUser();
                            Int32 _returnval = objLogin.DeleteUserMaster(UserMasterID);
                            if (_returnval > 0)
                            {
                                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UserMasterList.publicUserList.DisplaylstUserRecords();
                                UserMasterID = 0;
                            }
                            else
                            {
                                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    break;


                //case "frmDistrictList":
                //    if (DistrictCode != String.Empty && DistrictCode != null && StateCode != String.Empty)
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            DistrictMasterInfo objDistrictMasterInfo = new DistrictMasterInfo();
                //            Int32 _returnval = objDistrictMasterInfo.DeleteDistrict(DistrictCode, StateCode);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmDistrictList.publicDistrictList.DisplaylstDistrictRecords();
                //                DistrictCode = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    break;

                //case "frmBlockList":
                //    if (BlockCode != String.Empty && BlockCode != null && DistrictCode != String.Empty && StateCode != String.Empty)
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            BlockMasterInfo objBlockMasterInfo = new BlockMasterInfo();
                //            Int32 _returnval = objBlockMasterInfo.DeleteBlock(BlockCode, DistrictCode, StateCode);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmBlockList.publicBlockList.DisplaylstBlockRecords();
                //                BlockCode = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    break;

                //case "frmPanchayatList":
                //    if (PanchayatCode != String.Empty && PanchayatCode != null && BlockCode != String.Empty && DistrictCode != String.Empty && StateCode != String.Empty)
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            PanchayatMasterInfo objPanchayatMasterInfo = new PanchayatMasterInfo();
                //            Int32 _returnval = objPanchayatMasterInfo.DeletePanchayat(PanchayatCode,BlockCode, DistrictCode, StateCode);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmPanchayatList.publicPanchayatList.DisplaylstPanchayatRecords();
                //                PanchayatCode = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    break;

                //case "frmVillageList":
                //    if (VillageCode != String.Empty && VillageCode != null && PanchayatCode != String.Empty && BlockCode != String.Empty && DistrictCode != String.Empty && StateCode != String.Empty)
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            VillageMasterInfo objVillageMasterInfo = new VillageMasterInfo();
                //            Int32 _returnval = objVillageMasterInfo.DeleteVillage(VillageCode, PanchayatCode, BlockCode, DistrictCode, StateCode);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmVillageList.publicVillageList.DisplaylstVillageRecords();
                //                VillageCode = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    break;

                //case "frmDivisionList":
                //    if (DivisionID > 0)
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            DivisionMasterInfo objDivisionMasterInfo = new DivisionMasterInfo();
                //            Int32 _returnval = objDivisionMasterInfo.DeleteDivision(DivisionID);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmDivisionList.publicDivisionList.DisplaylstDivisionRecords();
                //                DivisionID = 0;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    break;

                //case "frmSalaryGradeList":
                //    if (SalaryGradeCode != String.Empty && SalaryGradeCode != null)
                //    {
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            SalaryGradeMasterInfo objSalaryGradeMasterInfo = new SalaryGradeMasterInfo();
                //            Int32 _returnval = objSalaryGradeMasterInfo.DeleteSalaryGrade(SalaryGradeCode);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmSalaryGradeList.publicSalaryGradeList.DisplaylstSalaryGradeRecords();
                //                SalaryGradeCode = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    }
                //    break;

                //case "frmZoneMasterList":
                //    if (ZoneID != String.Empty && ZoneID != null)
                //    {
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            ZoneMasterInfo objZoneMasterInfo = new ZoneMasterInfo();
                //            Int32 _returnval = objZoneMasterInfo.DeleteZone(ZoneID);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //                frmZoneMasterList.publicZoneMasterList.DisplaylstZoneRecords();
                //                ZoneID = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    }
                //    break;

                //case "frmEnrollmentList":
                //    if (FamilyID != String.Empty || FamilyID != null && URNNO != String.Empty || URNNO != null)
                //    {
                //        if (MessageBox.Show("Do you want to delete this record ???", CommonVariables.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                //        {
                //            EnrollmentMasterInfo objEnrollmentMasterInfo = new EnrollmentMasterInfo();
                //            Int32 _returnval = objEnrollmentMasterInfo.DeleteEnrollment(URNNO, FamilyID);
                //            if (_returnval > 0)
                //            {
                //                MessageBox.Show("Successfully Deleted", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //               // frmEnrollmentList.publicEnrollmentList.DisplaylstEnrollmentRecords("", 10, 1);
                //                frmEnrollmentList.publicEnrollmentList.DisplaylstEnrollmentRecords("","","","","","","", 10, 1);
                //                FamilyID = String.Empty; URNNO = String.Empty;
                //            }
                //            else
                //            {
                //                MessageBox.Show("This record is being used", CommonVariables.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //        }
                //    }
                //    break;

               
            }
        }

        #endregion

        #region "Edit Record"

        private void tsEdit_Click(object sender, EventArgs e)
        {
            FormEdit(ActiveMdiChild.Name);
        }

        private void FormEdit(String frmName)
        {
            switch (frmName)
            {
                case "UserMasterList":
                    if (UserMasterID != 0)
                    {
                        frmUserMasterAdd.UserID = UserMasterID;
                        frmUserMasterAdd.isAdd = false;
                        frmUserMasterAdd UserAdd = new frmUserMasterAdd();
                        UserAdd.ShowDialog();
                    }
                    break;

                case "frmStudentIdList":
                    if (StudentID != "")
                    {
                        frmCreateStudentID.StudentMasterID = StudentID;
                        frmCreateStudentID.isAdd = false;
                        frmCreateStudentID StudentAdd = new frmCreateStudentID();
                        StudentAdd.ShowDialog();
                    }
                    break;

                //case "frmBlockList":
                //    if (BlockCode != String.Empty && BlockCode != null)
                //    {
                //        frmBlockAdd.strBlockCode = BlockCode;;
                //        frmBlockAdd.isAdd = false;
                //        frmBlockAdd BlockAdd = new frmBlockAdd();
                //        BlockAdd.ShowDialog();
                //    }
                //    break;

                //case "frmPanchayatList":
                //    if (PanchayatCode != String.Empty && PanchayatCode != null)
                //    {
                //        frmPanchayatAdd.strPanchayatCode = PanchayatCode;
                //        frmPanchayatAdd.isAdd = false;
                //        frmPanchayatAdd PanchayatAdd = new frmPanchayatAdd();
                //        PanchayatAdd.ShowDialog();
                //    }
                //    break;

                //case "frmVillageList":
                //    if (VillageCode != String.Empty && VillageCode != null)
                //    {
                //        frmVillageAdd.strVillageCode = VillageCode;
                //        frmVillageAdd.isAdd = false;
                //        frmVillageAdd VillageAdd = new frmVillageAdd();
                //        VillageAdd.ShowDialog();
                //    }
                //    break;

                //case "frmDivisionList":
                //    if (DivisionID > 0)
                //    {
                //        frmDivisionAdd.DivisionID = DivisionID;
                //        frmDivisionAdd.isAdd = false;
                //        frmDivisionAdd DivisionAdd = new frmDivisionAdd();
                //        DivisionAdd.ShowDialog();
                //    }
                //    break;

                //case "frmSalaryGradeList":
                //    if (SalaryGradeCode != String.Empty && SalaryGradeCode != null)
                //    {
                //        frmSalaryGradeAdd.strSalaryGradeCode = SalaryGradeCode;
                //        frmSalaryGradeAdd.isAdd = false;
                //        frmSalaryGradeAdd SalaryGradeAdd = new frmSalaryGradeAdd();
                //        SalaryGradeAdd.ShowDialog();
                //    }
                //    break;

                //case "frmZoneMasterList":
                //    if (ZoneID != String.Empty && ZoneID != null)
                //    {
                //        frmZoneMasterAdd.strZoneID = ZoneID;
                //        frmZoneMasterAdd.isAdd = false;
                //        frmZoneMasterAdd ZoneMasterAdd = new frmZoneMasterAdd();
                //        ZoneMasterAdd.ShowDialog();
                //    }
                //    break;

                //case "frmEnrollmentList":
                //    if (FamilyID != String.Empty && URNNO != null)
                //    {
                //        frmEnrollmentAdd.strFamilyID = FamilyID;
                //        frmEnrollmentAdd.strURNNO = URNNO;
                //        frmEnrollmentAdd.isAdd = false;
                //        frmEnrollmentAdd EnrollmentAdd = new frmEnrollmentAdd();
                //        EnrollmentAdd.ShowDialog();
                //    }
                //    break;
            }
        }

        #endregion

        #region "Record Search"

        private void tsSearch_Click(object sender, EventArgs e)
        {
            FormSearch(ActiveMdiChild.Name);
        }

        private void FormSearch(String frmName)
        {
            switch (frmName)
            {
                case "frmStudentIdList":
                    frmStudentIdList.publicStudentIDList.grpSearchList.Visible = true;
                    frmStudentIdList.publicStudentIDList.grpSearchList.Left = (frmStudentIdList.publicStudentIDList.Width / 2) - (frmStudentIdList.publicStudentIDList.grpSearchList.Width);
                    frmStudentIdList.publicStudentIDList.txtStudentId.Text = "";
                    frmStudentIdList.publicStudentIDList.txtStudentId.Select();
                    break;

                case "UserMasterList":
                    UserMasterList.publicUserList.grpSearchList.Visible = true;
                    UserMasterList.publicUserList.grpSearchList.Left = (UserMasterList.publicUserList.Width / 2) - (UserMasterList.publicUserList.grpSearchList.Width);
                    UserMasterList.publicUserList.txtSearchText.Text = "";
                    UserMasterList.publicUserList.txtSearchText.Select();
                    break;

                //case "frmBlockList":
                //    frmBlockList.publicBlockList.grpSearchList.Visible = true;
                //    frmBlockList.publicBlockList.grpSearchList.Left = (frmBlockList.publicBlockList.Width / 2) - (frmBlockList.publicBlockList.grpSearchList.Width);
                //    frmBlockList.publicBlockList.txtBlockName.Text = "";
                //    frmBlockList.publicBlockList.txtBlockName.Select();
                //    break;

                //case "frmDistrictList":
                //    frmDistrictList.publicDistrictList.grpSearchList.Visible = true;
                //    frmDistrictList.publicDistrictList.grpSearchList.Left = (frmDistrictList.publicDistrictList.Width / 2) - (frmDistrictList.publicDistrictList.grpSearchList.Width);
                //    frmDistrictList.publicDistrictList.txtDistrictName.Text = "";
                //    frmDistrictList.publicDistrictList.txtDistrictName.Select();
                //    break;

                //case "frmStateList":
                //    frmStateList.publicStateList.grpSearchList.Visible = true;
                //    frmStateList.publicStateList.grpSearchList.Left = (frmStateList.publicStateList.Width / 2) - (frmStateList.publicStateList.grpSearchList.Width);
                //    frmStateList.publicStateList.txtStateName.Text = "";
                //    frmStateList.publicStateList.txtStateName.Select();
                //    break;

                //case "frmDivisionList":
                //    frmDivisionList.publicDivisionList.grpSearchList.Visible = true;
                //    frmDivisionList.publicDivisionList.grpSearchList.Left = (frmDivisionList.publicDivisionList.Width / 2) - (frmDivisionList.publicDivisionList.grpSearchList.Width);
                //    frmDivisionList.publicDivisionList.txtDivisionName.Text = "";
                //    frmDivisionList.publicDivisionList.txtDivisionName.Select();
                //    break;

                //case "frmSalaryGradeList":
                //    frmSalaryGradeList.publicSalaryGradeList.grpSearchList.Visible = true;
                //    frmSalaryGradeList.publicSalaryGradeList.grpSearchList.Left = (frmSalaryGradeList.publicSalaryGradeList.Width / 2) - (frmSalaryGradeList.publicSalaryGradeList.grpSearchList.Width);
                //    frmSalaryGradeList.publicSalaryGradeList.txtSalaryGrade.Text = "";
                //    frmSalaryGradeList.publicSalaryGradeList.txtSalaryGrade.Select();
                //    break;

                //case "frmZoneMasterList":
                //    frmZoneMasterList.publicZoneMasterList.grpSearchList.Visible = true;
                //    frmZoneMasterList.publicZoneMasterList.grpSearchList.Left = (frmZoneMasterList.publicZoneMasterList.Width / 2) - (frmZoneMasterList.publicZoneMasterList.grpSearchList.Width);
                //    frmZoneMasterList.publicZoneMasterList.txtZoneName.Text = "";
                //    frmZoneMasterList.publicZoneMasterList.txtZoneName.Select();
                //    break;

                //case "frmEnrollmentList":
                //    frmEnrollmentList.publicEnrollmentList.grpSearchList.Visible = true;
                //    frmEnrollmentList.publicEnrollmentList.grpSearchList.Left = (frmEnrollmentList.publicEnrollmentList.Width / 2) - (frmEnrollmentList.publicEnrollmentList.grpSearchList.Width);
                //    frmEnrollmentList.publicEnrollmentList.txtURNNo.Text = "";
                //    frmEnrollmentList.publicEnrollmentList.txtURNNo.Select();
                //    break;
            }
        }

        #endregion

        #region "Reload Form"

        private void tsReload1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            switch (ActiveMdiChild.Name)
            {
                //case "frmStudentIdList":
                //    frmStudentIdList.publicStudentIDList.DisplaylstStudentIDRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmPanchayatList":
                //    frmPanchayatList.publicPanchayatList.DisplaylstPanchayatRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmBlockList":
                //    frmBlockList.publicBlockList.DisplaylstBlockRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmDistrictList":
                //    frmDistrictList.publicDistrictList.DisplaylstDistrictRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmStateList":
                //    frmStateList.publicStateList.DisplaylstStateRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmDivisionList":
                //    frmDivisionList.publicDivisionList.DisplaylstDivisionRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmSalaryGradeList":
                //    frmSalaryGradeList.publicSalaryGradeList.DisplaylstSalaryGradeRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmZoneMasterList":
                //    frmZoneMasterList.publicZoneMasterList.DisplaylstZoneRecords();
                //    _MdiParent.MDIREFRESH();
                //    break;
                //case "frmEnrollmentList":
                //    frmEnrollmentList.publicEnrollmentList.isRefreshed = true;
                //    //frmEnrollmentList.publicEnrollmentList.DisplaylstEnrollmentRecords("", 10, 1);
                //    frmEnrollmentList.publicEnrollmentList.DisplaylstEnrollmentRecords("","","","","","","", 10, 1);
                //    _MdiParent.MDIREFRESH();
                //    break;
            }
        }

        #endregion

        private void tsHome_Click(object sender, EventArgs e)
        {
            MDIParent_Load(this, e);
        }

        private void cardIssueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmPrint")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmPrint stateList = new frmPrint();
            //stateList.Tag = this;
            //stateList.MdiParent = this;
            //stateList.Width = this.Width;
            //stateList.Height = this.Height;
            //stateList.Show();
        }

        private void dateWiseCardIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmRptDateWiseCardIssue")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmRptDateWiseCardIssue DateWiseCardIssue = new frmRptDateWiseCardIssue();
            //DateWiseCardIssue.Tag = this;
            //DateWiseCardIssue.MdiParent = this;
            //DateWiseCardIssue.Width = this.Width;
            //DateWiseCardIssue.Height = this.Height;
            //DateWiseCardIssue.Show();
        }

        private void enableReprintingOfCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    if (f.Name == "frmChangeCardEnrolledStatus")
            //        return;
            //    else
            //    {
            //        f.Close();
            //        f.Dispose();
            //    }
            //}
            //frmChangeCardEnrolledStatus ChangeCardEnrolledStatus = new frmChangeCardEnrolledStatus();
            //ChangeCardEnrolledStatus.Tag = this;
            //ChangeCardEnrolledStatus.MdiParent = this;
            //ChangeCardEnrolledStatus.Width = this.Width;
            //ChangeCardEnrolledStatus.Height = this.Height;
            //ChangeCardEnrolledStatus.Show();
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "UserMasterList")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            UserMasterList stateList = new UserMasterList();
            stateList.Tag = this;
            stateList.MdiParent = this;
            stateList.Width = this.Width;
            stateList.Height = this.Height;
            stateList.Show();
        }

        private void createStudentIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "frmStudentIdList")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            frmStudentIdList studentIDList = new frmStudentIdList();
            studentIDList.Tag = this;
            studentIDList.MdiParent = this;
            studentIDList.Width = this.Width;
            studentIDList.Height = this.Height;
            studentIDList.Show();
        }

        private void studentMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "frmStudent")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            frmStudent Student = new frmStudent();
            Student.Tag = this;
            Student.MdiParent = this;
            Student.Width = this.Width;
            Student.Height = this.Height;
            Student.Show();
        }

        private void verifiedStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "frmVerifiedList")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            frmVerifiedList VerifiedList = new frmVerifiedList();
            VerifiedList.Tag = this;
            VerifiedList.MdiParent = this;
            VerifiedList.Width = this.Width;
            VerifiedList.Height = this.Height;
            VerifiedList.Show();
        }

        private void verifyStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "frmVerifyStudent")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            frmVerifyStudent VerifyStudent = new frmVerifyStudent();
            VerifyStudent.Tag = this;
            VerifyStudent.MdiParent = this;
            VerifyStudent.Width = this.Width;
            VerifyStudent.Height = this.Height;
            VerifyStudent.Show();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsStudent objStudent = new clsStudent();
            clsUser objUser = new clsUser();
            ExcelUtilities Obj = new ExcelUtilities();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            var pass = objUser.GetExcelPassword();
            var mList = objStudent.GetAllStudentRecords();
            String _Path = System.Configuration.ConfigurationManager.AppSettings["ReportPath"].ToString();
            String _FileName = "Student_Record_" + DateTime.Now.ToString("dd-MM-yyyy")+ "-" + DateTime.Now.ToString("HH-mm-ss") +  ".xlsx";
            Cursor.Current = Cursors.AppStarting;
            if (Obj.WriteDataTableToExcel(converter.ToDataTable(mList), "Student_Record", _Path + _FileName, "Details", pass[0].Password))
            {
                MessageBox.Show("Data has been exported successfully & stored in " + _Path + _FileName, "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to export the data", "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
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

        private void tmrClock_Tick_1(object sender, EventArgs e)
        {
            lblClock.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void dateWiseActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == "frmRptDateWiseActivity")
                    return;
                else
                {
                    f.Close();
                    f.Dispose();
                }
            }
            frmRptDateWiseActivity DateWiseActivity = new frmRptDateWiseActivity();
            DateWiseActivity.Tag = this;
            DateWiseActivity.MdiParent = this;
            DateWiseActivity.Width = this.Width;
            DateWiseActivity.Height = this.Height;
            DateWiseActivity.Show();
        }

    }
}
