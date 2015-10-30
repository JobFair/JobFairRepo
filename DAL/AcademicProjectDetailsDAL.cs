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
   public class AcademicProjectDetailsDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       public int SaveAcademicProjectDAL(AcademicProjectDetailsEntity academicProjectDetailsEntity)
       {
           try
           {
               connection.Open();
               SqlCommand cmd = new SqlCommand();
               SqlParameter[] sqlparams ={
                                            new SqlParameter("@candidateId",academicProjectDetailsEntity.CandidateId),
                                            new SqlParameter("@projectName",academicProjectDetailsEntity.ProjectName),
                                            new SqlParameter("@duration",academicProjectDetailsEntity.Duration),
                                            new SqlParameter("@projectDetails",academicProjectDetailsEntity.ProjectDetails),
                                            new SqlParameter("@rolesAndResponsibility",academicProjectDetailsEntity.RolesAndResponsibility),
                                            new SqlParameter("@teamSize",academicProjectDetailsEntity.TeamSize),
                                            new SqlParameter("@skillUsed",academicProjectDetailsEntity.SkillUsed),
                                            new SqlParameter("@liveProject",academicProjectDetailsEntity.LiveProject),
                                            new SqlParameter("@projectURL",academicProjectDetailsEntity.ProjectURL)
                                           
                                        };
               int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertAcademicProjectDetails, sqlparams);
               return result;
           }
           catch (Exception)
           {
               throw;
           }
       }
    }
}
