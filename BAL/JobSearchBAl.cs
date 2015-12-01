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
            try
            {
                return Utility.GetIndustry();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }


        public static System.Data.DataSet GetDepartment()
        {
            try
            {
                return Utility.GetDepartment();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public static System.Data.DataSet GetFunctionalArea()
        {
            try
            {
                return Utility.GetFunctionalArea();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }


        public static System.Data.DataSet GetRoles()
        {
            try
            {
                return Utility.GetRoles();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }

        public static System.Data.DataSet GetLocation()
        {
            try
            {
                return Utility.GetLocation();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }

        public static System.Data.DataSet GetEducationalDegreeType()
        {
            try
            {
                return Utility.GetEducationalDegreeTypeDAL();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        public DataSet JobSearch(string keySkills, string city, string experience, string minSalary, string maxSalary, int functionalArea)
        {
            try
            {
                JobSearchDAL jobSearchDAL = new JobSearchDAL();
                return jobSearchDAL.JobSearch(keySkills, city, experience, minSalary, maxSalary, functionalArea);
            }
            catch (System.Exception)
            {
                throw;
            }
          
        }

        public DataSet GetSearch(AdvanceSearchDetailsEntity advanceSearchEntity)
        {
            try
            {
                AdvanceSearchDAL advancesearchDAL = new AdvanceSearchDAL();
                return advancesearchDAL.Getsearch(advanceSearchEntity);
            
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}
