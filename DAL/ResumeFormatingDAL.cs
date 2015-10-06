using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ResumeFormatingDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int SaveResumeFormatateDAL(ResumeFormatingEntity resumeFomatingEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                                new SqlParameter("@candidateId",resumeFomatingEntity.CandidateId),
                                                new SqlParameter("@objective",resumeFomatingEntity.Objective),
                                                new SqlParameter("@profileSummary",resumeFomatingEntity.ProfileSummary),
                                                new SqlParameter("@keyResultArea",resumeFomatingEntity.KeyResultArea),
                                                new SqlParameter("@rolesAndResponsiblity",resumeFomatingEntity.RolesAndResponsiblity),
                                                new SqlParameter("@companyName",resumeFomatingEntity.CompanyName),
                                                new SqlParameter("@extraCircular",resumeFomatingEntity.ExtraCircular),
                                                new SqlParameter("@hobbies",resumeFomatingEntity.Hobbies)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertResumeFormating, sqlparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataSet BindCompanyDAL()
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select CurrentEmployer from JS_CurrentProfessionalDetails where CandidateId='JS00001'");
            return ds;
        }
    }
}