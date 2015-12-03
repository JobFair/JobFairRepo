using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class ChangeLoginDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to get login details
        /// </summary>
        /// <param name="candidateId">String parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetLoginDetailsDAL(string candidateId)
        {
            try
            {
                connection.Open();
                DataSet datasetLoginDetails = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                datasetLoginDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectLoginDetails, sparams);

                return datasetLoginDetails;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to change Primary Mail ID
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMailIdDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mailId", changeLoginDetailsEntity.MailId);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangePrimaryMailID,sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to change Primary mobile number 
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMobileNoDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mobileNo", changeLoginDetailsEntity.MobileNo);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangePrimaryMobileNo,sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to Add New Mail ID
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMailIdDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                 connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mailId", changeLoginDetailsEntity.MailId);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangeEmailId,sparams);
            }
            catch (Exception)
            {                
                throw;
            }
        }
        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to Add new Mobile number 
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMoblieNoDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                 connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mobileNo", changeLoginDetailsEntity.MobileNo);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangeMobileNo,sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
