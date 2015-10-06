using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class ResumeFormatingBAL
    {
        private ResumeFormatingDAL resumeFormatingDAL = new ResumeFormatingDAL();

        public int SaveResumeFormateBAL(ResumeFormatingEntity resumeFormateEntity)
        {
            return resumeFormatingDAL.SaveResumeFormatateDAL(resumeFormateEntity);
        }

        public DataSet BindCompanyBAL()
        {
            return resumeFormatingDAL.BindCompanyDAL();
        }
    }
}