
using CommonUtil;
using DAL;
using Entities.Recruiter;

namespace BAL
{
   public class AddJobPostBAL
   {
       public int JobPostBAL(AddJobPostEntity JPentity)
       {
           AddJobPostDAL JPDAL = new AddJobPostDAL();
           return JPDAL.JobPostDAL(JPentity);
       }

    
       /// <summary>
       /// Method to get State
       /// </summary>
       /// <param name="CountryId">Parameter of Country table to get State accordingly</param>
       /// <returns>System.Data.DataSet</returns>
   
      
       //public int JPBAL(AddJobPostEntity JobPostentity)
       //{
       //    UpdateJobPostDAL jpDAL = new UpdateJobPostDAL();
       //    return jpDAL.UpdateRecord(JobPostentity);
       //}




       
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

