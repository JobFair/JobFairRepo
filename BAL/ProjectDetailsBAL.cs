using DAL;
using Entities.JobSeeker;
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
        /// <param name="dtProjectDetails">dtProjectDetails</param>
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

        /// <summary>
        /// View projectDetails of Job Seeker
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns></returns>
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

        /// <summary>
        /// Update Project Details
        /// </summary>
        /// <param name="projectDetailsEntity">ProjectDetailsEntity</param>
        /// <returns></returns>
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

        /// <summary>
        /// Delete specific Project
        /// </summary>
        /// <param name="projectId">projectId</param>
        /// <returns></returns>
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