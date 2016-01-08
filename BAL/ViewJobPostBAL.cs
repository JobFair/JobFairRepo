using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
   public class ViewJobPostBAL
    {
       public DataSet ViewAllJobPostBAL()
       {
           ViewJobPostJSDAL viewJobPostJSDAL = new ViewJobPostJSDAL();
           return viewJobPostJSDAL.ViewAllJobPostDAL();
       }
    }
}
