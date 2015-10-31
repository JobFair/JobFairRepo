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
    public class ProjectDetailsBAL
    {
        /// <summary>
        /// Get fuctional role bal.
        /// </summary>
        /// <returns></returns>
        public DataTable GetRole()
        {
            ProjectDetailsDAL pdDAL = new ProjectDetailsDAL();
            return pdDAL.GetRole();
        }

        public DataTable SaveProjectDetailsBAL(DataTable dtProductSold)
        {
            ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
            return projectDetailsDAL.SaveProjectDetailsDAL(dtProductSold);
        }
    }

}
