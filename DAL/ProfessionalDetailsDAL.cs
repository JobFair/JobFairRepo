using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
  public  class ProfessionalDetailsDAL
    {
      private SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public int InsertDetails(ProfessionalDetailsEntity professionaldetailentity)
        {
            try
            {
                Connection.Open();
                SqlParameter[] sqlparams = {
                                            new SqlParameter ("@RecruiterID",professionaldetailentity.RecruiterID),
                                            new SqlParameter("@TotalExprience",professionaldetailentity.TotalExprience),
                                            new SqlParameter ("@Designation",professionaldetailentity.Designation),
                                            new SqlParameter("@Freelancer",professionaldetailentity.Freelancer),
                                            new SqlParameter("@EmploymentStaus",professionaldetailentity.EmploymentStaus),
                                            new SqlParameter("@jobtype",professionaldetailentity.jobtype)
                                            };
                return SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_RE_InsertProfessionalDetails, sqlparams);

            }
            catch (Exception)
            {
                
                throw;
            }
        }

       


        public DataSet GetTechnicalSillsDetailsBAL()
        {

            DataSet dstechnicalskill = new DataSet();
            try
            {
                dstechnicalskill = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select * from TechnicalSkillsDetails order by TechnicalSkillName asc");
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                Connection.Close();
            }
            return dstechnicalskill;
        }

        public DataSet ViewTechnicalskillBAL(string RecruiterID)
        {
            DataSet ds = new DataSet();
            try
            {
                ProfessionalDetailsEntity professionaldetailentity = new ProfessionalDetailsEntity();
                Connection.Open();

                SqlParameter[] sparams = { new SqlParameter("@recruiterId",  RecruiterID) };

                ds = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                Connection.Close();
            }
            return ds;
        }

        public  void  AddTechnicalSkillDAL(ProfessionalDetailsEntity professionalDetailentity)
        {
            try
            {
                Connection.Open();
                SqlParameter[] sparams = { new SqlParameter("@SkillName",  professionalDetailentity.TechnicalSkill) };
                SqlHelper.ExecuteNonQuery(Connection, CommandType.StoredProcedure, Constants.sp_RE_InsertTechnicalSkill, sparams);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public DataTable SaveRoleSkillsDAL(DataTable dt)
        {
            try
            {
                Connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(Connection);

                // Assigning Destination table name
                objbulk.DestinationTableName = "RE_TechnicalSkillDetails";

                // Mapping Table column
                objbulk.ColumnMappings.Add("RecruiterId", "RecruiterId");
                objbulk.ColumnMappings.Add("RoleSkills", "RoleSkills");
                objbulk.ColumnMappings.Add("FromDate", "FromDate");
                objbulk.ColumnMappings.Add("TillDate", "TillDate");
                objbulk.ColumnMappings.Add("Proficiency", "Proficiency");
                objbulk.ColumnMappings.Add("TotalYear", "TotalYear");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }


        public  DataTable SaveTechnicalSkillDAL(DataTable dt)
        {
            try
            {
                Connection.Open();

                // Creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(Connection);

                // Assigning Destination table name
                objbulk.DestinationTableName = "RE_TechnicalSkillDetails";

                // Mapping Table column
                objbulk.ColumnMappings.Add("RecruiterId", "RecruiterId");
                objbulk.ColumnMappings.Add("TechnicalSkills", "TechnicalSkills");
                objbulk.ColumnMappings.Add("FromDate", "FromDate");
                objbulk.ColumnMappings.Add("TillDate", "TillDate");
                objbulk.ColumnMappings.Add("Proficiency", "Proficiency");
                objbulk.ColumnMappings.Add("TotalYear", "TotalYear");

                // Inserting bulk Records into DataBase
                objbulk.WriteToServer(dt);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public DataSet GetRoleSkillsDAL()
        {

            DataSet ds = new DataSet();
            Connection.Open();
            try
            {
                ds = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select * from RoleSkills order by RoleName asc");
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                Connection.Close();
            }
            return ds;
        }
    }
}
