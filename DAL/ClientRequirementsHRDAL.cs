using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.HR;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    // <summary>
    /// ClientRequirementsHRDAL class
    /// </summary>
    public class ClientRequirementsHRDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method of class ClientRequirementsHRDAL for saving ClientRequirements in database
        /// </summary>
        /// <param name="clientrequirementsHREntity">Object of ClientRequirementsHREntity</param>
        /// <returns>System.Int32</returns>
        public int SaveClientRequirementsDAL(ClientRequirementsHREntity clientRequirementsHREntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { new SqlParameter("@hrid", clientRequirementsHREntity.HrId),
                                          new SqlParameter("@clientId", clientRequirementsHREntity.ClientId),
                                          new SqlParameter("@clientName", clientRequirementsHREntity.ClientName),
                                          new SqlParameter("@clientProfile", clientRequirementsHREntity.ClientProfile),
                                          new SqlParameter("@position", clientRequirementsHREntity.Position),
                                          new SqlParameter("@industry", clientRequirementsHREntity.Industry),
                                          new SqlParameter("@functuionalarea", clientRequirementsHREntity.FunctionalArea),
                                          new SqlParameter("@address", clientRequirementsHREntity.Address),
                                          new SqlParameter("@countryId", clientRequirementsHREntity.CountryId),
                                          new SqlParameter("@stateId", clientRequirementsHREntity.StateId),
                                          new SqlParameter("@cityId", clientRequirementsHREntity.CityId),
                                          new SqlParameter("@areaId", clientRequirementsHREntity.AreaId),
                                          new SqlParameter("@pincode", clientRequirementsHREntity.Pincode),
                                          new SqlParameter("@skillsets", clientRequirementsHREntity.Skillsets),
                                          new SqlParameter("@contents", clientRequirementsHREntity.Contents),
                                          new SqlParameter("@dateOfRequirementSent", clientRequirementsHREntity.DateOfRequirementSent.Date),
                                          new SqlParameter("@dueDate", clientRequirementsHREntity.DueDate.Date),
                                          new SqlParameter("@status", clientRequirementsHREntity.Status),
                                          new SqlParameter("@recruiterID", clientRequirementsHREntity.RecruiterID),
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_InsertClientRequirements, sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get Recruiter DAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>datatable</returns>
        public DataTable GetRecruiter(string prefixText)
        {
            DataTable dtRecruiter = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select RecruiterID,RecruiterfullName from HR_RecruiterRegister  where RecruiterfullName like @RecruiterfullName+'%'", connection);
                cmd.Parameters.AddWithValue("@RecruiterfullName", prefixText);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dtRecruiter);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dtRecruiter;
        }
    }
}
