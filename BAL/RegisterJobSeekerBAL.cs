using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Data.SqlClient;

namespace BAL
{
   public class RegisterJobSeekerBAL
    {
       public int RegisterNewJobSeekerBAL(RegisterJobSeekerEntity rjsEntity)
        {
            RegisterJobSeekerDAL rjsDAL = new RegisterJobSeekerDAL();
            return rjsDAL.RegisterNewJobSeekerDAL(rjsEntity);

        }



       public SqlDataReader JobSeekerLogIn(LogInJobSeekerEnitity logjsEntity)
       {

           RegisterJobSeekerDAL jsloginDAL = new RegisterJobSeekerDAL();
           SqlDataReader rdr = jsloginDAL.JobSeekerLoginDAL(logjsEntity);
           return rdr;
           
       }
    }
}
