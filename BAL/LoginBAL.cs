using DAL;
using System.Data.SqlClient;

namespace BAL
{
    /// <summary>
    /// LoginBAL class
    /// </summary>
    public class LoginBAL
    {
        /// <summary>
        /// Login for jobseeker
        /// </summary>
        /// <param name="loginEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string JobSeekerLogIn(Entities.LoginEnitity loginEntity)
        {
            try
            {
                LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
                return loginDAL.LoginJSDAL(loginEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
         
           
        }
        /// <summary>
        /// Login for recruiter
        /// </summary>
        /// <param name="lnEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string RecruiterLoginBAL(Entities.LoginEnitity lnEntity)
        {
            try
            {
                LoginRecruiterDAL loginDAL = new LoginRecruiterDAL();
                return loginDAL.LoginRecruDAL(lnEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
    }
}