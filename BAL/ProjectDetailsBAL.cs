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

        public DataTable SaveProjectDetailsBAL(DataTable dtProductSold)
        {
            try
            {
                ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
                return projectDetailsDAL.SaveProjectDetailsDAL(dtProductSold);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}