using CommonUtil;
using DAL;
using Entities.Recruiter;

namespace BAL
{
    public class NewJobPostBAL
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
        public static System.Data.DataSet GetUnderGraduateDiplomaBAL()
        {
            return Utility.GetUnderGraduateDiplomaDAL();
        }

        /// <summary>
        /// GetBachelorDegree BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetBachelorDegreeBAL()
        {
            return Utility.GetBachelorDegreeDAL();
        }

        /// <summary>
        /// GetPostGraduateDiploma BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetPostGraduateDiplomaBAL()
        {
            return Utility.GetPostGraduateDiplomaDAL();
        }

        /// <summary>
        /// GetMasterDegree BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetMasterDegreeBAL()
        {
            return Utility.GetMasterDegreeDAL();
        }

        /// <summary>
        /// GetDoctorOfPhilosophy BAL
        /// </summary>
        /// <returns>System.Int32</returns>
        public static System.Data.DataSet GetDoctorOfPhilosophyBAL()
        {
            return Utility.GetDoctorOfPhilosophyDAL();
        }
    }
}