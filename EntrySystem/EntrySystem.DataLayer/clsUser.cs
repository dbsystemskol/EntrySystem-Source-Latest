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
    public class clsUser : Base
    {
        protected static ILog log = LogManager.GetLogger(typeof(clsUser));

        public List<UserMaster> UserLogin(UserMaster mInfo)
        {
            List<UserMaster> mList = new List<UserMaster>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "UserMaster_SelectRow";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@UserName", mInfo.UserName);
            mCmd.Parameters.AddWithValue("@Password", mInfo.Password);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new UserMaster
                    {
                        UserId = Convert.ToInt32(mDr["UserId"].ToString()),
                        UserName = mDr["UserName"].ToString(),
                        Password = mDr["Password"].ToString(),
                        Name = mDr["Name"].ToString(),
                        IsActive = Convert.ToBoolean(mDr["IsActive"].ToString()),
                        UserInRole = mDr["UserRole"].ToString(),
                        UserInRoleAlias = mDr["UserRoleAlias"].ToString(),
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

        public List<UserMaster> GetAllUserMasterInfo()
        {
            List<UserMaster> mList = new List<UserMaster>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetAllUserMasterInfo";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new UserMaster
                    {
                        UserId = Convert.ToInt32(mDr["UserId"].ToString()),
                        UserName = mDr["UserName"].ToString(),
                        Password = mDr["Password"].ToString(),
                        Name = mDr["Name"].ToString(),
                        ContactNo = mDr["ContactNo"].ToString(),
                        UserInRole = mDr["UserRole"].ToString(),
                        UserInRoleAlias = mDr["UserRoleAlias"].ToString(),
                        IsActive = Convert.ToBoolean(mDr["IsActive"].ToString()),
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

        public Int32 InsertUserMaster(String UserName, String Password,String Name,String ContactNo,String RoleName,String RoleAlias,Int32 UserId)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "InsertUserMaster";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@UserName", UserName);
            mCmd.Parameters.AddWithValue("@Password", Password);
            mCmd.Parameters.AddWithValue("@Name", Name);
            mCmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            mCmd.Parameters.AddWithValue("@UserRole", RoleName);
            mCmd.Parameters.AddWithValue("@UserRoleAlias", RoleAlias);
            mCmd.Parameters.AddWithValue("@CreatedBy", UserId);
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

        public Int32 UpdateUserMaster(Int32 UserId, String UserName, String Name, String ContactNo, String RoleName, String RoleAlias,Int32 ModifiedBy)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            int ReturnVal = 0;
            mCmd.CommandText = "UpdateUserMaster";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@UserId", UserId);
            mCmd.Parameters.AddWithValue("@UserName", UserName);
            mCmd.Parameters.AddWithValue("@Name", Name);
            mCmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            mCmd.Parameters.AddWithValue("@RoleName", RoleName);
            mCmd.Parameters.AddWithValue("@RoleAlias", RoleAlias);
            mCmd.Parameters.AddWithValue("@ModifiedBy", ModifiedBy);
            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
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

        public List<UserMaster> UserMasterSelectById(Int32 UserId)
        {
            List<UserMaster> mList = new List<UserMaster>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "UserMasterSelectById";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@UserId", UserId);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new UserMaster
                    {
                        UserId = Convert.ToInt32(mDr["UserId"].ToString()),
                        UserName = mDr["UserName"].ToString(),
                        Password = mDr["Password"].ToString(),
                        Name = mDr["Name"].ToString(),
                        ContactNo = mDr["ContactNo"].ToString(),
                        UserInRole = mDr["UserRole"].ToString(),
                        UserInRoleAlias = mDr["UserRoleAlias"].ToString(),
                        IsActive = Convert.ToBoolean(mDr["IsActive"].ToString()),
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

        public Int32 DeleteUserMaster(Int32 UserId)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "DeleteUserMasterRow";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@UserId", UserId);
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

        #region "Create Student ID"

        public List<StudentIDMasterInfo> GetAllStudentMasterInfo()
        {
            List<StudentIDMasterInfo> mList = new List<StudentIDMasterInfo>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetAllStudentMasterInfo";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentIDMasterInfo
                    {
                        //ID = Convert.ToInt32(mDr["Id"].ToString()),
                        StudentID = mDr["StudID"].ToString(),
                        //CreatedBy = Convert.ToInt32(mDr["CreatedBy"].ToString()),
                        //CreatedOn = Convert.ToDateTime(mDr["CreatedOn"].ToString()),
                        RegistrationNo = mDr["REGNo"].ToString(),
                        candidateName = mDr["Candidate_Name"].ToString(),
                        FatherName = mDr["Father_Name"].ToString(),
                        DOB = mDr["DOB"].ToString(),
                        Gender = mDr["Gender"].ToString(),
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


        #region "Extra Code"

        public Int32 ChangeUserPassword(Int32 UserMasterID, String NewPassword)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            mCmd.CommandText = "ChangePassword";
            mCmd.CommandType = CommandType.StoredProcedure;

            mCmd.Parameters.AddWithValue("@UserId", UserMasterID);
            mCmd.Parameters.AddWithValue("@NewPassword", NewPassword);
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

        public List<StudentIDMasterInfo> GetStudentMasterInfoById(String StudentId)
        {
            List<StudentIDMasterInfo> mList = new List<StudentIDMasterInfo>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetStudentMasterInfoById";
            mCmd.Parameters.AddWithValue("@StudentID", StudentId);
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentIDMasterInfo
                    {
                        StudentID = mDr["StudID"].ToString(),
                        //CreatedBy = Convert.ToInt32(mDr["CreatedBy"].ToString()),
                        //CreatedOn = Convert.ToDateTime(mDr["CreatedOn"].ToString()),
                        RegistrationNo = mDr["REGNo"].ToString(),
                        candidateName = mDr["Candidate_Name"].ToString(),
                        FatherName = mDr["Father_Name"].ToString(),
                        DOB = mDr["DOB"].ToString(),
                        Gender = mDr["Gender"].ToString(),

                        //ID = Convert.ToInt32(mDr["Id"].ToString()),
                        //StudentID = mDr["StudentId"].ToString(),
                        //CreatedBy = Convert.ToInt32(mDr["CreatedBy"].ToString()),
                        //CreatedOn = Convert.ToDateTime(mDr["CreatedOn"].ToString()),
                        //RegistrationNo = mDr["RegistrationNo"].ToString(),
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

        public List<UserMaster> GetUserMasterInfoById(String SearchText)
        {
            List<UserMaster> mList = new List<UserMaster>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetUserMasterInfoById";
            mCmd.Parameters.AddWithValue("@SearchText", SearchText);
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new UserMaster
                    {
                        UserId = Convert.ToInt32(mDr["UserId"].ToString()),
                        UserName = mDr["UserName"].ToString(),
                        Password = mDr["Password"].ToString(),
                        Name = mDr["Name"].ToString(),
                        ContactNo = mDr["ContactNo"].ToString(),
                        UserInRole = mDr["UserRole"].ToString(),
                        UserInRoleAlias = mDr["UserRoleAlias"].ToString(),
                        IsActive = Convert.ToBoolean(mDr["IsActive"].ToString()),
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



       

       

        public List<ExcelPassword> GetExcelPassword()
        {
            List<ExcelPassword> mList = new List<ExcelPassword>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetExcelPassword";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new ExcelPassword
                    {
                        Password = mDr["Password"].ToString(),
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


        #region "Extar Code"

        public Int32 InsertStudentMasterID(String StudentID, Int32 UserId,String RegistrationNo)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();

            mCmd.CommandText = "InsertStudentMasterID";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentID", StudentID);
            mCmd.Parameters.AddWithValue("@CreatedBy", UserId);
            mCmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
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

        public List<StudentIDMasterInfo> StudentMasterInfoById(String StudentId)
        {
            List<StudentIDMasterInfo> mList = new List<StudentIDMasterInfo>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "StudentMasterInfoById";
            mCmd.Parameters.AddWithValue("@StudentMasterID", StudentId);
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new StudentIDMasterInfo
                    {
                        //ID = Convert.ToInt32(mDr["Id"].ToString()),
                        StudentID = mDr["StudID"].ToString(),
                        //CreatedBy = Convert.ToInt32(mDr["CreatedBy"].ToString()),
                        //CreatedOn = Convert.ToDateTime(mDr["CreatedOn"].ToString()),
                        RegistrationNo = mDr["REGNo"].ToString(),
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

        public Int32 UpdateStudentMasterID(String StudentMasterID, String ChangedStudentID, String RegistrationNo)
        {
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            int ReturnVal = 0;
            mCmd.CommandText = "UpdateStudentMasterID";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentMasterID", StudentMasterID);
            mCmd.Parameters.AddWithValue("@ChangedStudentID", ChangedStudentID);
            mCmd.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
            mCmd.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
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

        #endregion
    }
}
