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
        /// For display Re-Post Job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ClonePostJobBAL(int JobId, string RecruiterID)
        {
            return manageJobsDAL.ClonePostJobDAL(JobId, RecruiterID);
        }
    }
}
