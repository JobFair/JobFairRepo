using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entities.Recruiter;

namespace BAL
{
   public class ViewProfileREBAL
    {
       public DataSet ViewProfile(ViewProfileEntity viewProfileEntity)
       {
           ViewProfileREDAL viewProfileDAL = new ViewProfileREDAL();
           return viewProfileDAL.ViewProfileDAL(viewProfileEntity);
       }
    }
}
