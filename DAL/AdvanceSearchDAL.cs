using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdvanceSearchDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetStateDAL()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from State");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetTechnicalSkillDAL(string prefixText)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from TechnicalSkillsDetails where TechnicalSkillName like @KeySkills+'%'", connection);
                cmd.Parameters.AddWithValue("@KeySkills", prefixText);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }



        public DataTable GetRoles(string prefixText)
        {
            DataTable dt = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from RoleSkills  where RoleName like @RoleName+'%'", connection);
            cmd.Parameters.AddWithValue("@RoleName", prefixText);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public DataSet Getsearch(Entities.JobSeeker.AdvanceSearchDetailsEntity advanceSearchEntity)
        {
            connection.Open();
            try
            {
                DataSet dsAdvancesearch = new DataSet();
                SqlCommand cmd = new SqlCommand("sp_JS_SelectAdvanceSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KeywordsTechnical", advanceSearchEntity.KeySkill);
                cmd.Parameters.AddWithValue("@JobLocationState", advanceSearchEntity.State);
                cmd.Parameters.AddWithValue("@JobLocationCity", advanceSearchEntity.City);
                cmd.Parameters.AddWithValue("@JobLocationArea", advanceSearchEntity.Area);
                cmd.Parameters.AddWithValue("@WorkExperience", advanceSearchEntity.WorkExp);
                cmd.Parameters.AddWithValue("@OfferedAnnualSalaryMin", advanceSearchEntity.MinSalary);
                cmd.Parameters.AddWithValue("@OfferedAnnualSalaryMax", advanceSearchEntity.MaxSalary);
                cmd.Parameters.AddWithValue("@IndustryId", advanceSearchEntity.Industry);
                cmd.Parameters.AddWithValue("@EmploymentStatus", advanceSearchEntity.EmpStatus);
                cmd.Parameters.AddWithValue("@JobType", advanceSearchEntity.JobType);
                cmd.Parameters.AddWithValue("@RecruitmentType", advanceSearchEntity.RecruitmentType);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsAdvancesearch);
                return dsAdvancesearch;



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