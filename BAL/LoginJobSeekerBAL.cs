using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class LogInJobSeekerBAL
    {
        public System.Data.SqlClient.SqlDataReader JobSeekerLogIn(Entities.LogInJobSeekerEnitity logjsEntity)
        {
            LogInJobSeekerDAL loginDAL = new LogInJobSeekerDAL();
            SqlDataReader dataReader = loginDAL.LoginJSDAL(logjsEntity);
            return dataReader;
        }
    }
}
