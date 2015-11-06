using DAL;
using System.Data;

namespace BAL
{
    public class ProjectDetailsBAL
    {
        /// <summary>
        /// Get fuctional role bal.
        /// </summary>
        /// <returns></returns>
        public DataSet GetRole()
        {
            try
            {
                ProjectDetailsDAL pdDAL = new ProjectDetailsDAL();
                return pdDAL.GetRole();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Project Details of job seeker
        /// </summary>
        /// <param name="dtProjectDetails"></param>
        /// <returns></returns>
        public DataTable SaveProjectDetailsBAL(DataTable dtProjectDetails)
        {
            try
            {
                ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
                return projectDetailsDAL.SaveProjectDetailsDAL(dtProjectDetails);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}