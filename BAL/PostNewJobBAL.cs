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
            NewJobPostDAL JPDAL = new NewJobPostDAL();
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
        /// UnderGraduateDiploma BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetUnderGraduateDiplomaBAL(int DegreeId)
        {
            return Utility.GetDegreeDetails(DegreeId);
        }

        /// <summary>
        /// GetBachelorDegree BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetBachelorDegreeBAL(int DegreeId)
        {
            return Utility.GetDegreeDetails(DegreeId);
        }

        /// <summary>
        /// GetPostGraduateDiploma BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetPostGraduateDiplomaBAL(int DegreeId)
        {
            return Utility.GetDegreeDetails(DegreeId);
        }

        /// <summary>
        /// GetMasterDegree BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetMasterDegreeBAL(int DegreeId)
        {
            return Utility.GetDegreeDetails(DegreeId);
        }

        /// <summary>
        /// GetDoctorOfPhilosophy BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetDoctorOfPhilosophyBAL(int DegreeId)
        {
            return Utility.GetDegreeDetails(DegreeId);
        }

        /// <summary>
        /// BAL for GetQuestions
        /// </summary>
        /// <returns></returns>
        public DataSet GetQuestionsBAL()
        {
            NewJobPostDAL newJobPostDAL = new NewJobPostDAL();
            return newJobPostDAL.GetQuestionsDAL();
        }

        public DataSet GetState()
        {
            NewJobPostDAL newjobpostDAL = new NewJobPostDAL();
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
            NewJobPostDAL newjobpostDAL = new NewJobPostDAL();
            return newjobpostDAL.GetRoles(prefixText);
        }

       

       

        public DataTable GettechnicalskillBAL(string prefixText)
        {
            NewJobPostDAL newjobpostDAL = new NewJobPostDAL();
            return newjobpostDAL.GetSkill(prefixText);
        }

        public DataSet GetClientName()
        {
            NewJobPostDAL newjobpostDAL = new NewJobPostDAL();
            return newjobpostDAL.GetClientname();
        }
    }
}