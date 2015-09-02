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
        /// Forgets the password job seeker.
        /// </summary>
        /// <param name="forgotPasswordEntity">The forgot password entity.</param>
        /// <returns>DataSet.</returns>
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
      
    }
}