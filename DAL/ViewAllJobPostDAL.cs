using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewAllJobPostDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet ViewCandidateProfileForEmail(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_ViewCandidateProfileForEmail, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }

        public DataSet GetData(string id)
        {
            DataSet dsviewpost = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@JobId", id) };
                dsviewpost = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectViewJobPost, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
            return dsviewpost;
        }

        public int CheckMailSend(string id, string candidateId)
        {
           
            try
            {
                SqlParameter[] sqlparams ={
                                                  new SqlParameter("@JobId", id) ,
                                                  new SqlParameter("@CandidateId", candidateId),
                                                  new  SqlParameter ("@IsMailSend",1),
                                                  new SqlParameter("@Date", DateTime.Now)                                 
                                             };
                return SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertJobHistory, sqlparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}