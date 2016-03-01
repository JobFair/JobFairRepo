using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdvanceSearchDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Get state DAL
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetStateDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from State");
            }
            catch (Exception) 
            {
                // throw ;
            }
            return ds;
        }
        /// <summary>
        /// Get technical skills DAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>datatable</returns>
        public DataTable GetTechnicalSkillDAL(string prefixText)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from TechnicalSkillsDetails where TechnicalSkillName like @KeySkills+'%'", connection);
                cmd.Parameters.AddWithValue("@KeySkills", prefixText);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        /// <summary>
        /// Get roles DAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>datatable</returns>
        public DataTable GetRoles(string prefixText)
        {
            DataTable dt = new DataTable();
           
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Constants.sp_JS_SelectKeywords,connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@searchtext", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
     
                //string[] items = new string[dt.Rows.Count];
                //int i = 0;
                //foreach (DataRow dr in dt.Rows)
                //{
                
                //    items.SetValue(dr["AllName"].ToString(), i);
                //    i++;
                //}
                //return items;  
                
            }

            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }

            return dt;
         
           
            
        }
        /// <summary>
        /// Search for job
        /// </summary>
        /// <param name="advanceSearchEntity">AdvanceSearchDetailsEntity</param>
        /// <returns>dataset</returns>
        public DataSet Search(Entities.JobSeeker.AdvanceSearchDetailsEntity advanceSearchEntity)
        {
            connection.Open();
            DataSet dsAdvancesearch = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_JS_SelectAdvanceSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KeywordsTechnical", advanceSearchEntity.KeySkill);
                cmd.Parameters.AddWithValue("@JobLocationState", advanceSearchEntity.State);
                cmd.Parameters.AddWithValue("@JobLocationCity", advanceSearchEntity.City);
                cmd.Parameters.AddWithValue("@JobLocationArea", advanceSearchEntity.Area);
                cmd.Parameters.AddWithValue("@WorkExperienceMin", advanceSearchEntity.WorkExpMin);
                cmd.Parameters.AddWithValue("@WorkExperienceMax", advanceSearchEntity.WorkExpMax);
                cmd.Parameters.AddWithValue("@OfferedAnnualSalaryMin", advanceSearchEntity.MinSalary);
                cmd.Parameters.AddWithValue("@OfferedAnnualSalaryMax", advanceSearchEntity.MaxSalary);
                cmd.Parameters.AddWithValue("@JobIndustryId", advanceSearchEntity.Industry);
                cmd.Parameters.AddWithValue("@EmploymentStatus", advanceSearchEntity.EmpStatus);
                cmd.Parameters.AddWithValue("@JobType", advanceSearchEntity.JobType);
                cmd.Parameters.AddWithValue("@RecruitmentType", advanceSearchEntity.RecruitmentType);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsAdvancesearch);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ////connection.Close();
            }
            return dsAdvancesearch;
        }
    }
}