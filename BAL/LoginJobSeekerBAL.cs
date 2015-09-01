using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using DAL;

namespace BAL
{
    public class LoginJobSeekerBAL
    {
        /// <summary>
        /// Jobs the seeker log in.
        /// </summary>
        /// <param name="loginEntity">The login entity.</param>
        /// <returns>SqlDataReader.</returns>
        public SqlDataReader JobSeekerLogIn(LogInJobSeekerEnitity loginEntity)
        {
            LoginJobSeekerDAL loginDAL = new LoginJobSeekerDAL();
            SqlDataReader dataReader = loginDAL.JobSeekerLoginDAL(loginEntity);
            return dataReader;
        }

    }
}
