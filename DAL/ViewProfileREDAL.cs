using Entities.Recruiter;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewProfileREDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        DataSet ds = new DataSet();
        public DataSet ViewProfileDAL(ViewProfileEntity viewProfileEntity)
        {
            
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from RE_RegisterDetails where RecruiterID='RE11'");
                viewProfileEntity.name = ds.Tables[0].Rows[0]["RecruiterfullName"].ToString();
                viewProfileEntity.companyName = ds.Tables[0].Rows[0]["Company"].ToString();
                viewProfileEntity.mobNo = ds.Tables[0].Rows[0]["MobileNumber"].ToString();
                viewProfileEntity.emailId = ds.Tables[0].Rows[0]["OficialEmail_ID"].ToString();
                viewProfileEntity.city = ds.Tables[0].Rows[0]["City"].ToString();
                viewProfileEntity.photo = ds.Tables[0].Rows[0]["PhotoPath"].ToString();
            }
            catch (Exception)
            {
                throw;
            }

            return ds;
        }
        public DataSet GetCountryDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Country");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}