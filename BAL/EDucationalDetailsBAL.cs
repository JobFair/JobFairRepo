using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
   public class EducationalDetailsBAL
    {
       public class EducationalDetailsBAL
       {
           public int EducationalDetailsBAL(EducationalDetailsEntity adEntity)
           {
               EducationalDetailsDAL adDAL = new EducationalDetailsDAL();
               return adDAL.CreateXML(adEntity);
           }
       }
    }
}
