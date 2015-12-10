using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class JobSearchDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet JobSearch(string keySkills, string city, string experience, string minSalary, string maxSalary, int functionalArea)
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from RE_JobPost where KeywordsTechnical like '" + keySkills + "%' and JobLocationCity='" + city + "' and WorkExperience='" + experience + "'and OfferedAnnualSalaryMin='" + minSalary + "'and OfferedAnnualSalaryMax='" + maxSalary + "'and FunctionalAreaId='" + functionalArea + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                sda.Fill(ds);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }
    }
}