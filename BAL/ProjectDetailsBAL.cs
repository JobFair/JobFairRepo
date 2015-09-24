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

        /// <summary>
        /// Add project details job seeker bal.
        /// </summary>
        /// <param name="addProjectDetailsEntity">AddProjectDetailsEntity</param>
        /// <returns>System.Int32.</returns>
        public int SaveProjectDetailsBAL(ProjectDetailsEntity addProjectDetailsEntity)
        {
            ProjectDetailsDAL pdDAL = new ProjectDetailsDAL();
            return pdDAL.SaveProjectDetailsDAL(addProjectDetailsEntity);
        }
    }

}
