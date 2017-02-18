using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntrySystem.DataLayer.Type
{

    public class UserMaster
    {
        public Int32 UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String ContactNo { get; set; }
        public String UserInRole { get; set; }
        public String UserInRoleAlias { get; set; }
        public Int32 CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Int32 ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class ExcelPassword
    {
        public String Password { get; set; }
    }

    public class RoleInfo
    {
        public String Rolename { get; set; }
        public String UserInRoleAlias { get; set; }
    }

    public class NatureOfEntry
    {
        public String NatureName { get; set; }
        public String NatureValue { get; set; }
    }

    public class StudentIDMasterInfo
    {
        public Int32 ID { get; set; }
        public String StudentID { get; set; }
        public Int32 CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public String RegistrationNo { get; set; }
        public String candidateName { get; set; }
        public String FatherName { get; set; }
        public String DOB { get; set; }
        public String Gender { get; set; }
    }

    public class SubjectMasterInfo
    {
        public Int32 SubjectMasterId { get; set; }
        public String SubjectCode { get; set; }
        public String SubjectName { get; set; }
        public String StudentCharacter { get; set; }
        public String SubjectGroup { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class StudentMasterInfo
    {
        public Int64 StudentMasterId { get; set; }
        public String StudentId { get; set; }
        public String NatureOfEntry { get; set; }
        public String RegistrationNo { get; set; }
        public String Name { get; set; }
        public String FatherName { get; set; }
        public String MotherName { get; set; }
        public String DateOfBirth { get; set; }
        public String Gender { get; set; }
        public String Category { get; set; }
        public String PhysicallyChallenged { get; set; }
        public String PhysicallyChallengedInText { get; set; }
        public String TypeOfChallange { get; set; }
        public String FamilyIncome { get; set; }
        public String FamilyIncomeInText { get; set; }
        public String Medium { get; set; }

        public String MILSubjectCode { get; set; }
        public String MIL_Subject { get; set; }
        public String MILGroup { get; set; }
        public String LIEUSubjectCode { get; set; }
        public String LIEUSubject { get; set; }
        public String ElectiveSubjectCode { get; set; }
        public String ElectiveSubject { get; set; }
        public String Remarks { get; set; }

        public Int32 CreatedBy { get; set; }
        public String CreatedByName { get; set; }
        public DateTime CreatedOn { get; set; }
        public Int32 ModifiedBy { get; set; }
        public String ModifiedByName { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Int32 DeletedBy { get; set; }
        public String DeletedByName { get; set; }
        public DateTime DeletedOn { get; set; }

        public Boolean IsVerified { get; set; }
        public Int32 VerifiedBy { get; set; }
        public DateTime VerifiedOn { get; set; }

        public String VerifiedUserName { get; set; }
    }

    public class StudentMasterReport
    {
        public String SNo { get; set; }
        public String Student_Id { get; set; }
        public String Nature_Of_Entry { get; set; }
        public String Registration_No { get; set; }
        public String Name { get; set; }
        public String Father_Name { get; set; }
        public String Mother_Name { get; set; }
        public String Date_Of_Birth { get; set; }
        public String Gender { get; set; }
        public String Category { get; set; }
        public String Physically_Challenged { get; set; }
        public String Type_Of_Challenge { get; set; }
        public String Annual_Family_Income_Upto_Rs_1_lac { get; set; }
        public String Medium { get; set; }
        //public String MIL_Code { get; set; }
        public String MIL_Subject { get; set; }
        public String MIL_Group { get; set; }
      //  public String LIEU_Code { get; set; }
        public String LIEU_Subject { get; set; }
        public String Elective_Subject { get; set; }
        public String Remarks { get; set; }
        public String Created_By { get; set; }
        public String Created_On { get; set; }

        public String Modified_By { get; set; }
        public String Modified_On { get; set; }
        public String Deleted_By { get; set; }
        public String Deleted_On { get; set; }
        public String Verified { get; set; }
        public String Verified_By { get; set; }
        public String Verified_On { get; set; }

       
    }

}
