using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LiveProjectDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataTable GetRole()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from JS_Roles", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }

        public int SaveLiveProjectDAL(LiveProjectDetailsEntity liveProjectDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",liveProjectDetailsEntity.CandidateId),
                                          new SqlParameter("@companyName",liveProjectDetailsEntity.ClientName),
                                          new SqlParameter("@projectTitle",liveProjectDetailsEntity.ProjectTitle),
                                          new SqlParameter("@roleId",liveProjectDetailsEntity.RoleId),
                                          new SqlParameter("@clientName",liveProjectDetailsEntity.ClientName),
                                          new SqlParameter("@projectLink",liveProjectDetailsEntity.ProjectLink),
                                          new SqlParameter("@duration",liveProjectDetailsEntity.Duration),
                                          new SqlParameter("@projectLocation",liveProjectDetailsEntity.ProjectLocation),
                                          new SqlParameter("@emplymentType",liveProjectDetailsEntity.EmplymentType),
                                          new SqlParameter("@projectDetails",liveProjectDetailsEntity.ProjectDetails),
                                          new SqlParameter("@rolesResponsibility",liveProjectDetailsEntity.RolesResponsibility),
                                          new SqlParameter("@teamSize",liveProjectDetailsEntity.TeamSize),
                                          new SqlParameter("@skillUsed",liveProjectDetailsEntity.SkillUsed)
                                      };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_LiveProjectDetails, sqlparams);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}