using DAL;
using System.Data.SqlClient;

namespace BAL
{
    public class LogInJobSeekerBAL
    {
        /// <summary>
        /// Login for jobseeker
        /// </summary>
        /// <param name="logjsEntity">The login entity</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader JobSeekerLogIn(Entities.LogInJobSeekerEnitity logjsEntity)
        {
            LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
            SqlDataReader dataReader = loginDAL.LoginJSDAL(logjsEntity);
            return dataReader;
        }
    }
}