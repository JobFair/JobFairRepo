using DAL;
using Entities;
using System;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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

        public static DataTable GetDepartmentBAL()
        {
            CurrentDesiredJobDAL cdjDAL=new CurrentDesiredJobDAL();
            return cdjDAL.GetDepartmentDAL();
        }

        public static DataTable GetIndustryBAL()
        {
            CurrentDesiredJobDAL cdjDAL = new CurrentDesiredJobDAL();
            return cdjDAL.GetIndustryDAL();
        }

        public static DataSet GetCountry()
        {
            PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
            return pdDAL.GetCountry();
        }

        public static DataTable GetState(int countryid)
        {
            PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
            return pdDAL.GetState(countryid);
          
        }
        public static DataTable GetCity(int stateid)
        {
            PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
            return pdDAL.GetCity(stateid);
        }

        public static DataTable GetFunctionalAreaBAL()
        {
            FunctionalAreaDAL JobDAL = new FunctionalAreaDAL();
            return JobDAL.GetFunctionalDAL();

        }
       
    }

}



