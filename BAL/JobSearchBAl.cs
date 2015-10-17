using CommonUtil;
using DAL;
using Entities.JobSeeker;
using System.Data;


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


        public static System.Data.DataSet GetRoles()
        {
            return Utility.GetRoles();
        }

        public static System.Data.DataSet GetLocation()
        {
            return Utility.GetLocation();
        }

        public static System.Data.DataSet GetEducationalDegreeType()
        {
            return Utility.GetEducationalDegreeTypeDAL();
        }
        public DataSet JobSearch(string keySkills, string city, string experience)
        {
            JobSearchDAL jobSearchDAL = new JobSearchDAL();
            return  jobSearchDAL.JobSearch(keySkills,city,experience);
        }
    }
}
