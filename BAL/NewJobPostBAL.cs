
using CommonUtil;
using DAL;
using Entities.Recruiter;

namespace BAL
{
   public class NewJobPostBAL
   {
       public int JobPostBAL(AddJobPostEntity JPentity)
       {
           NewJobPostDAL JPDAL = new NewJobPostDAL();
           return JPDAL.JobPostDAL(JPentity);
       }

   
       public static object FunctionalArea()
       {
           return Utility.GetFunctionalArea();
       }

       public static System.Data.DataSet GetDepartment()
       {
           return Utility.GetDepartment();
       }

       public static System.Data.DataSet GetIndustry()
       {
           return Utility.GetIndustry();
       }
   }
}

