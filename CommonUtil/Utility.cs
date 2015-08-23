using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Data;


namespace CommonUtil
{
    public static class Utility
    {

        
        public static DataSet ForgetPasswordJobSeeker(ForgetPasswordEntity fpEntity)
        {
            RegisterJobSeekerDAL rjsDAL = new RegisterJobSeekerDAL();
            try
            {
                return rjsDAL.GetEmailDetailsDAL(fpEntity);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
