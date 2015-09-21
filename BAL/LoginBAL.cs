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
        /// <param name="logjsEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string JobSeekerLogIn(Entities.LogInEnitity logjsEntity)
        {
            LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
            return  loginDAL.LoginJSDAL(logjsEntity);
           
        }
        /// <summary>
        /// Login for recruiter
        /// </summary>
        /// <param name="lnEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string RecruiterLoginBAL(Entities.LogInEnitity lnEntity)
        {
            LoginRecruiterDAL loginDAL = new LoginRecruiterDAL();
            return loginDAL.LoginRecruDAL(lnEntity);
        }
    }
}