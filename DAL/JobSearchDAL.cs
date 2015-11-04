using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
   public class JobSearchDAL
    {
       private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

       public DataSet JobSearch(string keySkills, string city, string experience, string minSalary, string maxSalary, int functionalArea)
       {
           string query = "select * from RE_JobPost where KeywordsTechnical like '" + keySkills + "%' and JobLocationCity='" + city + "' and WorkExperience='" + experience + "'and OfferedAnnualSalaryMin='" + minSalary + "'and OfferedAnnualSalaryMax='" + maxSalary + "'and FunctionalAreaId='"+functionalArea+"'";
           SqlDataAdapter sda = new SqlDataAdapter(query, connection);
           DataSet ds = new DataSet();
           sda.Fill(ds);
           return ds;
       }
    }
}
