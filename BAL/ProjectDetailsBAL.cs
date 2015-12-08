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
        /// <returns>dataset</returns>
        public DataSet GetRole()
        {
            ProjectDetailsDAL pdDAL = new ProjectDetailsDAL();
            return pdDAL.GetRole();
        }

        /// <summary>
        /// Project Details of job seeker
        /// </summary>
        /// <param name="dtProjectDetails">dtProjectDetails</param>
        /// <returns>datatable</returns>
        public DataTable SaveProjectDetailsBAL(DataTable dtProjectDetails)
        {
            ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
            return projectDetailsDAL.SaveProjectDetailsDAL(dtProjectDetails);
        }

        /// <summary>
        /// View projectDetails of Job Seeker
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProjectDetailsBAL(string candidateId)
        {
            ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
            return projectDetailsDAL.ViewProjectDetailsDAL(candidateId);
        }

        /// <summary>
        /// Update Project Details
        /// </summary>
        /// <param name="projectDetailsEntity">ProjectDetailsEntity</param>
        /// <returns>system.Int32</returns>
        public int UpdateProjectDetailsBAL(ProjectDetailsEntity projectDetailsEntity)
        {
            ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
            return projectDetailsDAL.UpdateProjectDetailsDAL(projectDetailsEntity);
        }

        /// <summary>
        /// Delete specific Project
        /// </summary>
        /// <param name="projectId">projectId</param>
        /// <returns>dataset</returns>
        public DataSet DeleteProjectDetailsBAL(int projectId)
        {
            ProjectDetailsDAL projectDetailsDAL = new ProjectDetailsDAL();
            return projectDetailsDAL.DeleteProjectDetailsDAL(projectId);
        }
    }
}