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
        /// For display Re-Post Job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet RePostJobBAL(int JobId)
        {
            return manageJobsDAL.RePostJobDAL(JobId);
        }
    }
}
