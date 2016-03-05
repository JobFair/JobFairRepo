using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    /// <summary>
    /// LogInEmployerBAL class
    /// </summary>
    public class LogInEmployerBAL
    {
        /// <summary>
        /// Login for Employer
        /// </summary>
        /// <param name="loginEntity">The login entity</param>
        /// <returns>System.String</returns>
        public string EmployerLogIn(Entities.LoginEnitity loginEntity)
        {
            LogInEmployerDAL logInEmployerDAL = new LogInEmployerDAL();
            return logInEmployerDAL.LoginEmpDAL(loginEntity);
        }

    }
}
