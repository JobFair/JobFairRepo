using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CurrentDesiredJobDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int CurrentProfessionalDetailsDAL(CurrentDesiredJobEntity curentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sparams = { new SqlParameter("@candidateId",curentity.Candidateid),
                                            new SqlParameter("@resumeheadline",curentity.ResumeHeadline),
                                            new SqlParameter("@totalExp",curentity.TotalExperience),
                                            new SqlParameter("@industryId",curentity.Industry),
                                            new SqlParameter("@departmentId",curentity.Department),
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

                int res = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertProfessionalDetails", sparams);
                return res;
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

        public DataTable GetDepartmentDAL()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Departments", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetIndustryDAL()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Industry", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int DesiredJobDetailsDAL(CurrentDesiredJobEntity cdjEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams ={new SqlParameter("@candidateid",cdjEntity.Candidateid),
                                      new SqlParameter("@jobpostlooking",cdjEntity.JobPostLooking),
                                      new SqlParameter("@releventExp",cdjEntity.RelevantExp),
                                      new SqlParameter("@currentanualSal",cdjEntity.CurrentAnualSal),
                                      new SqlParameter("@expectedanualSal",cdjEntity.ExpectedAnualSal),
                                      new SqlParameter("@noticeperiod",cdjEntity.NoticePeriod),
                                      new SqlParameter("@employmentstatus",cdjEntity.EmploymentStatus),
                                      new SqlParameter("@jobtype",cdjEntity.JobType),
                                      new SqlParameter("@workarea",cdjEntity.WorkArea),
                                      new SqlParameter("@preferrdCountry",cdjEntity.PreferredCountry),
                                      new SqlParameter("@preferredstate",cdjEntity.PreferredState),
                                      new SqlParameter("@preferredcity",cdjEntity.PreferredCity)};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertDesiredJobDetails", sparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}