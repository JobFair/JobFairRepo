using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
   public class AffirmativeDetailsJSBAL
    {
       /// <summary>
       /// Affirmative Details of job seeker
       /// </summary>
        /// <param name="adEntity">AffirmativeDetailsEntity</param>
        /// <returns>System.Int32</returns>
       public int AffirmativeDetailsBAL(AffirmativeDetailsEntity adEntity)
       {
           AffirmativeDetailsJSDAL adDAL = new AffirmativeDetailsJSDAL();
           return adDAL.AffirmativeDetailsDAL(adEntity);
       }
    }
}
