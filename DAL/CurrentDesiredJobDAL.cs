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

                 catch (Exception ex)
                 {
                     throw ex;
                 }
                 finally
                 {
                     connection.Close();
                 }
         }
    }
    }