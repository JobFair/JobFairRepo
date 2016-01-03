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
    public class ManageJobsBAL
    {
        private ManageJobsDAL manageJobsDAL = new ManageJobsDAL();
        /// <summary>
        /// For display posted job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ManageJobsDetailsBAL()
        {
            return manageJobsDAL.ManageJobsDetetailsDAL();
        }
        /// <summary>
        /// For display posted perticular job details of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ViewJobsDetailsBAL(int JobId)
        {
            return manageJobsDAL.ViewJobsDetetailsDAL(JobId);
        }
        /// <summary>
        /// For display Re-Post(Clone) Job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ClonePostJobBAL(int JobId, int RecruiterID, String IsActive)
        {
            return manageJobsDAL.ClonePostJobDAL(JobId, RecruiterID, IsActive);
        }
        /// <summary>
        /// For display Delete(Change IsActive Status) Job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet DeletePostJobBAL(int JobHistroryId, int JobId, int RecruiterID)
        {
            return manageJobsDAL.DeletePostJobDAL(JobHistroryId, JobId, RecruiterID);
        }

    }
}
