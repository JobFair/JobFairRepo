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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
        }

        internal DataSet GetStateDAL(int countryid)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@countryId", countryid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_State, sparams);
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
        }

        internal DataSet GetCityDAL(int stateid)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@stateId", stateid) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_City, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        internal DataSet GetIndustryDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Industry");
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
        }

        internal DataSet GetLanguagesDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Language");
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
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
            }
            catch (Exception)
            {
                //throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                //throw ;
            }
            return ds;
        }

        internal DataSet GetRole()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, " select * from TechnicalSkillsDetails order by TechnicalSkillName asc ");
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
        }

        internal DataSet GetLocation()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select * from LocationsMaster");
            }
            catch (Exception)
            {
                // throw ;
            }
            return ds;
        }

        internal DataSet GetEducation()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select  * from JS_EducationDegreesType ");
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
        }

        internal DataSet GetCityDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from City order by CityName asc");
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
        }

        internal DataSet GetAreaDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from CityArea order by AreaName asc");
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
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
            }
            catch (Exception)
            {
                //throw ;
            }
            return ds;
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
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        internal DataSet GetCityDAL(string stateId)
        {
            connection.Open();
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = new SqlParameter[1];
                sparams[0] = new SqlParameter("@stateId", stateId);
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectCity", sparams);
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }
    }
}