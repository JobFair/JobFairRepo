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
            RegisterJobSeekerDAL jobSeekerDAL = new RegisterJobSeekerDAL();
            try
            {
                return jobSeekerDAL.GetEmailDetailsDAL(forgotPasswordEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetIndustryBAL()
        {
            ProfessionalDetailsCurrentJSDAL pdcDAL = new ProfessionalDetailsCurrentJSDAL();
            return pdcDAL.GetIndustryDAL();
            
        }

        public static DataTable GetDepartmentBAL()
        {
            ProfessionalDetailsCurrentJSDAL pdDAL = new DAL.ProfessionalDetailsCurrentJSDAL();
            return pdDAL.GetDepartmentDAL();
        }
    }
}