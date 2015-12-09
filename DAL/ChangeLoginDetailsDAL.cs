using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            DataSet datasetLoginDetails = new DataSet();
            try
            {
                connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                datasetLoginDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectLoginDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return datasetLoginDetails;
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
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangePrimaryMailID, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
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
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangePrimaryMobileNo, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to Add New Mail ID
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMailIdDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mailId", changeLoginDetailsEntity.MailId);
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangeEmailId, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// Method in ChangeLoginDetailsDAL class to Add new Mobile number
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMoblieNoDAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@candidateId", changeLoginDetailsEntity.CandidateId);
                sparams[1] = new SqlParameter("@mobileNo", changeLoginDetailsEntity.MobileNo);
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_ChangeMobileNo, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}