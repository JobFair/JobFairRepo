using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entities.JobSeeker;

namespace BAL
{
   public class AddProjectDetailsBAL
    {
       /// <summary>
       /// Get fuctional role bal.
       /// </summary>
       /// <returns></returns>
        public DataTable GetRole()
      {
          AddProjectDetailsDAL pdDAL = new AddProjectDetailsDAL();
          return pdDAL.GetRole();
      }
       /// <summary>
        /// Add project details job seeker bal.
       /// </summary>
        /// <param name="pdEntity">AddProjectDetailsEntity</param>
        /// <returns>System.Int32.</returns>
      public int ProjectDetailsBAL(AddProjectDetailsEntity pdEntity)
      {
          AddProjectDetailsDAL pdDAL = new AddProjectDetailsDAL();
          return pdDAL.ProjectDetailsDAL(pdEntity);
      }
    }
}
