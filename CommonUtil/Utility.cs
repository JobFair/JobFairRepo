using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CommonUtil
{
    /// <summary>
    /// Class Utility.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Forget password method in Utility class
        /// </summary>
        /// <param name="forgotPasswordEntity">The forgot password entity.</param>
        /// <returns>System.Data.DataSet.</returns>
        public static DataSet ForgetPasswordJobSeeker(ForgetPasswordEntity forgotPasswordEntity)
        {
            try
            {
                ForgetPasswordDAL jobSeekerDAL = new ForgetPasswordDAL();
                return jobSeekerDAL.GetEmailDetailsDAL(forgotPasswordEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Change password method in Utility class
        /// </summary>
        /// <param name="changepasswordEntity">The change password entity</param>
        /// <returns>System.Int32</returns>
        public static int ChangePassword(ChangePasswordEnitity changepasswordEntity)
        {
            try
            {
                ChangePasswordDAL cpDAL = new ChangePasswordDAL();
                return cpDAL.ChangePasswordDALMethod(changepasswordEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetCountry() Method in Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>

        public static DataSet GetCountry()
        {
            try
            {
                Common common = new Common();
                return common.GetCountryDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetState() method of Utility class
        /// </summary>
        /// <param name="countryid">Parameter to get state of desired country </param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetState(int countryid)
        {
            try
            {
                Common common = new Common();
                return common.GetStateDAL(countryid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetCity() Method of Utility class
        /// </summary>
        /// <param name="stateid">Parameter to get city of desired state</param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetCity(int stateid)
        {
            try
            {
                Common common = new Common();
                return common.GetCityDAL(stateid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetArea(int cityId)
        {
            try
            {
                Common common = new Common();
                return common.GetAreaDAL(cityId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetFunctionalArea()
        {
            try
            {
                Common common = new Common();
                return common.GetFunctionalAreaDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get Industries
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetIndustry()
        {
            try
            {
                Common common = new Common();
                return common.GetIndustryDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetDepartment()
        {
            try
            {
                Common common = new Common();
                return common.GetDepartmentDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetEducationalDegreeTypeDAL() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetEducationalDegreeTypeDAL()
        {
            try
            {
                Common common = new Common();
                return common.GetEducationalDegreeTypeDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetLanguage() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetLanguage()
        {
            try
            {
                Common common = new Common();
                return common.GetLanguagesDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetClientName() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetClientName()
        {
            try
            {
                Common common = new Common();
                return common.GetClientNameDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// GetDegreeDetails() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetDegreeDetails(int DegreeId)
        {
            try
            {
                Common common = new Common();
                return common.GetDegreeDetailsDAL(DegreeId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get Roles in utility Class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetRoles()
        {
            try
            {
                Common common = new Common();
                return common.GetRole();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get Location in Utility Class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetLocation()
        {
            try
            {
                Common common = new Common();
                return common.GetLocation();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Mwthod to Get Years in Utility Class
        /// </summary>
        /// <returns>System.Collections.Generic.List</returns>
        public static List<string> GetYears()
        {
            try
            {
                List<string> yearList = new List<string>();
                int i = DateTime.Now.Year;
                for (i = i - 60; i <= DateTime.Now.Year + 4; i++)
                    yearList.Add(Convert.ToString(i));
                return yearList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get Months from System in Utility Class
        /// </summary>
        /// <returns>System.Collections.Generic.List</returns>
        public static List<string> GetMonths()
        {
            try
            {
                string[] months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
                List<string> monthList = null;
                monthList = new List<string>(months);
                monthList.RemoveAt(12);
                return monthList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get Area in Utility Class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetArea()
        {
            try
            {
                Common common = new Common();
                return common.GetAreaDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get State in Utility Class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetState()
        {
            try
            {
                Common common = new Common();
                return common.GetStateDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Get Area from CityId in Utility Class
        /// </summary>
        /// <param name="cityId">String Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetArea(string cityId)
        {
            try
            {
                Common common = new Common();
                return common.GetAreaDAL(cityId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetCity(string stateId)
        {
            try
            {
                Common common = new Common();
                return common.GetCityDAL(stateId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetCountryCode()
        {
            try
            {
                Common common = new Common();
                return common.GetCountryCode();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}