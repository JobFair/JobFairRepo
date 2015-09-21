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
            LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
            return  loginDAL.LoginJSDAL(loginEntity);
           
        }
        /// <summary>
        /// Login for recruiter
        /// </summary>
        /// <param name="lnEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string RecruiterLoginBAL(Entities.LoginEnitity lnEntity)
        {
            LoginRecruiterDAL loginDAL = new LoginRecruiterDAL();
            return loginDAL.LoginRecruDAL(lnEntity);
        }
    }
}