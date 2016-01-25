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
    }
}
