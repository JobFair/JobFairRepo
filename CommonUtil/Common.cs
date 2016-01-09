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

        /// <summary>
        /// Get country
        /// </summary>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get state
        /// </summary>
        /// <param name="countryid">countryid</param>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get city
        /// </summary>
        /// <param name="stateid">stateid</param>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get area
        /// </summary>
        /// <param name="cityId">cityId</param>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get industry
        /// </summary>
        /// <returns>dataset</returns>
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
        /// <returns>dataset</returns>
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
        /// <returns>dataset</returns>
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
        /// <returns>dataset</returns>
        internal DataSet GetEducationalDegreeTypeDAL()
        {
            DataSet dsEducationalDegreeType = new DataSet();
            try
            {
                dsEducationalDegreeType = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select * from JS_EducationDegreesType");
            }
            catch (Exception)
            {
                // throw ;
            }
            finally
            {
                connection.Close();
            }
            return dsEducationalDegreeType;
        }

        internal DataSet GetEducationalDegreeTypeDAL(string CandidateId)
        {
            DataSet dsEducationalDegreeType = new DataSet();
            try
            {
                SqlParameter[] sparams ={
                                           new SqlParameter("@CandidateId",CandidateId)
                                        };
                dsEducationalDegreeType = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select DegreeId,DegreeType from JS_EducationDegreesType where degreeid not in (select degreeid from JS_EducationDetails where CandidateId = @CandidateId)", sparams);
            }
            catch (Exception)
            {
                // throw ;
            }
            finally
            {
                connection.Close();
            }
            return dsEducationalDegreeType;
        }

        /// <summary>
        /// Get languages
        /// </summary>
        /// <returns>dataset</returns>
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
        /// <returns>dataset</returns>
        internal DataSet GetClientNameDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "Select ClientId,ClientName,ClientProfile from HR_ClientDetails where HrId=1 ");
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        /// <summary>
        /// Get Degree Details
        /// </summary>
        /// <returns>dataset</returns>
        internal DataSet GetDegreeDetailsDAL(int DegreeId)
        {
            DataSet dsDegreeDetails = new DataSet();
            try
            {
                SqlParameter[] sqlparams = { new SqlParameter("@degreeId", DegreeId) };
                dsDegreeDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_SelectDegreeDetails, sqlparams);
            }
            catch (Exception)
            {
                //throw ;
            }
            finally
            {
                connection.Close();
            }
            return dsDegreeDetails;
        }

        /// <summary>
        /// Get role
        /// </summary>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get location
        /// </summary>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get education
        /// </summary>
        /// <returns>dataset</returns>
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

        /// <summary>
        /// Get city
        /// </summary>
        /// <returns>dataset</returns>
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

        internal DataSet GetCountryCode()
        {
            connection.Open();
            DataSet datasetCountryCode = new DataSet();
            try
            {
                datasetCountryCode = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from CountryCode");
                return datasetCountryCode;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}