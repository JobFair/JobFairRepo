using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.HR;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    // <summary>
    /// Class EmployerDetailsHRDAL
    /// </summary>
    public class EmployerDetailsHRDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method of class EmployerDetailsHRDAL for saving EmployerDetails in database
        /// </summary>
        /// <param name="employerDetailsEntity">Object of EmployerDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveEmployerDetailsDAL(EmployerDetailsHREntity employerDetailsEntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { new SqlParameter("@hrid", employerDetailsEntity.HrId),
                                          new SqlParameter("@companyName", employerDetailsEntity.CompanyName),
                                          new SqlParameter("@employerHRFullName", employerDetailsEntity.EmployerHRFullName),
                                          new SqlParameter("@companyContactNumber", employerDetailsEntity.CompanyContactNumber),
                                          new SqlParameter("@mobileNumber", employerDetailsEntity.MobileNumber),
                                          new SqlParameter("@address", employerDetailsEntity.Address),
                                          new SqlParameter("@countryId", employerDetailsEntity.CountryId),
                                          new SqlParameter("@stateId", employerDetailsEntity.StateId),
                                          new SqlParameter("@cityId", employerDetailsEntity.CityId),
                                          new SqlParameter("@areaId", employerDetailsEntity.AreaId),
                                          new SqlParameter("@pincode", employerDetailsEntity.Pincode),
                                          new SqlParameter("@officialEmailId", employerDetailsEntity.OfficialEmailId),
                                          new SqlParameter("@password", employerDetailsEntity.Password),
                                          new SqlParameter("@status", employerDetailsEntity.Status),
                                          new SqlParameter("@photo", "~/UploadImages/"+employerDetailsEntity.Photo)
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_InsertEmployerDetails, sparam);
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
        /// Method of class EmployerDetailsHRDAL for Updating EmployerDetails in database
        /// </summary>
        /// <param name="employerDetailsEntity">Object of EmployerDetailsHREntity</param>
        /// <returns>System.Int32</returns>
        public int UpdateEmployerDetailsDAL(EmployerDetailsHREntity employerDetailsEntity)
        {
            try
            {
                connection.Open();
                //Add parameter for stored procedure                
                SqlParameter[] sparam = { new SqlParameter("@employerId", employerDetailsEntity.EmployerId),
                                          new SqlParameter("@hrid", employerDetailsEntity.HrId),
                                          new SqlParameter("@companyName", employerDetailsEntity.CompanyName),
                                          new SqlParameter("@employerHRFullName", employerDetailsEntity.EmployerHRFullName),
                                          new SqlParameter("@companyContactNumber", employerDetailsEntity.CompanyContactNumber),
                                          new SqlParameter("@mobileNumber", employerDetailsEntity.MobileNumber),
                                          new SqlParameter("@address", employerDetailsEntity.Address),
                                          new SqlParameter("@countryId", employerDetailsEntity.CountryId),
                                          new SqlParameter("@stateId", employerDetailsEntity.StateId),
                                          new SqlParameter("@cityId", employerDetailsEntity.CityId),
                                          new SqlParameter("@areaId", employerDetailsEntity.AreaId),
                                          new SqlParameter("@pincode", employerDetailsEntity.Pincode),
                                          new SqlParameter("@officialEmailId", employerDetailsEntity.OfficialEmailId),
                                          new SqlParameter("@password", employerDetailsEntity.Password),
                                          new SqlParameter("@status", employerDetailsEntity.Status),
                                          new SqlParameter("@photo", "~/UploadImages/"+employerDetailsEntity.Photo),                                          
                                        };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_UpdateEmployerDetails, sparam);
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
        /// Method of class EmployerDetailsHRDAL for Viewing EmployerDetails in database
        /// </summary>
        public DataSet ViewEmployerDetailsDAL(long employerId, long HrId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@employerId", employerId),
                                             new SqlParameter("@hrId",HrId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_HR_ViewEmployerDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
    }
}
