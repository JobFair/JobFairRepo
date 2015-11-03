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