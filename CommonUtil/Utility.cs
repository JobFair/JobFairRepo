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
            Common lcDAL = new Common();
            return lcDAL.GetCountryDAL();
        }

        /// <summary>
        /// GetState() method of Utility class
        /// </summary>
        /// <param name="countryid">Parameter to get state of desired country </param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetState(int countryid)
        {
            Common lcDAL = new Common();
            return lcDAL.GetStateDAL(countryid);
        }

        /// <summary>
        /// GetCity() Method of Utility class
        /// </summary>
        /// <param name="stateid">Parameter to get city of desired state</param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetCity(int stateid)
        {
            Common lcDAL = new Common();
            return lcDAL.GetCityDAL(stateid);
        }

        public static System.Data.DataSet GetFunctionalArea()
        {
            Common lcDAL = new Common();
            return lcDAL.GetFunctionalAreaDAL();
        }

        /// <summary>
        /// GetIndustry() Method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns

      
     
        public static System.Data.DataSet GetIndustry()
        {
            Common lcDAL = new Common();
            return lcDAL.GetIndustryDAL();
        }
        /// <summary>
        /// GetDepartment() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static System.Data.DataSet GetDepartment()
        {
            Common lcDAL = new Common();
            return lcDAL.GetDepartmentDAL();
        }
    }
}