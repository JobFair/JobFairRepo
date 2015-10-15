using DAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CommonUtil
{
    public class Common
    {
        private DataSet ds = new DataSet();
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetCountryDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure,Constants.sp_Country);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetStateDAL(int countryid)
        {
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@countryId", countryid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure,Constants.sp_State, sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetCityDAL(int stateid)
        {
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@stateId", stateid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_City, sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal DataSet GetAreaDAL(int cityId)
        {
            try
            {
                SqlParameter[] sparams ={
                                           new SqlParameter("@cityId",cityId)
                                        };
                ds = SqlHelper.ExecuteDataset(connection,CommandType.StoredProcedure,Constants.sp_Area,sparams);
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal DataSet GetIndustryDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Industry");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Department
        /// </summary>
        /// <returns></returns>
        internal DataSet GetDepartmentDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Department");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// functional area
        /// </summary>
        /// <returns></returns>
        internal DataSet GetFunctionalAreaDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_FunctionalArea");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Education Degrees Type
        /// </summary>
        /// <returns></returns>
        internal DataSet GetEducationalDegreeTypeDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select * from JS_EducationDegreesType");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetLanguagesDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Language");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Get Client Name
        /// </summary>
        /// <returns></returns>
        internal DataSet GetClientNameDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select ClientId,ClientName from RE_ClientDetails where RecruiterID='RE2' ");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Under Graduate Diploma Details
        /// </summary>
        /// <returns></returns>
        internal DataSet GetUnderGraduateDiplomaDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_UnderGraduateDiploma");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Bachelor Degree Details
        /// </summary>
        /// <returns></returns>
        internal DataSet GetBachelorDegreeDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_BachelorDegree");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Post Graduate Diploma Details
        /// </summary>
        /// <returns></returns>
        internal DataSet GetPostGraduateDiplomaDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_PostGraduateDiploma");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Master Degree Details
        /// </summary>
        /// <returns></returns>
        internal DataSet GetMasterDegreeDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_MasterDegree");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Doctor Of Philosophy Details
        /// </summary>
        /// <returns></returns>
        internal DataSet GetDoctorOfPhilosophyDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_DoctorOfPhilosophy");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        internal DataSet GetRole()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, " Select * from JS_Roles ");
                return ds;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        internal DataSet GetLocation()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select * from LocationsMaster");
                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        internal DataSet GetEducation()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select  * from JS_EducationDegreesType ");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}