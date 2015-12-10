using Entities.Recruiter;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Class ClientDetailsDAL
    /// </summary>
    public class ClientDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method of class ClientDetailsDAL for saving ClientDetails in database
        /// </summary>
        /// <param name="clientdetailsEntity">Object of ClientDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveClientDetailsDAL(ClientDetailsEntity clientdetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparam = new SqlParameter[16];
                //Add parameter for stored procedure
                sparam[0] = new SqlParameter("@rercruiterid", clientdetailsEntity.RecruiterId);
                sparam[1] = new SqlParameter("@clientName", clientdetailsEntity.ClientName);
                sparam[2] = new SqlParameter("@password", clientdetailsEntity.Password);
                sparam[3] = new SqlParameter("@industry", clientdetailsEntity.Industry);
                sparam[4] = new SqlParameter("@functuionalarea", clientdetailsEntity.FunctionalArea);
                sparam[5] = new SqlParameter("@country", clientdetailsEntity.Country);
                sparam[6] = new SqlParameter("@state", clientdetailsEntity.State);
                sparam[7] = new SqlParameter("@city", clientdetailsEntity.City);
                sparam[8] = new SqlParameter("@officialEmailid", clientdetailsEntity.OfficialEmailId);
                sparam[9] = new SqlParameter("@website", clientdetailsEntity.Website);
                sparam[10] = new SqlParameter("@officialcontact", clientdetailsEntity.ContactDetails);
                sparam[11] = new SqlParameter("@officialaddress", clientdetailsEntity.OfficialAddress);
                sparam[12] = new SqlParameter("@agreementdate", clientdetailsEntity.AgreementDate.Date);
                sparam[13] = new SqlParameter("@duedate", clientdetailsEntity.DueDate.Date);
                sparam[14] = new SqlParameter("@paymentDetails", clientdetailsEntity.PaymentDetails);
                sparam[15] = new SqlParameter("@paymentterms", clientdetailsEntity.PaymentTerms);
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertClientDetails, sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method for adding Functional Details in database
        /// </summary>
        /// <param name="clientDetailsEntity">Object of ClientDetailsEntity</param>
        public void AddFunctionalDAL(ClientDetailsEntity clientDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@FunctionalareaName", clientDetailsEntity.AddFunctionalArea);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertFunctionalArea, sparams);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}