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
             SqlCommand cmd=new SqlCommand("select * from Industry",connection);
             SqlDataAdapter da=new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             return dt;
         }
    }
    }