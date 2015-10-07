using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class ResumeFormatingBAL
    {
        private ResumeFormatingDAL resumeFormatingDAL = new ResumeFormatingDAL();

        /// <summary>
        /// Resume Formate of job seeker
        /// </summary>
        /// <param name="resumeFormateEntity">ResumeFormatingEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveResumeFormateBAL(ResumeFormatingEntity resumeFormateEntity)
        {
            return resumeFormatingDAL.SaveResumeFormatateDAL(resumeFormateEntity);
        }

        /// <summary>
        /// Bind company BAL
        /// </summary>
        /// <returns></returns>
        public DataSet BindCompanyBAL()
        {
            return resumeFormatingDAL.BindCompanyDAL();
        }
    }
}