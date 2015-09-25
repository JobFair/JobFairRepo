
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
   }
}

