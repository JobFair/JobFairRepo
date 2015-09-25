using Entities.Recruiter;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int SaveClientDetailsDAL(ClientDetailsEntity clientdetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparam = new SqlParameter[15];
                sparam[0] = new SqlParameter("@rercruiterid", "RE2");
                sparam[1] = new SqlParameter("@clientName", clientdetailsEntity.ClientName);
                sparam[2] = new SqlParameter("@industry", clientdetailsEntity.Industry);
                sparam[3] = new SqlParameter("@functuionalarea", clientdetailsEntity.FunctionalArea);
                sparam[4] = new SqlParameter("@country", clientdetailsEntity.Country);
                sparam[5] = new SqlParameter("@state", clientdetailsEntity.State);
                sparam[6] = new SqlParameter("@city", clientdetailsEntity.City);
                sparam[7] = new SqlParameter("@officialEmailid", clientdetailsEntity.OfficialEmailId);
                sparam[8] = new SqlParameter("@website", clientdetailsEntity.Website);
                sparam[9] = new SqlParameter("@officialcontact", clientdetailsEntity.ContactDetails);
                sparam[10] = new SqlParameter("@officialaddress", clientdetailsEntity.OfficialAddress);
                sparam[11] = new SqlParameter("@agreementdate", clientdetailsEntity.AgreementDate.Date);
                sparam[12] = new SqlParameter("@duedate", clientdetailsEntity.DueDate.Date);
                sparam[13] = new SqlParameter("@paymentDetails", clientdetailsEntity.PaymentDetails);
                sparam[14] = new SqlParameter("@paymentterms", clientdetailsEntity.PaymentTerms);
               int result= SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RE_InsertClientDetails",sparam);
               return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }



       
    }
}