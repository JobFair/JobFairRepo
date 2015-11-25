using DAL;
using System.Data;
using Entities.JobSeeker;

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

        public DataSet ViewProjectDetailsBAL(string candidateId)
        {
            try
            {
                 ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
                 return projectDetailsDAL.ViewProjectDetailsDAL(candidateId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public int UpdateProjectDetailsBAL(ProjectDetailsEntity projectDetailsEntity)
        {
            try
            {
                ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
                return projectDetailsDAL.UpdateProjectDetailsDAL(projectDetailsEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        public DataSet DeleteProjectDetailsBAL(int projectId)
        {
            try
            {
                ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
                return projectDetailsDAL.DeleteProjectDetailsDAL(projectId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}