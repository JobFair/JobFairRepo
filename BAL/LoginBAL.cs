using DAL;
using System.Data.SqlClient;

namespace BAL
{
    public class LoginBAL
    {
        /// <summary>
        /// Login for jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader JobSeekerLogIn(Entities.LogInEnitity logjsEntity)
        {
            LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
            SqlDataReader dataReader = loginDAL.LoginJSDAL(logjsEntity);
            return dataReader;
        }

        public string RecruiterLoginBAL(Entities.LogInEnitity lnEntity)
        {
            LoginRecruiterDAL loginDAL = new LoginRecruiterDAL();
            return loginDAL.LoginRecruDAL(lnEntity);
        }
    }
}