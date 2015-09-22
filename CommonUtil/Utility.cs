using DAL;
using Entities;
using System;
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
            ForgetPasswordDAL jobSeekerDAL = new ForgetPasswordDAL();
            try
            {
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
            ChangePasswordDAL cpDAL = new ChangePasswordDAL();
            return cpDAL.ChangePasswordDALMethod(changepasswordEntity);
        }

        /// <summary>
        /// GetCountry() Method in Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>

        public static DataSet GetCountry()
        {
            Common common = new Common();
            return common.GetCountryDAL();
        }

        /// <summary>
        /// GetState() method of Utility class
        /// </summary>
        /// <param name="countryid">Parameter to get state of desired country </param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetState(int countryid)
        {
            Common common = new Common();
            return common.GetStateDAL(countryid);
        }

        /// <summary>
        /// GetCity() Method of Utility class
        /// </summary>
        /// <param name="stateid">Parameter to get city of desired state</param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetCity(int stateid)
        {
            Common common = new Common();
            return common.GetCityDAL(stateid);
        }

        public static DataSet GetFunctionalArea()
        {
            Common common = new Common();
            return common.GetFunctionalAreaDAL();
        }

        /// <summary>
        /// Get Industries
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetIndustry()
        {
            Common common = new Common();
            return common.GetIndustryDAL();
        }
        /// <summary>
        /// Get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetDepartment()
        {
            Common common = new Common();
            return common.GetDepartmentDAL();
        }
        /// <summary>
        /// GetEducationalDegreeTypeDAL() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetEducationalDegreeTypeDAL()
        {
            Common common = new Common();
            return common.GetEducationalDegreeTypeDAL();
        }

        public static DataSet GetLanguage()
        {
            Common common = new Common();
            return common.GetLanguagesDAL();
        }
    }
}