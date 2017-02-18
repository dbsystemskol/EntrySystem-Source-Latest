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
   public class clsReport : Base
    {
       protected static ILog log = LogManager.GetLogger(typeof(clsReport));

       public DataTable DateWiseActivityReport(String Fromdate, String ToDate)
        {
            // List<DateWiseChartInfo> mList = new List<DateWiseChartInfo>();
            DataTable dt = new DataTable();

            SqlConnection mCon = new SqlConnection(ConnectionString);
            SqlCommand mCmd = new SqlCommand();
            SqlDataReader mDr = null;

            mCmd.CommandText = "DateWiseActivityReport";
            mCmd.CommandType = CommandType.StoredProcedure;

            mCmd.Parameters.AddWithValue("@FromDate", Fromdate);
            mCmd.Parameters.AddWithValue("@ToDate", ToDate);

            mCmd.Connection = mCon;
            try
            {
                mCon.Open();
                mDr = mCmd.ExecuteReader();
                dt.Load(mDr);
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
            return dt;

        }

    }
}
