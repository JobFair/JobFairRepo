using DAL;
using Entities;
using System;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CommonUtil
{
    /// <summary>
    /// Class Utility.
    /// </summary>
    public static class Utility
    {
        

        /// <summary>
        /// Forget password
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
        /// Change password
        /// </summary>
        /// <param name="cpentity">The change password entity</param>
        /// <returns>System.Int32</returns>
        public static int ChangePassword(ChangePasswordEnitity cpentity)
        {
            ChangePasswordDAL cpDAL = new ChangePasswordDAL();
            return cpDAL.ChangePasswordDALMethod(cpentity);
        }

       

       

        public static DataSet GetCountry()
        {
            LoadCommonDAL lcDAL = new LoadCommonDAL();
            return lcDAL.GetCountryDAL();
         }

        public static DataSet GetState(int countryid)
        {
            LoadCommonDAL lcDAL = new LoadCommonDAL();
            return lcDAL.GetStateDAL(countryid);
          
        }
        public static DataSet GetCity(int stateid)
        {
            LoadCommonDAL lcDAL = new LoadCommonDAL();
            return lcDAL.GetCityDAL(stateid);
        }

        public static DataTable GetFunctionalAreaBAL()
        {
            FunctionalAreaDAL JobDAL = new FunctionalAreaDAL();
            return JobDAL.GetFunctionalDAL();

        }


        public static System.Data.DataSet GetIndustry()
        {
            LoadCommonDAL lcDAL = new LoadCommonDAL();
            return lcDAL.GetIndustryDAL();
        }

        public static System.Data.DataSet GetDepartment()
        {
            LoadCommonDAL lcDAL = new LoadCommonDAL();
            return lcDAL.GetDepartmentDAL();
        }
    }

}



