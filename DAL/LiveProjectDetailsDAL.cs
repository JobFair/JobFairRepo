using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities.JobSeeker;

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
       public int LiveProjectDAL(LiveProjectDetailsEntity liveEntity)
       {
           try
           {
               connection.Open();
               SqlCommand cmd = new SqlCommand();
               SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",liveEntity.CandidateId),
                                          new SqlParameter("@companyName",liveEntity.ClientName),
                                          new SqlParameter("@projectTitle",liveEntity.ProjectTitle),
                                          new SqlParameter("@roleId",liveEntity.roleId),
                                          new SqlParameter("@clientName",liveEntity.ClientName),
                                          new SqlParameter("@projectLink",liveEntity.ProjectLink),
                                          new SqlParameter("@duration",liveEntity.Duration),
                                          new SqlParameter("@projectLocation",liveEntity.ProjectLocation),
                                          new SqlParameter("@emplymentType",liveEntity.EmplymentType),
                                          new SqlParameter("@projectDetails",liveEntity.ProjectDetails),
                                          new SqlParameter("@rolesResponsibility",liveEntity.RolesResponsibility),
                                          new SqlParameter("@teamSize",liveEntity.TeamSize),
                                          new SqlParameter("@skillUsed",liveEntity.SkillUsed)                              
                                      };
               int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_LiveProjectDetails", sqlparams);
               return result;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
