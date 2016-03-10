using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
   public  class EmployerpdfBAL
    {
        public System.Data.DataSet GetEmployerDetails()
        {
            EmployerpdfDAL employerpdfDAL = new EmployerpdfDAL();
            return employerpdfDAL.GetEmployerDetails();
        }
    }
}
