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
    public class clsSubject : Base
    {
        protected static ILog log = LogManager.GetLogger(typeof(clsSubject));

        public List<SubjectMasterInfo> GetSubject(String StudentCharacter, String SubjectGroup)
        {
            List<SubjectMasterInfo> mList = new List<SubjectMasterInfo>();
            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "GetSubject";
            mCmd.CommandType = CommandType.StoredProcedure;
            mCmd.Parameters.AddWithValue("@StudentCharacter", StudentCharacter);
            mCmd.Parameters.AddWithValue("@SubjectGroup", SubjectGroup);
            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                while (mDr.Read())
                {
                    mList.Add(new SubjectMasterInfo
                    {
                        SubjectMasterId = Convert.ToInt32(mDr["SubjectMasterId"].ToString()),
                        SubjectCode = mDr["SubjectCode"].ToString(),
                        SubjectName = mDr["SubjectName"].ToString(),
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
    }
}
