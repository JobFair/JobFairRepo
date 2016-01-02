using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ManageJobsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();
        ManageJobEntity cloneJobPostEntity = new ManageJobEntity();

        /// <summary>
        /// View Manage Jobs of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ManageJobsDetetailsDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_RE_SelectViewJobPost");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// View Perticular Posted Job by recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ViewJobsDetetailsDAL(int JobId)
        {
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@jobId", JobId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_RE_SelectViewJobDetails", sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         /// <summary>
        /// Clone Manage Jobs of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ClonePostJobDAL(int JobId, int RecruiterID, string IsActive)
        {
            try
            {                
                SqlParameter[] sparams = new SqlParameter[3]; 
                                          
                sparams[0] = new SqlParameter("@jobId", JobId);
                sparams[1] = new SqlParameter("@recruiterId", RecruiterID);
                sparams[2] = new SqlParameter("@isActive", IsActive);

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_RE_InsertCloneJob", sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Delete Manage Jobs of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet DeletePostJobDAL(int JobHistroryId, int JobId, int RecruiterID)
        {
            try
            {
                SqlParameter[] sparams = new SqlParameter[3];

                sparams[0] = new SqlParameter("@jobHistoryId", JobHistroryId);
                sparams[1] = new SqlParameter("@jobId", JobId);
                sparams[2] = new SqlParameter("@recruiterId", RecruiterID);

                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_RE_DeleteViewJobPost", sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
