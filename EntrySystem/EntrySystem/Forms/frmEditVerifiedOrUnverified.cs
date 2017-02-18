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

namespace EntrySystem.Forms
{
    public partial class frmEditVerifiedOrUnverified : Form
    {
        public static String RegistrationNo;

        StudentMasterInfo objStudentMasterInfo = new StudentMasterInfo();
        clsStudent objStudent = new clsStudent();
        clsSubject objSubject = new clsSubject();
        List<StudentMasterInfo> _mList = new List<StudentMasterInfo>();
        public static String StudentId;

        public frmEditVerifiedOrUnverified()
        {
            InitializeComponent();
        }

        private void frmEditVerifiedOrUnverified_Load(object sender, EventArgs e)
        {
            if (StudentId == null || StudentId == "")
            {
                //this.ControlBox = false;
                //this.DoubleBuffered = true;
                //this.WindowState = FormWindowState.Maximized;
                //MDIParent frmMain = (MDIParent)this.Tag;
                //frmMain.MDIREFRESH();
                //frmMain.MDIDISABLED();
                StudentId = "";
            }
           // BindNatureOfEntry();
            ddlGender.SelectedIndex = 0; ddlCategory.SelectedIndex = 0; ddlPhysicallyChallange.SelectedIndex = 0; ddlTypeOfChallange.SelectedIndex = 0;
            if (StudentId.Length > 0)
            {
                txtGetStudentID.Text = StudentId;
            }
            GetRecordByRegistrationNo();
        }

        #region "User Functions"

        public void BindNatureOfEntry()
        {
            try
            {
                List<NatureOfEntry> list = new List<NatureOfEntry>
                {
                    new NatureOfEntry{ NatureName = "Correction" , NatureValue = "U"},
                    new NatureOfEntry{ NatureName = "Addition" , NatureValue = "A"},
                    new NatureOfEntry{ NatureName = "Deletion" ,NatureValue = "D" },
                };

                ddlNatureOfEntry.DataSource = list;
                ddlNatureOfEntry.DisplayMember = "NatureName";
                ddlNatureOfEntry.ValueMember = "NatureValue";
                ddlNatureOfEntry.Items.Insert(0, "-SELECT-");

            }
            catch (Exception ex)
            {
                // log.Error(ex.ToString());
            }
        }

        public void GetRecordByRegistrationNo()
        {
            lblMsg.Text = "";
            EnableDiableFields(false);
            ResetFields();

            _mList = objStudent.GetStudentRecordByRegNo(RegistrationNo.ToString().Trim());
            if (_mList.Count > 0)
            {
                txtGetStudentID.Text = _mList[0].StudentId;
                txtStudentID.Text = _mList[0].StudentId;

                txtRegNo1.Text = "";
                txtRegNo2.Text = "";
                txtRegNo3.Text = "";
                txtRegNo4.Text = "";
                txtRegNo5.Text = "";
                if (RegistrationNo.ToString().ToString().Trim().Length == 16)
                {
                    txtRegNo1.Text = (RegistrationNo.ToString().Substring(0, 2));
                    txtRegNo2.Text = (RegistrationNo.ToString().Substring(2, 2));
                    txtRegNo3.Text = (RegistrationNo.ToString().Substring(4, 4));
                    txtRegNo4.Text = (RegistrationNo.ToString().Substring(8, 6));
                    txtRegNo5.Text = (RegistrationNo.ToString().Substring(14, 2));
                }
                else if (RegistrationNo.ToString().ToString().Trim().Length == 17)
                {
                    txtRegNo1.Text = (RegistrationNo.ToString().Substring(0, 2));
                    txtRegNo2.Text = (RegistrationNo.ToString().Substring(2, 3));
                    txtRegNo3.Text = (RegistrationNo.ToString().Substring(5, 4));
                    txtRegNo4.Text = (RegistrationNo.ToString().Substring(9, 6));
                    txtRegNo5.Text = (RegistrationNo.ToString().Substring(15, 2));
                }
                // getStudentID();
                //txtStudentID.Text = txtGetStudentID.Text.ToString();

                BindMILSubject();
                BindLIUESubject();
                BindElectiveSubject();
                getStudentDetailByRegNo(_mList[0]);

                string districtcode = txtStudentID.Text.Substring(0, 2);
                if (districtcode == "15")
                    ddlLIUESubject.Enabled = true;
                else if (districtcode == "22")
                    ddlLIUESubject.Enabled = true;
                else
                    ddlLIUESubject.Enabled = false;

                if (txtStudentID.Text.Substring(2, 1) == "M")
                    ddlElectiveSubject.Enabled = false;

                SendKeys.Send("{TAB}");
            }
            else
            {
                txtGetStudentID.Text = "";
                txtStudentID.Text = ""; txtnameOfStudent.Text = ""; txtFatherName.Text = ""; txtMotherName.Text = ""; txtRegNo1.Text = ""; txtRegNo2.Text = ""; txtRegNo3.Text = ""; txtRegNo4.Text = ""; txtRegNo5.Text = "";
                txtDOB.Text = ""; //dtpDOB.Value = System.DateTime.Now;
                ddlGender.SelectedIndex = 0; ddlCategory.SelectedIndex = 0; ddlPhysicallyChallange.SelectedIndex = 0; ddlTypeOfChallange.SelectedIndex = 0; txtRemarks.Text = "";
                ddlAnnualFamilyIncome.SelectedIndex = 0; ddlMediumOfExam.SelectedIndex = 0; ddlMILSubject.DataSource = null; ddlMILGroup.SelectedIndex = 0; ddlLIUESubject.DataSource = null; ddlElectiveSubject.DataSource = null;
                lblMsg.Text = "Invalid Registration No";
                lblMsg.ForeColor = Color.Red;
                txtGetStudentID.Focus();
            }
        }

        private void EnableDiableFields(Boolean value)
        {
            // txtStudentID.Enabled = value;
            ddlNatureOfEntry.Enabled = value;
            txtnameOfStudent.Enabled = value;
            //txtRegNo1.Enabled = value;
            //txtRegNo2.Enabled = value;
            //txtRegNo3.Enabled = value;
            //txtRegNo4.Enabled = value;
            //txtRegNo5.Enabled = value;
            txtFatherName.Enabled = value;
            txtMotherName.Enabled = value;
            //dtpDOB.Enabled = value;
            txtDOB.Enabled = value;
            ddlAnnualFamilyIncome.Enabled = value;
            ddlMediumOfExam.Enabled = value;
            ddlMILSubject.Enabled = value;
            //ddlMILGroup.Enabled = value;
            ddlLIUESubject.Enabled = value;
            ddlElectiveSubject.Enabled = value;
            ddlGender.Enabled = value;
            ddlCategory.Enabled = value;
            ddlPhysicallyChallange.Enabled = value;
            //ddlTypeOfChallange.Enabled = value;
            txtRemarks.Enabled = value;
            btnSave.Enabled = value;
        }

        private void ResetFields()
        {
            ddlGender.SelectedIndex = 0;
            ddlCategory.SelectedIndex = 0;
            ddlPhysicallyChallange.SelectedIndex = 0;
            ddlTypeOfChallange.SelectedIndex = 0;
            ddlAnnualFamilyIncome.SelectedIndex = 0;
            ddlMediumOfExam.SelectedIndex = 0;
            txtRegNo1.Text = "";
            txtRegNo2.Text = "";
            txtRegNo3.Text = "";
            txtRegNo4.Text = "";
            txtRegNo5.Text = "";
            txtFatherName.Text = "";
            txtMotherName.Text = "";
            txtDOB.Text = "";
            ddlMediumOfExam.SelectedIndex = 0;
            if (ddlMILSubject.Items.Count > 0)
                ddlMILSubject.SelectedIndex = 0;
            else
                ddlMILSubject.SelectedIndex = -1;
            if (ddlMILGroup.Items.Count > 0)
                ddlMILGroup.SelectedIndex = 0;
            else
                ddlMILGroup.SelectedIndex = -1;
            if (ddlLIUESubject.Items.Count > 0)
                ddlLIUESubject.SelectedIndex = 0;
            else
                ddlLIUESubject.SelectedIndex = -1;
            if (ddlElectiveSubject.Items.Count > 0)
                ddlElectiveSubject.SelectedIndex = 0;
            else
                ddlElectiveSubject.SelectedIndex = -1;
            ddlGender.SelectedIndex = 0;
            txtRemarks.Text = "";
        }

        private void BindMILSubject()
        {
            List<SubjectMasterInfo> _mListMIL = new List<SubjectMasterInfo>();
            _mListMIL.Clear();
            _mListMIL = objSubject.GetSubject(txtGetStudentID.Text.Substring(2, 1), "MIL");
            if (_mListMIL.Count > 0)
            {
                _mListMIL.Insert(0, new SubjectMasterInfo { SubjectCode = "0", SubjectName = "-select-" });
                ddlMILSubject.DataSource = _mListMIL;
                ddlMILSubject.DisplayMember = "SubjectName";
                ddlMILSubject.ValueMember = "SubjectCode";
                // ddlMILSubject.Items.Insert(-1, "-SELECT-");
            }
        }

        private void BindLIUESubject()
        {
            List<SubjectMasterInfo> _mListLIUE = new List<SubjectMasterInfo>();
            _mListLIUE.Clear();
            _mListLIUE = objSubject.GetSubject(txtGetStudentID.Text.Substring(2, 1), "LIEU");
            if (_mListLIUE.Count > 0)
            {
                _mListLIUE.Insert(0, new SubjectMasterInfo { SubjectCode = "0", SubjectName = "-select-" });
                ddlLIUESubject.DataSource = _mListLIUE;
                ddlLIUESubject.DisplayMember = "SubjectName";
                ddlLIUESubject.ValueMember = "SubjectCode";
                // ddlLIUESubject.Items.Insert(-1, "-SELECT-");
            }
        }

        private void BindElectiveSubject()
        {
            List<SubjectMasterInfo> _mListELECTIVE = new List<SubjectMasterInfo>();
            _mListELECTIVE.Clear();
            _mListELECTIVE = objSubject.GetSubject(txtGetStudentID.Text.Substring(2, 1), "ELECTIVE");
            if (_mListELECTIVE.Count > 0)
            {
                _mListELECTIVE.Insert(0, new SubjectMasterInfo { SubjectCode = "0", SubjectName = "-select-" });
                ddlElectiveSubject.DataSource = _mListELECTIVE;
                ddlElectiveSubject.DisplayMember = "SubjectName";
                ddlElectiveSubject.ValueMember = "SubjectCode";
                // ddlElectiveSubject.Items.Insert(-1, "-SELECT-");
            }
        }

        private void getStudentDetailByRegNo(StudentMasterInfo m)
        {
            if (m.StudentId != "")
            {
                //txtStudentID.Text = _mList[0].StudentId;
                //ddlNatureOfEntry.SelectedValue = _mList[0].NatureOfEntry;
                txtnameOfStudent.Text = m.Name;
                txtFatherName.Text = m.FatherName;
                txtMotherName.Text = m.MotherName;

                if (txtnameOfStudent.Text.Length != 0 && m.NatureOfEntry != "A")
                {
                    BindNatureOfEntry_WithCollectedData();
                }
                else if (txtnameOfStudent.Text.Trim().Length == 0 && (m.NatureOfEntry != "U" || m.NatureOfEntry != "D"))
                {
                    BindNatureOfEntry_WithOutCollectedData();
                }
                else if (txtnameOfStudent.Text.Length != 0 && m.NatureOfEntry == "A")
                    BindNatureOfEntry_WithOutCollectedData();
                if (m.NatureOfEntry != "") ddlNatureOfEntry.SelectedValue = m.NatureOfEntry;             
                //txtDOB.Text = (Convert.ToDateTime(_mList[0].DateOfBirth).ToString("dd-MM-yyyy") == "01-01-1900" ? "" : (Convert.ToDateTime(_mList[0].DateOfBirth).ToString("dd-MM-yyyy")));
                if (m.DateOfBirth.ToString().Length == 8)
                {
                    txtDOB.Text = m.DateOfBirth.Substring(0, 2) + "-" + m.DateOfBirth.Substring(2, 2) + "-" + m.DateOfBirth.Substring(4, 4);
                }
                if (m.Gender == "M")
                    ddlGender.SelectedIndex = 1;
                else if (m.Gender == "F")
                    ddlGender.SelectedIndex = 2;
                else
                    ddlGender.SelectedIndex = 0;
                ddlCategory.Text = m.Category;
                switch (m.PhysicallyChallenged)
                {
                    case "N":
                        ddlPhysicallyChallange.Text = "NO";
                        break;
                    case "Y":
                        ddlPhysicallyChallange.Text = "YES";
                        break;
                    case "":
                        ddlPhysicallyChallange.SelectedIndex = 0;
                        break;
                }
                ddlTypeOfChallange.Text = m.TypeOfChallange;
                txtRemarks.Text = m.Remarks;

                if (m.Medium.Length <= 4)
                {
                    switch (m.Medium)
                    {
                        case "ASM":
                            ddlMediumOfExam.Text = "ASSAMESE";
                            break;
                        case "MAN":
                            ddlMediumOfExam.Text = "MANIPURI";
                            break;
                        case "BODO":
                            ddlMediumOfExam.Text = "BODO";
                            break;
                        case "ENG":
                            ddlMediumOfExam.Text = "ENGLISH";
                            break;
                        case "BEN":
                            ddlMediumOfExam.Text = "BENGALI";
                            break;
                        case "HIN":
                            ddlMediumOfExam.Text = "HINDI";
                            break;
                        default:
                            ddlMediumOfExam.SelectedIndex = 0;

                            break;
                    }
                }
                else
                {
                    ddlMediumOfExam.Text = m.Medium;
                }
                switch (m.FamilyIncome)
                {
                    case "N":
                        ddlAnnualFamilyIncome.Text = "NO";
                        break;
                    case "Y":
                        ddlAnnualFamilyIncome.Text = "YES";
                        break;
                    case "":
                        ddlAnnualFamilyIncome.SelectedIndex = 0;
                        break;
                }

                //ddlMediumOfExam.Text = m.Medium;
                ddlMILSubject.SelectedValue = m.MILSubjectCode;
                ddlMILGroup.Text = m.MILGroup;
                ddlLIUESubject.SelectedValue = m.LIEUSubjectCode;
                ddlElectiveSubject.SelectedValue = m.ElectiveSubjectCode;

                if ((m.IsVerified == true))
                {
                    EnableDiableFields(false);
                    ddlMILGroup.Enabled = false;
                    ddlPhysicallyChallange.Enabled = false;
                    lblMsg.Text = "This record has already verified";
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    EnableDiableFields(true);
                }
                string districtcode = txtStudentID.Text.Substring(0, 2);
                if (districtcode == "15")
                    ddlLIUESubject.Enabled = true;
                else if (districtcode == "22")
                    ddlLIUESubject.Enabled = true;
                else
                    ddlLIUESubject.Enabled = false;

                if (txtStudentID.Text.Substring(2, 1) == "M")
                    ddlElectiveSubject.Enabled = false;
            }
            else
            {
                txtnameOfStudent.Text = ""; txtFatherName.Text = ""; txtMotherName.Text = "";
                //txtRegNo1.Text = ""; txtRegNo2.Text = ""; txtRegNo3.Text = ""; txtRegNo4.Text = ""; txtRegNo5.Text = "";
                txtDOB.Text = "";//dtpDOB.Value = System.DateTime.Now;
                ddlGender.SelectedIndex = 0; ddlCategory.SelectedIndex = 0; ddlPhysicallyChallange.SelectedIndex = 0; ddlAnnualFamilyIncome.SelectedIndex = 0;
                ddlMediumOfExam.SelectedIndex = 0; ddlMILGroup.SelectedIndex = 0; txtRemarks.Text = "";
                EnableDiableFields(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validRegAlfa()
        {
            Boolean returnValue = false;
            if (txtStudentID.Text.Substring(2, 1) == "M")
            {
                if (txtRegNo2.Text == "GR")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "PR")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "RP")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "RV")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "UP")
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
            }
            else if (txtStudentID.Text.Substring(2, 1) == "H")
            {
                if (txtRegNo2.Text == "GR")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "PR")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "RP")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "RV")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "UV")
                {
                    returnValue = true;
                }
                else if (txtRegNo2.Text == "UP")
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                }
            }
            return returnValue;
        }

        private Boolean validateSubject(Int32 MILIndex, Int32 MILGroupIndex, Int32 LIEUIndex, Int32 ElectiveIndex)
        {
            Boolean returnVal = false;
            if (txtStudentID.Text.Substring(2, 1) == "M")
            {
                if (MILIndex > 0 && MILGroupIndex < 1 && ElectiveIndex < 1)
                {
                    returnVal = true;
                }
                else if (MILIndex < 1 && MILGroupIndex < 1 && ElectiveIndex < 1)
                    returnVal = true;
            }
            else if (txtStudentID.Text.Substring(2, 1) == "H")
            {
                string districtcode = txtStudentID.Text.Substring(0, 2);
                if (districtcode == "15" || districtcode == "22")
                {
                    if (MILIndex > 0 && MILGroupIndex > 0 && LIEUIndex < 1 && ElectiveIndex > 0)
                    {
                        returnVal = true;
                    }
                    else if (MILIndex < 1 && MILGroupIndex < 1 && LIEUIndex > 0 && ElectiveIndex > 0)
                        returnVal = true;
                    else if (MILIndex > 0 && MILGroupIndex < 1 && LIEUIndex < 1 && ElectiveIndex > 0)
                        returnVal = true;
                    else if (MILIndex < 1 && MILGroupIndex < 1 && LIEUIndex < 1 && ElectiveIndex < 1)
                        returnVal = true;
                }
                else if (MILIndex > 0 && MILGroupIndex < 1 && ElectiveIndex > 0)
                    returnVal = true;
                else if (MILIndex > 0 && MILGroupIndex > 0 && ElectiveIndex > 0)
                    returnVal = true;
                else if (MILIndex < 1 && MILGroupIndex < 1 && ElectiveIndex < 1)
                    returnVal = true;
                else if (MILIndex < 1 && MILGroupIndex < 1 && ElectiveIndex < 1)
                    returnVal = true;
            }

            return returnVal;
        }

        public Boolean CompareFieldsValues(StudentMasterInfo s)
        {
            Boolean success = false;
            Int32 ReturnVal = 0;
            if (txtnameOfStudent.Text.Trim() != s.Name.Trim())
            {
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Candidate_Name", s.Name.Trim().ToString(), txtnameOfStudent.Text.Trim(), Convert.ToInt32(CommonVariables.UserID), false);
            }

            if (txtFatherName.Text.Trim() != s.FatherName.Trim())
            {
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Father_Name", s.FatherName.Trim().ToString(), txtFatherName.Text.Trim(), Convert.ToInt32(CommonVariables.UserID), false);
            }

            if (txtMotherName.Text.Trim() != s.MotherName.Trim())
            {
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Mother_Name", s.MotherName.Trim().ToString(), txtMotherName.Text.Trim(), Convert.ToInt32(CommonVariables.UserID), false);
            }

            if ((txtDOB.Text.Substring(0, 2) + txtDOB.Text.Substring(3, 2) + txtDOB.Text.Substring(6, 4)) != s.DateOfBirth.Trim())
            {
                String NewDOB = (txtDOB.Text.Substring(0, 2) + txtDOB.Text.Substring(3, 2) + txtDOB.Text.Substring(6, 4));
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "DOB", s.DateOfBirth.Trim().ToString(), NewDOB.ToString(), Convert.ToInt32(CommonVariables.UserID), false);
            }

            if (ddlGender.SelectedIndex > 0)
            {
                if ((ddlGender.Text.Substring(0, 1) != s.Gender.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Gender", s.Gender.Trim().ToString(), ddlGender.Text.Substring(0, 1), Convert.ToInt32(CommonVariables.UserID), false);
                }
            }

            if (ddlCategory.SelectedIndex > 0)
            {
                if ((ddlCategory.Text != s.Category.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Category", s.Category.Trim().ToString(), ddlCategory.Text, Convert.ToInt32(CommonVariables.UserID), false);
                }
            }

            if (ddlPhysicallyChallange.SelectedIndex > 0)
            {
                String TypPH = "";
                if ((ddlPhysicallyChallange.Text.Substring(0, 1) != s.PhysicallyChallenged.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "PH", s.PhysicallyChallenged.Trim().ToString(), ddlPhysicallyChallange.Text.Substring(0, 1), Convert.ToInt32(CommonVariables.UserID), false);
                    TypPH = ddlTypeOfChallange.SelectedIndex > 0 ? ddlTypeOfChallange.Text : "";
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "PH_Type", s.TypeOfChallange.Trim().ToString(), TypPH.ToString(), Convert.ToInt32(CommonVariables.UserID), false);

                }

                //if (s.TypeOfChallange != ddlTypeOfChallange.Text && s.PhysicallyChallenged == "Y")
                //{
                //    if (ddlTypeOfChallange.SelectedIndex > 0)
                //        TypPH = ddlTypeOfChallange.Text;
                //    else
                //        TypPH = "";
                //}
            }

            //if (ddlTypeOfChallange.SelectedIndex > 0)
            //{
            //    if ((ddlTypeOfChallange.Text != s.TypeOfChallange.Trim()) && (s.PhysicallyChallenged == "Y"))
            //    {
            //        ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "PH_Type", s.TypeOfChallange.Trim().ToString(), ddlTypeOfChallange.Text, Convert.ToInt32(CommonVariables.UserID), false);
            //    }
            //}

            if (txtRemarks.Text.Trim() != s.Remarks.Trim())
            {
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Remarks", s.Remarks.Trim().ToString(), txtRemarks.Text.Trim(), Convert.ToInt32(CommonVariables.UserID), false);
            }

            if (ddlAnnualFamilyIncome.SelectedIndex > 0)
            {
                if ((ddlAnnualFamilyIncome.Text.Substring(0, 1) != s.FamilyIncome.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Family_Income_Upto_Rs1Lac", s.FamilyIncome.Trim().ToString(), ddlAnnualFamilyIncome.Text.Substring(0, 1), Convert.ToInt32(CommonVariables.UserID), false);
                }
            }

            if (ddlMediumOfExam.SelectedIndex > 0)
            {
                if ((ddlMediumOfExam.Text.ToString().Trim() != s.Medium.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "Medium", s.Medium.Trim().ToString(), ddlMediumOfExam.Text.ToString().Trim(), Convert.ToInt32(CommonVariables.UserID), false);
                }
            }

            if (ddlMILSubject.SelectedIndex > 0)
            {
                if ((ddlMILSubject.SelectedValue.ToString().Trim() != s.MILSubjectCode.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "MIL_Sub", s.MIL_Subject.Trim().ToString(), ddlMILSubject.Text, Convert.ToInt32(CommonVariables.UserID), false);
                }
            }
            if (ddlMILSubject.SelectedIndex == 0 && s.MIL_Subject != "")
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "MIL_Sub", s.MIL_Subject.Trim().ToString(), "", Convert.ToInt32(CommonVariables.UserID), false);


            if (ddlMILGroup.SelectedIndex > 0)
            {
                if ((ddlMILGroup.Text.ToString().Trim() != s.MILGroup.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "MIL_Group", s.MILGroup.Trim().ToString(), ddlMILGroup.Text.ToString().Trim(), Convert.ToInt32(CommonVariables.UserID), false);
                }
            }
            if (ddlMILGroup.SelectedIndex == 0 && s.MILGroup != "")
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "MIL_Group", s.MILGroup.Trim().ToString(), "", Convert.ToInt32(CommonVariables.UserID), false);
            if (ddlLIUESubject.SelectedIndex > 0)
            {
                if ((ddlLIUESubject.SelectedValue.ToString().Trim() != s.LIEUSubjectCode.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "LIEU_Sub", s.LIEUSubject.Trim().ToString(), ddlLIUESubject.Text, Convert.ToInt32(CommonVariables.UserID), false);
                }
            }
            if (s.LIEUSubjectCode.Trim() != "" && ddlLIUESubject.SelectedIndex == 0)
            {
                ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "LIEU_Sub", s.LIEUSubject.Trim().ToString(), "", Convert.ToInt32(CommonVariables.UserID), false);

            }
            if (ddlElectiveSubject.SelectedIndex > 0)
            {
                if ((ddlElectiveSubject.SelectedValue.ToString().Trim() != s.ElectiveSubjectCode.Trim()))
                {
                    ReturnVal = objStudent.InsertActivityLog(txtStudentID.Text, "ELEC_Sub", s.ElectiveSubject.Trim().ToString(), ddlElectiveSubject.Text, Convert.ToInt32(CommonVariables.UserID), false);
                }
            }

            if (ReturnVal > 0)
            {
                success = true;
            }

            return success;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            DateTime tempDOB;
            Int32 _returnvalue = 0;
            Boolean IsVerified = false;
            Boolean IsDeleted = false;
            if (ddlNatureOfEntry.Text == "Addition")
            {
                if (txtStudentID.Text.Length == 0)
                {
                    lblMsg.Text = "Student ID cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtStudentID.Focus();
                    return;
                }

                if (txtnameOfStudent.Text.Length == 0)
                {
                    lblMsg.Text = "Name of student cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtnameOfStudent.Focus();
                    return;
                }

                if (((txtRegNo1.Text.Length) + (txtRegNo2.Text.Length) + (txtRegNo3.Text.Length) + (txtRegNo4.Text.Length) + (txtRegNo5.Text.Length)) < 16)
                {
                    lblMsg.Text = "Registration no is not correct";
                    lblMsg.ForeColor = Color.Red;
                    txtRegNo1.Focus();
                    return;
                }
                if (!validRegAlfa())
                {
                    lblMsg.Text = "Invalid registration no.";
                    lblMsg.ForeColor = Color.Red;
                    txtRegNo1.Focus();
                    return;
                }

                if (txtFatherName.Text.Length == 0)
                {
                    lblMsg.Text = "Father name cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtFatherName.Focus();
                    return;
                }

                if (txtMotherName.Text.Length == 0)
                {
                    lblMsg.Text = "Mother name cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtMotherName.Focus();
                    return;
                }

                if (txtDOB.Text.Length == 0)
                {
                    lblMsg.Text = "Date of Birth cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtDOB.Focus();
                    return;
                }

                if (txtDOB.Text.Length != 0)
                {
                    if (!DateTime.TryParse(txtDOB.Text, out tempDOB))
                    {
                        lblMsg.Text = "Invalid date of birth";
                        lblMsg.ForeColor = Color.Red;
                        txtDOB.Focus();
                        return;
                    }
                }
                if (ddlGender.SelectedIndex == 0)
                {
                    lblMsg.Text = "Please select gender";
                    lblMsg.ForeColor = Color.Red;
                    ddlGender.Focus();
                    return;
                }

                if (ddlCategory.SelectedIndex == 0)
                {
                    lblMsg.Text = "Please select category";
                    lblMsg.ForeColor = Color.Red;
                    ddlCategory.Focus();
                    return;
                }

                if (ddlPhysicallyChallange.SelectedIndex == 0)
                {
                    lblMsg.Text = "Please select Physically Challanged ";
                    lblMsg.ForeColor = Color.Red;
                    ddlPhysicallyChallange.Focus();
                    return;
                }

                if (ddlPhysicallyChallange.Text == "YES")
                {
                    if (ddlTypeOfChallange.SelectedIndex == 0)
                    {
                        lblMsg.Text = "Please select Type of Challange";
                        lblMsg.ForeColor = Color.Red;
                        ddlTypeOfChallange.Focus();
                        return;
                    }
                }

                if (ddlAnnualFamilyIncome.SelectedIndex == 0)
                {
                    lblMsg.Text = "Please select Annual Family income";
                    lblMsg.ForeColor = Color.Red;
                    ddlAnnualFamilyIncome.Focus();
                    return;
                }

                if (ddlMediumOfExam.SelectedIndex == 0)
                {
                    lblMsg.Text = "Please select Medium Of Exam";
                    lblMsg.ForeColor = Color.Red;
                    ddlMediumOfExam.Focus();
                    return;
                }
                if (ddlMILSubject.Enabled)
                {
                    if (ddlMILSubject.Items.Count > 0)
                    {
                        if (ddlMILSubject.SelectedIndex == 0)
                        {
                            lblMsg.Text = "Please select MIL Subject";
                            lblMsg.ForeColor = Color.Red;
                            ddlMILSubject.Focus();
                            return;
                        }
                    }
                }

                if (ddlMILGroup.Enabled)
                {
                    if (ddlMILSubject.SelectedIndex > 0)
                    {
                        if (ddlMILGroup.SelectedIndex == 0)
                        {
                            lblMsg.Text = "Please select MIL Group";
                            lblMsg.ForeColor = Color.Red;
                            ddlMILGroup.Focus();
                            return;
                        }
                    }
                }

                if (ddlLIUESubject.Enabled)
                {
                    if (ddlLIUESubject.Items.Count > 0)
                    {
                        if (ddlLIUESubject.SelectedIndex == 0)
                        {
                            lblMsg.Text = "Please select LIUE Subject";
                            lblMsg.ForeColor = Color.Red;
                            ddlLIUESubject.Focus();
                            return;
                        }
                    }
                }

                if (ddlElectiveSubject.Enabled)
                {
                    if (ddlElectiveSubject.Items.Count > 0)
                    {
                        if (ddlElectiveSubject.SelectedIndex == 0)
                        {
                            lblMsg.Text = "Please select Elective Subject";
                            lblMsg.ForeColor = Color.Red;
                            ddlElectiveSubject.Focus();
                            return;
                        }
                    }
                }

                if (!validateSubject(ddlMILSubject.SelectedIndex, ddlMILGroup.SelectedIndex, ddlLIUESubject.SelectedIndex, ddlElectiveSubject.SelectedIndex))
                {
                    lblMsg.Text = "Please correct subject combination.";
                    lblMsg.ForeColor = Color.Red;
                    return;
                }

                String GetRegistrationNo = (txtRegNo1.Text) + (txtRegNo2.Text) + (txtRegNo3.Text) + (txtRegNo4.Text) + (txtRegNo5.Text);

                objStudentMasterInfo.StudentId = txtStudentID.Text;
                objStudentMasterInfo.NatureOfEntry = ddlNatureOfEntry.SelectedValue.ToString();
                objStudentMasterInfo.Name = txtnameOfStudent.Text;
                objStudentMasterInfo.RegistrationNo = GetRegistrationNo.ToString();
                objStudentMasterInfo.FatherName = txtFatherName.Text;

                objStudentMasterInfo.MotherName = txtMotherName.Text;
                if (txtDOB.Text.Length > 0)
                {
                    objStudentMasterInfo.DateOfBirth = (txtDOB.Text.Substring(0, 2) + txtDOB.Text.Substring(3, 2) + txtDOB.Text.Substring(6, 4));
                }
                else
                {
                    objStudentMasterInfo.DateOfBirth = "";
                }

                objStudentMasterInfo.Gender = (ddlGender.Text == "MALE" ? "M" : "F"); //ddlGender.Text;

                if (ddlCategory.SelectedIndex > 0)
                    objStudentMasterInfo.Category = ddlCategory.Text;
                else
                    objStudentMasterInfo.Category = "";

                if (ddlPhysicallyChallange.SelectedIndex > 0)
                    objStudentMasterInfo.PhysicallyChallenged = (ddlPhysicallyChallange.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.PhysicallyChallenged = "";

                //objStudentMasterInfo.PhysicallyChallenged = (ddlPhysicallyChallange.Text);

                if (ddlTypeOfChallange.SelectedIndex > 0)
                    objStudentMasterInfo.TypeOfChallange = ddlTypeOfChallange.Text;
                else
                    objStudentMasterInfo.TypeOfChallange = "";

                objStudentMasterInfo.Remarks = txtRemarks.Text;

                if (ddlAnnualFamilyIncome.SelectedIndex > 0)
                    objStudentMasterInfo.FamilyIncome = (ddlAnnualFamilyIncome.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.FamilyIncome = "";

                if (ddlMediumOfExam.SelectedIndex > 0)
                    objStudentMasterInfo.Medium = ddlMediumOfExam.Text;
                else
                    objStudentMasterInfo.Medium = "";

                if (ddlMILSubject.Enabled)
                {
                    if (ddlMILSubject.Items.Count > 0)
                    {
                        if (ddlMILSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.MILSubjectCode = ddlMILSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text.Substring(0, ddlMILSubject.Text.Length - 5);
                            objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.MILSubjectCode = "";
                            objStudentMasterInfo.MIL_Subject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.MILSubjectCode = "";
                        objStudentMasterInfo.MIL_Subject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.MILSubjectCode = "";
                    objStudentMasterInfo.MIL_Subject = "";
                }

                if (ddlMILGroup.Enabled)
                {
                    if (ddlMILGroup.SelectedIndex == 0)
                    {
                        lblMsg.Text = "Please select MIL Group";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }

                if (ddlMILGroup.SelectedIndex > 0)
                    objStudentMasterInfo.MILGroup = ddlMILGroup.Text;
                else
                    objStudentMasterInfo.MILGroup = "";

                if (ddlLIUESubject.Enabled)
                {
                    if (ddlLIUESubject.Items.Count > 0)
                    {
                        if (ddlLIUESubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.LIEUSubjectCode = ddlLIUESubject.SelectedValue.ToString();
                            //objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text.Substring(0, ddlLIUESubject.Text.Length - 5);
                            objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.LIEUSubjectCode = "";
                            objStudentMasterInfo.LIEUSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.LIEUSubjectCode = "";
                        objStudentMasterInfo.LIEUSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.LIEUSubjectCode = "";
                    objStudentMasterInfo.LIEUSubject = "";
                }

                if (ddlElectiveSubject.Enabled)
                {
                    if (ddlElectiveSubject.Items.Count > 0)
                    {
                        if (ddlElectiveSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = ddlElectiveSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text.Substring(0, ddlElectiveSubject.Text.Length - 5);
                            objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = "";
                            objStudentMasterInfo.ElectiveSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.ElectiveSubjectCode = "";
                        objStudentMasterInfo.ElectiveSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.ElectiveSubjectCode = "";
                    objStudentMasterInfo.ElectiveSubject = "";
                }
              
                objStudentMasterInfo.CreatedBy = Convert.ToInt32(CommonVariables.UserID);

                try
                {
                    CompareFieldsValues(_mList[0]);

                    _returnvalue = objStudent.UpdateStudentMaster(objStudentMasterInfo);
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully inserted the data";
                        lblMsg.ForeColor = Color.Green;
                        this.Close();
                        frmVerifyStudent.publicVerifyStudent.populatePendingRecord();
                    }
                    else
                    {
                        lblMsg.Text = "Cannot insert data.";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            if (ddlNatureOfEntry.Text == "Correction")
            {
                if (txtStudentID.Text.Length == 0)
                {
                    lblMsg.Text = "Student id can't blank";
                    lblMsg.ForeColor = Color.Red;
                    txtStudentID.Focus();
                    return;
                }

                String regNo = ((txtRegNo1.Text.Length) + (txtRegNo2.Text.Length) + (txtRegNo3.Text.Length) + (txtRegNo4.Text.Length) + (txtRegNo5.Text.Length)).ToString();

                if (Convert.ToInt32(regNo) != 0)
                {
                    if (Convert.ToInt32(regNo) < 16)
                    {
                        lblMsg.Text = "Registration no not correct";
                        lblMsg.ForeColor = Color.Red;
                        txtRegNo1.Focus();
                        return;
                    }

                    if (!validRegAlfa())
                    {
                        lblMsg.Text = "Invalid registration no.";
                        lblMsg.ForeColor = Color.Red;
                        txtRegNo1.Focus();
                        return;
                    }
                }

                if (txtDOB.Text.Length != 0)
                {
                    if (!DateTime.TryParse(txtDOB.Text, out tempDOB))
                    {
                        lblMsg.Text = "Invalid date of birth";
                        lblMsg.ForeColor = Color.Red;
                        txtDOB.Focus();
                        return;
                    }
                }
                if (ddlPhysicallyChallange.Text == "YES")
                {
                    if (ddlTypeOfChallange.SelectedIndex == 0)
                    {
                        lblMsg.Text = "Please select Type of Challange";
                        lblMsg.ForeColor = Color.Red;
                        ddlTypeOfChallange.Focus();
                        return;
                    }
                }
                if ((txtnameOfStudent.Text.Length == 0) && (txtDOB.Text.Length == 0) && (Convert.ToInt32(regNo) < 16) && (txtFatherName.Text.Length == 0) && (txtFatherName.Text.Length == 0) && (txtMotherName.Text.Length == 0) && (ddlGender.SelectedIndex == 0) && (ddlCategory.SelectedIndex == 0) && (ddlPhysicallyChallange.SelectedIndex == 0) && (ddlTypeOfChallange.SelectedIndex == 0) && (txtRemarks.Text.Length == 0) && (ddlAnnualFamilyIncome.SelectedIndex == 0) && (ddlMediumOfExam.SelectedIndex == 0) && (ddlMILSubject.SelectedIndex == 0) && (ddlMILGroup.SelectedIndex == 0) && (ddlLIUESubject.SelectedIndex == 0) && (ddlElectiveSubject.SelectedIndex == 0))
                {
                    lblMsg.Text = "Please enter atleast one record";
                    lblMsg.ForeColor = Color.Red;
                    return;
                }


                String GetRegistrationNo = (txtRegNo1.Text) + (txtRegNo2.Text) + (txtRegNo3.Text) + (txtRegNo4.Text) + (txtRegNo5.Text);

                objStudentMasterInfo.StudentId = txtStudentID.Text;
                objStudentMasterInfo.NatureOfEntry = ddlNatureOfEntry.SelectedValue.ToString();
                objStudentMasterInfo.Name = txtnameOfStudent.Text;
                objStudentMasterInfo.RegistrationNo = GetRegistrationNo.ToString();
                objStudentMasterInfo.FatherName = txtFatherName.Text;
                objStudentMasterInfo.MotherName = txtMotherName.Text;


                if (txtDOB.Text.Length > 0)
                {
                    objStudentMasterInfo.DateOfBirth = (txtDOB.Text.Substring(0, 2) + txtDOB.Text.Substring(3, 2) + txtDOB.Text.Substring(6, 4));
                }
                else
                {
                    objStudentMasterInfo.DateOfBirth = "";
                }


                //if (txtDOB.Text.Length > 0)
                //    objStudentMasterInfo.DateOfBirth = txtDOB.Text;
                //else
                //    objStudentMasterInfo.DateOfBirth = "1900-01-01";

                if (ddlGender.SelectedIndex > 0)
                    objStudentMasterInfo.Gender = (ddlGender.Text == "MALE" ? "M" : "F"); //ddlGender.Text;
                else
                    objStudentMasterInfo.Gender = "";

                if (ddlCategory.SelectedIndex > 0)
                    objStudentMasterInfo.Category = ddlCategory.Text;
                else
                    objStudentMasterInfo.Category = "";

                if (ddlPhysicallyChallange.SelectedIndex > 0)
                    objStudentMasterInfo.PhysicallyChallenged = (ddlPhysicallyChallange.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.PhysicallyChallenged = "";

                if (ddlTypeOfChallange.SelectedIndex > 0)
                    objStudentMasterInfo.TypeOfChallange = ddlTypeOfChallange.Text;
                else
                    objStudentMasterInfo.TypeOfChallange = "";

                objStudentMasterInfo.Remarks = txtRemarks.Text;

                if (ddlAnnualFamilyIncome.SelectedIndex > 0)
                    objStudentMasterInfo.FamilyIncome = (ddlAnnualFamilyIncome.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.FamilyIncome = "";

                if (ddlMediumOfExam.SelectedIndex > 0)
                    objStudentMasterInfo.Medium = ddlMediumOfExam.Text;
                else
                    objStudentMasterInfo.Medium = "";

                if (ddlMILSubject.Enabled)
                {
                    if (ddlMILSubject.Items.Count > 0)
                    {
                        if (ddlMILSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.MILSubjectCode = ddlMILSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text.Substring(0, ddlMILSubject.Text.Length - 5);
                            objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.MILSubjectCode = "";
                            objStudentMasterInfo.MIL_Subject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.MILSubjectCode = "";
                        objStudentMasterInfo.MIL_Subject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.MILSubjectCode = "";
                    objStudentMasterInfo.MIL_Subject = "";
                }

                if (ddlMILGroup.Enabled)
                {
                    if (ddlMILGroup.SelectedIndex == 0)
                    {
                        lblMsg.Text = "Please select MIL Group";
                        lblMsg.ForeColor = Color.Red;
                        ddlMILGroup.Focus();
                        return;
                    }
                }

                if (ddlMILGroup.SelectedIndex > 0)
                    objStudentMasterInfo.MILGroup = ddlMILGroup.Text;
                else
                    objStudentMasterInfo.MILGroup = "";

                if (ddlLIUESubject.Enabled)
                {
                    if (ddlLIUESubject.Items.Count > 0)
                    {
                        if (ddlLIUESubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.LIEUSubjectCode = ddlLIUESubject.SelectedValue.ToString();
                            //objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text.Substring(0, ddlLIUESubject.Text.Length - 5);
                            objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.LIEUSubjectCode = "";
                            objStudentMasterInfo.LIEUSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.LIEUSubjectCode = "";
                        objStudentMasterInfo.LIEUSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.LIEUSubjectCode = "";
                    objStudentMasterInfo.LIEUSubject = "";
                }

                if (ddlElectiveSubject.Enabled)
                {
                    if (ddlElectiveSubject.Items.Count > 0)
                    {
                        if (ddlElectiveSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = ddlElectiveSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text.Substring(0, ddlElectiveSubject.Text.Length - 5);
                            objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = "";
                            objStudentMasterInfo.ElectiveSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.ElectiveSubjectCode = "";
                        objStudentMasterInfo.ElectiveSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.ElectiveSubjectCode = "";
                    objStudentMasterInfo.ElectiveSubject = "";
                }

                if (!validateSubject(ddlMILSubject.SelectedIndex, ddlMILGroup.SelectedIndex, ddlLIUESubject.SelectedIndex, ddlElectiveSubject.SelectedIndex))
                {
                    lblMsg.Text = "Please correct subject combination.";
                    lblMsg.ForeColor = Color.Red;
                    return;
                }

                objStudentMasterInfo.ModifiedBy = Convert.ToInt32(CommonVariables.UserID);

                try
                {
                    CompareFieldsValues(_mList[0]);

                    _returnvalue = objStudent.UpdateStudentMaster(objStudentMasterInfo);
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully updated the data";
                        lblMsg.ForeColor = Color.Green;
                        this.Close();
                        frmVerifyStudent.publicVerifyStudent.populatePendingRecord();
                    }
                    else
                    {
                        lblMsg.Text = "Record not available to update";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            if (ddlNatureOfEntry.Text == "Deletion")
            {
                if (txtStudentID.Text.Length == 0)
                {
                    lblMsg.Text = "Student id cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtStudentID.Focus();
                    return;
                }

                if (txtnameOfStudent.Text.Length == 0)
                {
                    lblMsg.Text = "Name of student cannot be blank";
                    lblMsg.ForeColor = Color.Red;
                    txtnameOfStudent.Focus();
                    return;
                }

                if (((txtRegNo1.Text.Length) + (txtRegNo2.Text.Length) + (txtRegNo3.Text.Length) + (txtRegNo4.Text.Length) + (txtRegNo5.Text.Length)) < 16)
                {
                    lblMsg.Text = "Registration no is not correct";
                    txtRegNo1.Focus();
                    lblMsg.ForeColor = Color.Red;
                    return;
                }
                if (!validRegAlfa())
                {
                    lblMsg.Text = "Invalid registration no.";
                    lblMsg.ForeColor = Color.Red;
                    txtRegNo1.Focus();
                    return;
                }

                //==================================== Extra Work =====================================
                if (txtDOB.Text.Length != 0)
                {
                    if (!DateTime.TryParse(txtDOB.Text, out tempDOB))
                    {
                        lblMsg.Text = "Invalid date of birth";
                        lblMsg.ForeColor = Color.Red;
                        txtDOB.Focus();
                        return;
                    }
                }

                if (ddlPhysicallyChallange.Text == "YES")
                {
                    if (ddlTypeOfChallange.SelectedIndex == 0)
                    {
                        lblMsg.Text = "Please select Type of Challange";
                        lblMsg.ForeColor = Color.Red;
                        ddlTypeOfChallange.Focus();
                        return;
                    }
                }

                String RegistrationNo = (txtRegNo1.Text) + (txtRegNo2.Text) + (txtRegNo3.Text) + (txtRegNo4.Text) + (txtRegNo5.Text);

                objStudentMasterInfo.StudentId = txtStudentID.Text;
                objStudentMasterInfo.NatureOfEntry = ddlNatureOfEntry.SelectedValue.ToString();
                objStudentMasterInfo.Name = txtnameOfStudent.Text;
                objStudentMasterInfo.RegistrationNo = RegistrationNo.ToString();
                objStudentMasterInfo.FatherName = txtFatherName.Text;
                objStudentMasterInfo.MotherName = txtMotherName.Text;

                if (txtDOB.Text.Length > 0)
                {
                    objStudentMasterInfo.DateOfBirth = (txtDOB.Text.Substring(0, 2) + txtDOB.Text.Substring(3, 2) + txtDOB.Text.Substring(6, 4));
                }
                else
                {
                    objStudentMasterInfo.DateOfBirth = "";
                }

                if (ddlGender.SelectedIndex > 0)
                    objStudentMasterInfo.Gender = (ddlGender.Text == "MALE" ? "M" : "F"); //ddlGender.Text;
                else
                    objStudentMasterInfo.Gender = "";

                if (ddlCategory.SelectedIndex > 0)
                    objStudentMasterInfo.Category = ddlCategory.Text;
                else
                    objStudentMasterInfo.Category = "";

                if (ddlPhysicallyChallange.SelectedIndex > 0)
                    objStudentMasterInfo.PhysicallyChallenged = (ddlPhysicallyChallange.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.PhysicallyChallenged = "";

                if (ddlTypeOfChallange.SelectedIndex > 0)
                    objStudentMasterInfo.TypeOfChallange = ddlTypeOfChallange.Text;
                else
                    objStudentMasterInfo.TypeOfChallange = "";

                objStudentMasterInfo.Remarks = txtRemarks.Text;

                if (ddlAnnualFamilyIncome.SelectedIndex > 0)
                    objStudentMasterInfo.FamilyIncome = (ddlAnnualFamilyIncome.Text.Substring(0, 1));
                else
                    objStudentMasterInfo.FamilyIncome = "";

                if (ddlMediumOfExam.SelectedIndex > 0)
                    objStudentMasterInfo.Medium = ddlMediumOfExam.Text;
                else
                    objStudentMasterInfo.Medium = "";

                if (ddlMILSubject.Enabled)
                {
                    if (ddlMILSubject.Items.Count > 0)
                    {
                        if (ddlMILSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.MILSubjectCode = ddlMILSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text.Substring(0, ddlMILSubject.Text.Length - 5);
                            objStudentMasterInfo.MIL_Subject = ddlMILSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.MILSubjectCode = "";
                            objStudentMasterInfo.MIL_Subject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.MILSubjectCode = "";
                        objStudentMasterInfo.MIL_Subject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.MILSubjectCode = "";
                    objStudentMasterInfo.MIL_Subject = "";
                }

                if (ddlMILGroup.SelectedIndex > 0)
                    objStudentMasterInfo.MILGroup = ddlMILGroup.Text;
                else
                    objStudentMasterInfo.MILGroup = "";

                if (ddlLIUESubject.Enabled)
                {
                    if (ddlLIUESubject.Items.Count > 0)
                    {
                        if (ddlLIUESubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.LIEUSubjectCode = ddlLIUESubject.SelectedValue.ToString();
                            //objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text.Substring(0, ddlLIUESubject.Text.Length - 5);
                            objStudentMasterInfo.LIEUSubject = ddlLIUESubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.LIEUSubjectCode = "";
                            objStudentMasterInfo.LIEUSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.LIEUSubjectCode = "";
                        objStudentMasterInfo.LIEUSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.LIEUSubjectCode = "";
                    objStudentMasterInfo.LIEUSubject = "";
                }

                if (ddlElectiveSubject.Enabled)
                {
                    if (ddlElectiveSubject.Items.Count > 0)
                    {
                        if (ddlElectiveSubject.SelectedIndex > 0)
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = ddlElectiveSubject.SelectedValue.ToString();
                            //objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text.Substring(0, ddlElectiveSubject.Text.Length - 5);
                            objStudentMasterInfo.ElectiveSubject = ddlElectiveSubject.Text;
                        }
                        else
                        {
                            objStudentMasterInfo.ElectiveSubjectCode = "";
                            objStudentMasterInfo.ElectiveSubject = "";
                        }
                    }
                    else
                    {
                        objStudentMasterInfo.ElectiveSubjectCode = "";
                        objStudentMasterInfo.ElectiveSubject = "";
                    }
                }
                else
                {
                    objStudentMasterInfo.ElectiveSubjectCode = "";
                    objStudentMasterInfo.ElectiveSubject = "";
                }

                if (!validateSubject(ddlMILSubject.SelectedIndex, ddlMILGroup.SelectedIndex, ddlLIUESubject.SelectedIndex, ddlElectiveSubject.SelectedIndex))
                {
                    lblMsg.Text = "Please correct subject combination.";
                    lblMsg.ForeColor = Color.Red;
                    return;
                }

                objStudentMasterInfo.ModifiedBy = Convert.ToInt32(CommonVariables.UserID);
                //======================================================

                try
                {
                    //String RegistrationNo = (txtRegNo1.Text) + (txtRegNo2.Text) + (txtRegNo3.Text) + (txtRegNo4.Text) + (txtRegNo5.Text);

                    CompareFieldsValues(_mList[0]);

                   // _returnvalue = objStudent.DeleteStudentMaster(txtStudentID.Text, txtnameOfStudent.Text, RegistrationNo, Convert.ToInt32(CommonVariables.UserID), ddlNatureOfEntry.SelectedValue.ToString());
                    _returnvalue = objStudent.UpdateStudentMaster(objStudentMasterInfo);
                    if (_returnvalue > 0)
                    {
                        lblMsg.Text = "Successfully deleted the data";
                        lblMsg.ForeColor = Color.Green;
                        this.Close();
                        frmVerifyStudent.publicVerifyStudent.populatePendingRecord();
                    }
                    else
                    {
                        lblMsg.Text = "Record not available to delete";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
            }

            //btnSave.Enabled = false;
        }

        #region "Key Events"

        private void txtRegNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRegNo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRegNo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRegNo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ddlPhysicallyChallange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPhysicallyChallange.SelectedIndex == 1)
            {
                ddlTypeOfChallange.Enabled = true;
                ddlTypeOfChallange.SelectedIndex = 0;
            }
            else
            {
                ddlTypeOfChallange.Enabled = false;
                ddlTypeOfChallange.SelectedIndex = 0;
            }
        }

        private void txtRegNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtGetStudentID.Text.Length == 13)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                if (txtGetStudentID.Text.Substring(2, 1) == "M")
                    txtRegNo2.MaxLength = 3;
                else
                    txtRegNo2.MaxLength = 2;
            }
            else
            {
                txtRegNo2.Text = "";
                lblMsg.Text = "Please type student id first";
                lblMsg.ForeColor = Color.Red;
            }
        }

        private void txtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            DateTime dateValue;
            if (txtDOB.Text.Length == 8)
            {
                String HOFDOB = txtDOB.Text.Substring(0, 2) + "-" + txtDOB.Text.Substring(2, 2) + "-" + txtDOB.Text.Substring(4, 4);
                if (DateTime.TryParse(HOFDOB, out dateValue))
                {
                    txtDOB.Text = HOFDOB.ToString();
                    //SUCCESS 
                    DateTime dt = Convert.ToDateTime(txtDOB.Text);
                    // txtAge.Text = ((DateTime.Now - dt).TotalDays / 365).ToString("0");
                }
                else
                {
                    txtDOB.Text = "";
                    lblMsg.Text = "Invalid date of birth";
                    lblMsg.ForeColor = Color.Red;
                    txtDOB.Focus();
                    return;
                }
            }
        }

        private void ddlMILSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGetStudentID.Text.Length == 13)
            {
                if (ddlMILSubject.SelectedIndex > 0)
                {
                    ddlLIUESubject.Enabled = false;
                    if (ddlLIUESubject.Items.Count > 0)
                        ddlLIUESubject.SelectedIndex = 0;
                    else
                        ddlLIUESubject.SelectedIndex = -1;
                    if ((string)ddlMILSubject.SelectedValue == "01")
                    {
                        ddlMILGroup.Enabled = true;
                        ddlMILGroup.SelectedIndex = 0;
                    }
                    else if ((string)ddlMILSubject.SelectedValue == "02")
                    {
                        ddlMILGroup.Enabled = true;
                        ddlMILGroup.SelectedIndex = 0;
                    }
                    else if ((string)ddlMILSubject.SelectedValue == "05")
                    {
                        ddlMILGroup.Enabled = true;
                        ddlMILGroup.SelectedIndex = 0;
                    }
                    else
                    {
                        ddlMILGroup.Enabled = false;
                        ddlMILGroup.SelectedIndex = 0;
                    }
                    string text = "";
                    string part = "";
                    if (ddlMILSubject.SelectedIndex > 0)
                    {
                        text = ddlMILSubject.Text;
                        part = text.Substring(0, text.IndexOf("-"));
                    }

                    string part2 = "";
                    string text2 = ddlLIUESubject.Text;
                    if (ddlLIUESubject.SelectedIndex > 0)
                        part2 = text2.Substring(0, text2.IndexOf("-"));

                    ddlElectiveSubject.DataSource = null;
                    List<SubjectMasterInfo> _mListELECTIVE = new List<SubjectMasterInfo>();

                    var Result = _mListELECTIVE = objSubject.GetSubject(txtGetStudentID.Text.Substring(2, 1), "ELECTIVE");
                    if (part.Length > 0)
                        Result = _mListELECTIVE.Where(c => !c.SubjectName.Contains(part)).ToList();
                    if (part2.Length > 0)
                        Result = Result.Where(c => !c.SubjectName.Contains(part2)).ToList();
                    if (Result.Count() > 0)
                    {
                        Result.Insert(0, new SubjectMasterInfo { SubjectCode = "0", SubjectName = "-Select-" });
                        ddlElectiveSubject.DataSource = Result;
                        ddlElectiveSubject.DisplayMember = "SubjectName";
                        ddlElectiveSubject.ValueMember = "SubjectCode";
                    }
                }
                else if (ddlMILSubject.SelectedIndex == 0)
                {
                    ddlMILGroup.Enabled = false;
                    ddlMILGroup.SelectedIndex = 0;
                    string districtcode = txtStudentID.Text.Substring(0, 2);
                    if (districtcode == "15")
                        ddlLIUESubject.Enabled = true;
                    else if (districtcode == "22")
                        ddlLIUESubject.Enabled = true;
                    else
                        ddlLIUESubject.Enabled = false;

                }
                else
                {
                    //string districtcode = txtStudentID.Text.Substring(0, 2);
                    //if (districtcode == "15")
                    //    ddlLIUESubject.Enabled = true;
                    //else if (districtcode == "22")
                    //    ddlLIUESubject.Enabled = true;
                    //else
                    //    ddlLIUESubject.Enabled = false;

                    //if(ddlLIUESubject.Items.Count > 0)
                    //    ddlLIUESubject.SelectedIndex = 0;
                    //else
                    //    ddlLIUESubject.SelectedIndex = -1;
                }
            }
        }

        private void ddlLIUESubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtGetStudentID.Text.Length == 13)
            {
                if (ddlLIUESubject.SelectedIndex > 0)
                {
                    ddlMILSubject.Enabled = false;
                    ddlMILSubject.SelectedIndex = 0;
                    ddlMILGroup.Enabled = false;
                    ddlMILGroup.SelectedIndex = 0;

                    string text1 = "";
                    string part1 = "";
                    text1 = ddlLIUESubject.Text;
                    //if (ddlLIUESubject.SelectedIndex > 0)
                    part1 = text1.Substring(0, text1.IndexOf("("));

                    //string part2 = "";
                    //string text2 = ddlMILSubject.Text;
                    //if (ddlMILSubject.SelectedIndex > 0)
                    //    part2 = text2.Substring(0, text2.IndexOf("-"));

                    ddlElectiveSubject.DataSource = null;
                    List<SubjectMasterInfo> _mListELECTIVE = new List<SubjectMasterInfo>();

                    var Result1 = _mListELECTIVE = objSubject.GetSubject(txtGetStudentID.Text.Substring(2, 1), "ELECTIVE");
                    if (part1.Length > 0)
                        Result1 = _mListELECTIVE.Where(c => !c.SubjectName.Contains(part1)).ToList();
                    //if (part2.Length > 0)
                    //    Result1 = Result1.Where(c => !c.SubjectName.Contains(part2)).ToList();
                    if (Result1.Count() > 0)
                    {
                        Result1.Insert(0, new SubjectMasterInfo { SubjectCode = "0", SubjectName = "-Select-" });
                        ddlElectiveSubject.DataSource = Result1;
                        ddlElectiveSubject.DisplayMember = "SubjectName";
                        ddlElectiveSubject.ValueMember = "SubjectCode";
                    }
                }
                else if (ddlLIUESubject.SelectedIndex == 0)
                {
                    ddlMILSubject.Enabled = true;
                    //ddlMILSubject.SelectedIndex = 0;
                    //ddlMILGroup.Enabled = true;
                    //ddlMILGroup.SelectedIndex = 0;
                }
            }

        }

        private void txtnameOfStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtMotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtGetStudentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtnameOfStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRegNo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRegNo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRegNo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRegNo4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRegNo5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMotherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlPhysicallyChallange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlTypeOfChallange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlNatureOfEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlAnnualFamilyIncome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlMediumOfExam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlMILSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlMILGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlLIUESubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ddlElectiveSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        #endregion

        #region "Extra code"

        public void BindNatureOfEntry_WithCollectedData()
        {
            try
            {
                List<NatureOfEntry> list = new List<NatureOfEntry>
                {
                    new NatureOfEntry{ NatureName = "Correction" , NatureValue = "U"},
                    new NatureOfEntry{ NatureName = "Deletion" ,NatureValue = "D" },
                };

                ddlNatureOfEntry.DataSource = list;
                ddlNatureOfEntry.DisplayMember = "NatureName";
                ddlNatureOfEntry.ValueMember = "NatureValue";
                ddlNatureOfEntry.Items.Insert(0, "-SELECT-");

            }
            catch (Exception ex)
            {
               
            }
        }

        public void BindNatureOfEntry_WithOutCollectedData()
        {
            try
            {
                List<NatureOfEntry> list = new List<NatureOfEntry>
                {
                    new NatureOfEntry{ NatureName = "Addition" , NatureValue = "A"},
                };

                ddlNatureOfEntry.DataSource = list;
                ddlNatureOfEntry.DisplayMember = "NatureName";
                ddlNatureOfEntry.ValueMember = "NatureValue";
                ddlNatureOfEntry.Items.Insert(0, "-SELECT-");

            }
            catch (Exception ex)
            {
               
            }
        }

        #endregion
    }
}
