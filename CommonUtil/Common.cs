using DAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CommonUtil
{
    public class Common
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetCountryDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_Country);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetStateDAL(int countryid)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@countryId", countryid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_State, sparams);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetCityDAL(int stateid)
        {
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams ={
                                           new SqlParameter("@cityId",cityId)
                                        };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_Area, sparams);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal DataSet GetIndustryDAL()
        {
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_PHD");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetRole()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, " select * from TechnicalSkillsDetails order by TechnicalSkillName asc ");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataSet GetLocation()
        {
            DataSet ds = new DataSet();
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
            DataSet ds = new DataSet();
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

        internal DataSet GetCityDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from City order by CityName asc");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal DataSet GetAreaDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from CityArea order by AreaName asc");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Method to get all states
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        internal DataSet GetStateDAL()
        {
            DataSet ds = new DataSet();
            try
            {

                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select StateName,StateId from State order by StateName asc");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Method to get Area on cityid
        /// </summary>
        /// <param name="cityId">String to pass collection of cityid's</param>
        /// <returns>System.Data.DataSet</returns>
        internal DataSet GetAreaDAL(string cityId)
        {
            connection.Open();
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = new SqlParameter[1];
                sparams[0] = new SqlParameter("@cityid", cityId);
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_SelectCityArea", sparams);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}