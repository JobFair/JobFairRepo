using CommonUtil;
using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class PostNewJobBAL
    {
        /// <summary>
        /// jobpost
        /// </summary>
        /// <param name="jobpostEntity"></param>
        /// <returns>System.Int32</returns>
        public int JobPostBAL(AddJobPostEntity jobpostEntity)
        {
            PostNewJobDAL JPDAL = new PostNewJobDAL();
            return JPDAL.JobPostDAL(jobpostEntity);
        }

        /// <summary>
        /// functional area
        /// </summary>
        /// <returns>System.Int32 </returns>
        public static object FunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        /// <summary>
        /// department details bal
        /// </summary>
        /// <returns> System.Int32</returns>
        public static System.Data.DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        /// <summary>
        /// industry details
        /// </summary>
        /// <returns>System.Int32</returns>
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

        public DataSet GetState()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetStateDAL();
        }

        public static DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }

        public static DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }

        public DataTable GetRolesBAL(string prefixText)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRoles(prefixText);
        }

        public DataTable GettechnicalskillBAL(string prefixText)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetSkill(prefixText);
        }

        public DataSet GetClientName()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetClientname();
        }
        public DataSet GetRequirementBAL()
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRecruiterNameDAL();
        }
        public DataSet GetRequirementDetailBAL(int requirementId)
        {
            PostNewJobDAL newjobpostDAL = new PostNewJobDAL();
            return newjobpostDAL.GetRequirementDetailDAL(requirementId);
        }
    }
}