using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProfessionalDetailsCurrentJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Current Professional Details of job seeker
        /// </summary>
        /// <param name="curentity">To add parameters into database</param>
        /// <returns>System.Int32</returns>

        public int CurrentProfessionalDetailsDAL(Current_DesiredJobDetailsEntity curentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = { new SqlParameter("@userid",curentity.Userid),
                                       new SqlParameter("@resumeheadline",curentity.ResumeHeadline),
                                       new SqlParameter("@totalExp",curentity.TotalExperience),
                                       new SqlParameter("@industry",curentity.Industry),
                                       new SqlParameter("@department",curentity.Department),
                                       new SqlParameter("@currentjobrole",curentity.CurrentJobRole),
                                       new SqlParameter("@currentemployer",curentity.CurrentEmployer),
                                       new SqlParameter("@primfunrole",curentity.PrimFunctionalRole),
                                       new SqlParameter("@primjobdesrip",curentity.PrimJobDescrip),
                                       new SqlParameter("@primtechskills",curentity.PrimTechSkills),
                                       new SqlParameter("@secfunrole",curentity.SecFunctionalRole),
                                       new SqlParameter("@secjobdescrip",curentity.SecJobDescrip),
                                       new SqlParameter("@sectechskills",curentity.SecTechSkills),
                                       new SqlParameter("@technicalskills",curentity.TechnicalSkills),
                                       new SqlParameter("@reasonforjobchange",curentity.ReasonforJobChange),
                                       new SqlParameter("@designation",curentity.Designation)};
                int res = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "InsertProfessionalCurrentDetails", sparams);
                return res;

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

        public DataTable GetIndustryDAL()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from IndustryMaster",connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable GetDepartmentDAL()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Departments",connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
