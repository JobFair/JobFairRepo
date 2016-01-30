using CommonUtil;
using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class PostNewJobBAL
    {
        /// <summary>
        /// Insert job post bal
        /// </summary>
        /// <param name="jobpostEntity">AddJobPostEntity</param>
        /// <returns>System.Int32</returns>
        public int JobPostBAL(AddJobPostEntity jobpostEntity)
        {
            PostNewJobDAL JPDAL = new PostNewJobDAL();
            return JPDAL.JobPostDAL(jobpostEntity);
        }

        /// <summary>
        /// Functional area bal
        /// </summary>
        /// <returns>System.Int32 </returns>
        public static object FunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        /// <summary>
        /// Get department bal
        /// </summary>
        /// <returns>dataset</returns>
        public static DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        /// <summary>
        /// Get industry bal
        /// </summary>
        /// <returns>dataset</returns>
        public static System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        /// <summary>
        /// BAL for GetQuestions
        /// </summary>
        /// <returns></returns>
        public DataSet GetQuestionsBAL()
        {
            PostNewJobDAL newJobPostDAL = new PostNewJobDAL();
            return newJobPostDAL.GetQuestionsDAL();
        }

        /// <summary>
        /// Get state bal
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetState()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetStateDAL();
        }

        /// <summary>
        /// Get area bal
        /// </summary>
        /// <param name="cityId">cityId</param>
        /// <returns>Dataset</returns>
        public static DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }

        /// <summary>
        /// Get city bal
        /// </summary>
        /// <param name="stateId">stateId</param>
        /// <returns>Dataset</returns>
        public static DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }

        /// <summary>
        /// Get roles bal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>Datatable</returns>
        public DataTable GetRolesBAL(string prefixText)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRoles(prefixText);
        }

        /// <summary>
        /// Get technical skills bal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>Datatable</returns>
        public DataTable GetTechnicalskillBAL(string prefixText)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetTechnicalSkill(prefixText);
        }

        /// <summary>
        /// Get client name bal
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetClientName()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetClientname();
        }

        /// <summary>
        /// Get requirements bal
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet GetRequirementBAL()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRecruiterNameDAL();
        }

        /// <summary>
        /// Get requirement details bal
        /// </summary>
        /// <param name="requirementId">requirementId</param>
        /// <returns>Dataset</returns>
        public DataSet GetRequirementDetailBAL(int requirementId)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRequirementDetailDAL(requirementId);
        }

        public void AddRoleSkillsDetailsBAL(AddJobPostEntity jobpostEntity)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            newjobpostDAL.AddRoleSkillsDetailsDAL(jobpostEntity);
        }
    }
}