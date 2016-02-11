using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class ManageResponsesBAL
    {

        /// <summary>
        ///   Create Method for active jobs
        /// </summary>
        /// <returns></returns>
        public DataSet GetActiveJobs()
        {
            ManageResponsesDAL manageresponsesDAL = new ManageResponsesDAL();
            return manageresponsesDAL.GetActiveJobs();
        }
        /// <summary>
        /// Create Method for inactive jobs
        /// </summary>
        /// <returns></returns>

        public DataSet GetInActiveJobs()
        {
            ManageResponsesDAL manageresponsesDAL = new ManageResponsesDAL();
            return manageresponsesDAL.GetInActiveJobs();
        }
    }
}
