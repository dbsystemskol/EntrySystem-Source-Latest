using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using log4net;
using log4net.Config;
using EntrySystem.DataLayer.Type;

namespace EntrySystem.DataLayer
{
    public class clsStudent : Base
    {
        protected static ILog log = LogManager.GetLogger(typeof(clsSubject));

        public List<StudentMasterInfo> GetStudentRecordByRegNo(String regNo)
        {
            List<StudentMasterInfo> mList = new List<StudentMasterInfo>();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetStudentRecordByRegNo";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@RegNo", regNo);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentMasterInfo
                    {
                        //StudentMasterId = Convert.ToInt32(mDr["StudentMasterId"].ToString()),
                        StudentId = mDr["StudID"].ToString(),
                        NatureOfEntry = mDr["CorrType"].ToString(),
                        Name = mDr["Candidate_Name"].ToString(),
                        RegistrationNo = mDr["REGNo"].ToString(),
                        FatherName = mDr["Father_Name"].ToString(),
                        MotherName = mDr["Mother_Name"].ToString(),
                        DateOfBirth = (mDr["DOB"].ToString()),
                        Gender = mDr["Gender"].ToString(),

                        Category = mDr["Category"].ToString(),
                        PhysicallyChallenged = (mDr["PH"].ToString()),
                        TypeOfChallange = mDr["PH_Type"].ToString(),
                        FamilyIncome = (mDr["Family_Income_Upto_Rs1Lac"].ToString()),
                        Medium = mDr["Medium"].ToString(),
                        MILSubjectCode = mDr["MIL_Code"].ToString(),
                        MIL_Subject = mDr["MIL_Sub"].ToString(),
                        MILGroup = mDr["MIL_Group"].ToString(),

                        LIEUSubjectCode = mDr["LIEU_Code"].ToString(),
                        LIEUSubject = mDr["LIEU_Sub"].ToString(),
                        ElectiveSubjectCode = mDr["ELEC_Code"].ToString(),
                        ElectiveSubject = mDr["ELEC_Sub"].ToString(),
                        Remarks = mDr["Remarks"].ToString(),
                        IsVerified = (mDr["IsVerified"].ToString() == "False" ? false : true),
                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }

        public Int32 InsertStudentMaster(StudentMasterInfo objStudent)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "StudentMasterInsert";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentId", objStudent.StudentId);
            mCmd.Parameters.AddWithValue("@NatureOfEntry", objStudent.NatureOfEntry);
            mCmd.Parameters.AddWithValue("@RegistrationNo", objStudent.RegistrationNo);
            mCmd.Parameters.AddWithValue("@Name", objStudent.Name);
            mCmd.Parameters.AddWithValue("@FatherName", objStudent.FatherName);
            mCmd.Parameters.AddWithValue("@MotherName", objStudent.MotherName);
            mCmd.Parameters.AddWithValue("@DateOfBirth", objStudent.DateOfBirth);

            mCmd.Parameters.AddWithValue("@Gender", objStudent.Gender);
            mCmd.Parameters.AddWithValue("@Category", objStudent.Category);
            mCmd.Parameters.AddWithValue("@PhysicallyChallenged", objStudent.PhysicallyChallenged);
            mCmd.Parameters.AddWithValue("@TypeOfChallenge", objStudent.TypeOfChallange);
            mCmd.Parameters.AddWithValue("@FamilyIncome", objStudent.FamilyIncome);
            mCmd.Parameters.AddWithValue("@Medium", objStudent.Medium);

            mCmd.Parameters.AddWithValue("@MILSubjectCode", objStudent.MILSubjectCode);
            mCmd.Parameters.AddWithValue("@MILGroup", objStudent.MILGroup);
            mCmd.Parameters.AddWithValue("@LIEUSubjectCode", objStudent.LIEUSubjectCode);
            mCmd.Parameters.AddWithValue("@ElectiveSubjectCode", objStudent.ElectiveSubjectCode);
            mCmd.Parameters.AddWithValue("@Remarks", objStudent.Remarks);
            mCmd.Parameters.AddWithValue("@CreatedBy", objStudent.CreatedBy);


            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }

        public Int32 UpdateStudentMaster(StudentMasterInfo objStudent)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "StudentMasterUpdate";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudID", objStudent.StudentId);
            mCmd.Parameters.AddWithValue("@CorrType", objStudent.NatureOfEntry);
            mCmd.Parameters.AddWithValue("@REGNo", objStudent.RegistrationNo);
            mCmd.Parameters.AddWithValue("@Candidate_Name", objStudent.Name);
            mCmd.Parameters.AddWithValue("@Father_Name", objStudent.FatherName);
            mCmd.Parameters.AddWithValue("@Mother_Name", objStudent.MotherName);
            mCmd.Parameters.AddWithValue("@DOB", objStudent.DateOfBirth);
            mCmd.Parameters.AddWithValue("@Gender", objStudent.Gender);
            mCmd.Parameters.AddWithValue("@Category", objStudent.Category);
            mCmd.Parameters.AddWithValue("@PH", objStudent.PhysicallyChallenged);
            mCmd.Parameters.AddWithValue("@PH_Type", objStudent.TypeOfChallange);
            mCmd.Parameters.AddWithValue("@Family_Income_Upto_Rs1Lac", objStudent.FamilyIncome);
            mCmd.Parameters.AddWithValue("@Medium", objStudent.Medium);
            mCmd.Parameters.AddWithValue("@MIL_Code", objStudent.MILSubjectCode);

            mCmd.Parameters.AddWithValue("@MIL_Sub", objStudent.MIL_Subject);

            mCmd.Parameters.AddWithValue("@MIL_Group", objStudent.MILGroup);
            mCmd.Parameters.AddWithValue("@LIEU_Code", objStudent.LIEUSubjectCode);

            mCmd.Parameters.AddWithValue("@LIEU_Sub", objStudent.LIEUSubject);

            mCmd.Parameters.AddWithValue("@ELEC_Code", objStudent.ElectiveSubjectCode);

            mCmd.Parameters.AddWithValue("@ELEC_Sub", objStudent.ElectiveSubject);

            mCmd.Parameters.AddWithValue("@Remarks", objStudent.Remarks);

            if (objStudent.NatureOfEntry == "A")
                mCmd.Parameters.AddWithValue("@ModifiedBy", objStudent.CreatedBy);
            else
                mCmd.Parameters.AddWithValue("@ModifiedBy", objStudent.ModifiedBy);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }

        public Int32 DeleteStudentMaster(String StudentMasterId, String Name, String RegistrationNo, Int32 DeletedBy,String CorrType)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "StudentMasterDelete";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentId", StudentMasterId);
            mCmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
            mCmd.Parameters.AddWithValue("@Name", Name);
            mCmd.Parameters.AddWithValue("@DeletedBy", DeletedBy);
            mCmd.Parameters.AddWithValue("@CorrType", CorrType);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }

        public Boolean ExistInStudentMasterID(String RegNo)
        {
            Boolean mExists = false;

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetExistsStudentId";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@RegNo", RegNo);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mExists = true;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mExists;
        }

        public Boolean IsVerifiedStudentMasterID(String StudentID)
        {
            Boolean mVerified = false;

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "IsVerifiedStudentMasterID";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentID", StudentID);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mVerified = true;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mVerified;
        }


        #region "Extra Code"

        public Int32 VerifiedStudentTotalPages(String URNNO, Int32 PageSize)
        {
            Int32 TotalPages = 0;

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "VerifiedStudentTotalPages";
            mCmd.CommandType = CommandType.StoredProcedure;
            if (URNNO == String.Empty)
            {
                mCmd.Parameters.AddWithValue("@StudentId", null);
            }
            else
            {
                mCmd.Parameters.AddWithValue("@StudentId", URNNO);
            }
            mCmd.Parameters.AddWithValue("@PageSize", PageSize);
            mCmd.Parameters.Add("@TotalPages", SqlDbType.Int);
            mCmd.Parameters["@TotalPages"].Direction = ParameterDirection.Output;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mDr = mCmd.ExecuteReader();
                TotalPages = Convert.ToInt32(mCmd.Parameters["@TotalPages"].Value);
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return TotalPages;
        }

        public List<StudentMasterInfo> GetVerifiedStudentList(String StudentId, int pagesize, int pageno)
        {
            List<StudentMasterInfo> mList = new List<StudentMasterInfo>();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetVerifiedStudentList";
            mCmd.CommandType = CommandType.StoredProcedure;
            if (StudentId == String.Empty)
            {
                mCmd.Parameters.AddWithValue("@StudentId", null);
            }
            else
            {
                mCmd.Parameters.AddWithValue("@StudentId", StudentId);
            }

            mCmd.Parameters.AddWithValue("@Pagesize", pagesize);
            mCmd.Parameters.AddWithValue("@PageNo", pageno);
            try
            {
                mCmd.Connection = mCon;
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentMasterInfo
                    {
                        StudentId = mDr["Student_Id"].ToString(),
                        Name = mDr["Name"].ToString(),
                        RegistrationNo = mDr["Registration_No"].ToString(),
                        NatureOfEntry = mDr["Nature_Of_Entry"].ToString(),
                        FatherName = mDr["Father_Name"].ToString(),
                        MotherName = mDr["Mother_Name"].ToString(),
                        DateOfBirth = mDr["Date_Of_Birth"].ToString(),
                        Gender = mDr["Gender"].ToString(),

                        Category = mDr["Category"].ToString(),
                        PhysicallyChallengedInText = mDr["Physically_Challenged"].ToString(),
                        TypeOfChallange = mDr["Type_Of_Challenge"].ToString(),
                        FamilyIncomeInText = mDr["Annual_Family_Income_Upto_Rs_1_lac"].ToString(),
                        Medium = mDr["Medium"].ToString(),
                        MIL_Subject = mDr["MIL_Subject"].ToString(),
                        MILGroup = mDr["MIL_Group"].ToString(),
                        LIEUSubject = mDr["LIEU_Subject"].ToString(),

                        ElectiveSubject = mDr["Elective_Subject"].ToString(),
                        Remarks = mDr["Remarks"].ToString(),
                        CreatedByName = mDr["Created_By"].ToString(),
                        CreatedOn = Convert.ToDateTime(mDr["Created_On"].ToString()),
                        ModifiedByName = mDr["Modified_By"].ToString(),
                        ModifiedOn = Convert.ToDateTime(mDr["Modified_On"].ToString()),
                        DeletedByName = mDr["Deleted_By"].ToString(),
                        DeletedOn = Convert.ToDateTime(mDr["Deleted_On"].ToString()),

                        VerifiedUserName = mDr["Verified_By"].ToString(),
                        VerifiedOn = Convert.ToDateTime(mDr["Verified_On"].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }




        public List<StudentMasterInfo> GetUnVerifiedStudentList(String RegNo,Boolean isverified)
        {
            List<StudentMasterInfo> mList = new List<StudentMasterInfo>();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetUnVerifiedStudentList";
            mCmd.CommandType = CommandType.StoredProcedure;
            if (RegNo == String.Empty)
            {
                mCmd.Parameters.AddWithValue("@RegNo", null);
            }
            else
            {
                mCmd.Parameters.AddWithValue("@RegNo", RegNo);
            }
            mCmd.Parameters.AddWithValue("@IsVerified", isverified);
            try
            {
                mCmd.Connection = mCon;
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentMasterInfo
                    {
                        StudentMasterId = Convert.ToInt64(mDr["StudentMasterDataCloneId"].ToString()),
                        StudentId = mDr["Student_Id"].ToString(),
                        Name = mDr["Candidate_Name"].ToString(),
                        RegistrationNo = mDr["Registration_No"].ToString(),
                        NatureOfEntry = mDr["CorrType"].ToString(),
                        FatherName = mDr["Father_Name"].ToString(),
                        MotherName = mDr["Mother_Name"].ToString(),
                        DateOfBirth = mDr["DOB"].ToString(),
                        Gender = mDr["Gender"].ToString(),
                        Category = mDr["Category"].ToString(),

                        PhysicallyChallengedInText = mDr["PH"].ToString(),
                        TypeOfChallange = mDr["PH_Type"].ToString(),
                        FamilyIncomeInText = mDr["Family_Income_Upto_Rs1Lac"].ToString(),
                        Medium = mDr["Medium"].ToString(),
                        MIL_Subject = mDr["MIL_Subject"].ToString(),

                        MILGroup = mDr["MIL_Group"].ToString(),
                        LIEUSubject = mDr["LIEU_Subject"].ToString(),
                        ElectiveSubject = mDr["Elective_Subject"].ToString(),
                        Remarks = mDr["Remarks"].ToString(),

                        //CreatedByName = mDr["Created_By"].ToString(),
                        //CreatedOn = Convert.ToDateTime(mDr["Created_On"]),
                        //ModifiedByName = mDr["Modified_By"].ToString(),
                        //ModifiedOn = Convert.ToDateTime(mDr["Modified_On"].ToString()),
                        //DeletedByName = mDr["Deleted_By"].ToString(),
                        //DeletedOn = Convert.ToDateTime(mDr["Deleted_On"].ToString()),

                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }

        #endregion

        public Int32 VerifyStudents(String RegNo,Int32 verifiedBy,Boolean Isverified)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "VerifyStudents";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@RegNo", RegNo);
            mCmd.Parameters.AddWithValue("@VerifiedBy", verifiedBy);
            mCmd.Parameters.AddWithValue("@IsVerified", Isverified);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }


        public List<StudentMasterReport> GetAllStudentRecords()
        {
            List<StudentMasterReport> mList = new List<StudentMasterReport>();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetAllStudentRecords";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentMasterReport
                    {
                        SNo = mDr["SNo"].ToString(),
                        Student_Id = mDr["Student_Id"].ToString(),
                        Nature_Of_Entry = mDr["Nature_Of_Entry"].ToString(),
                        Name = mDr["Name"].ToString(),
                        Registration_No = mDr["Registration_No"].ToString(),
                        Father_Name = mDr["Father_Name"].ToString(),
                        Mother_Name = mDr["Mother_Name"].ToString(),
                        Date_Of_Birth = mDr["Date_Of_Birth"].ToString(),
                        Gender = mDr["Gender"].ToString(),
                        Category = mDr["Category"].ToString(),
                        Physically_Challenged = mDr["Physically_Challenged"].ToString(),
                        Type_Of_Challenge = mDr["Type_Of_Challenge"].ToString(),
                        Annual_Family_Income_Upto_Rs_1_lac = mDr["Annual_Family_Income_Upto_Rs_1_lac"].ToString(),
                        Medium = mDr["Medium"].ToString(),
                        //MIL_Code = mDr["MIL_Code"].ToString(),
                        MIL_Subject = mDr["MIL_Sub"].ToString(),
                        MIL_Group = mDr["MIL_Group"].ToString(),
                        //LIEU_Code = mDr["LIEU_Code"].ToString(),
                        LIEU_Subject = mDr["LIEU_Sub"].ToString(),
                        Elective_Subject = mDr["Elec_Sub"].ToString(),
                        Remarks = mDr["Remarks"].ToString(),
                        Created_By = mDr["CreatedBy"].ToString(),
                        Created_On = mDr["CreatedOn"].ToString(),
                        Modified_By = mDr["ModifiedBy"].ToString(),
                        Modified_On = mDr["ModifiedOn"].ToString(),
                        Deleted_By = mDr["DeletedBy"].ToString(),
                        Deleted_On = mDr["DeletedOn"].ToString(),
                        Verified = mDr["Verified"].ToString(),
                        Verified_By = mDr["VerifiedBy"].ToString(),
                        Verified_On = mDr["VerifiedOn"].ToString(),

                       
                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }


        #region "Extra Code"

        public List<StudentMasterInfo> GetStudentIDByRegNo(String RegNo)
        {
            List<StudentMasterInfo> mList = new List<StudentMasterInfo>();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetExistsStudentId";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@RegNo", RegNo);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentMasterInfo
                    {
                        StudentId = mDr["StudID"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return mList;
        }

        #endregion


        public Int32 InsertActivityLog(String StudId, String FieldName, String oldValue, String newValue, Int32 Userid, Boolean IsApproved)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "ActivityLogInsert";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudId", StudId);
            mCmd.Parameters.AddWithValue("@FieldName", FieldName);
            mCmd.Parameters.AddWithValue("@OldValue", oldValue);
            mCmd.Parameters.AddWithValue("@NewValue", newValue);
            mCmd.Parameters.AddWithValue("@UpdatedBy", Userid);
            mCmd.Parameters.AddWithValue("@IsApproved", IsApproved);

            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            int ReturnVal = 0;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mCmd.Connection = mCon;
                mCmd.ExecuteNonQuery();
                ReturnVal = Convert.ToInt32(mCmd.Parameters["@ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
            finally
            {
                mCmd = null;
                mCon.Close();
            }
            return ReturnVal;
        }

    }
}
