using CommonUtil;
using DAL;
using Entities.JobSeeker;


namespace BAL
{
  public  class JobSearchBAL
    {
        public static System.Data.DataSet GetIndustry()
       
        {
            return Utility.GetIndustry();
        }


        public static System.Data.DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        public static System.Data.DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }
    }
}
