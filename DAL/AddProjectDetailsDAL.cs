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
   public class AddProjectDetailsDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       public DataTable LoadRole()
       {
           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from JS_Roles", connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;
       }
       public int ProjectDetailsDAL(AddProjectDetailsEntity pdEntity)
       {
           try
           {
               connection.Open();
               SqlCommand cmd = new SqlCommand();
               SqlParameter[] sqlparams ={
                                            new SqlParameter("@candidateId",pdEntity.CandidateId),
                                            new SqlParameter("@companyName",pdEntity.CompanyName),
                                            new SqlParameter("@projectTitle",pdEntity.ProjectTitle),
                                            new SqlParameter("@yourRole",pdEntity.YourRole),
                                            new SqlParameter("@clientName",pdEntity.ClientName),
                                            new SqlParameter("@projectLocation",pdEntity.ProjectLocation),
                                            new SqlParameter("@duration",pdEntity.Duration),
                                            new SqlParameter("@employeeType",pdEntity.EmployeeType),
                                            new SqlParameter("@projectDescription",pdEntity.ProjectDescription),
                                            new SqlParameter("@teamSize",pdEntity.TeamSize),
                                            new SqlParameter("@skillUsed",pdEntity.SkillUsed)
                                        };
               int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertProjectDetails", sqlparams);
               return result;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
    }
}
