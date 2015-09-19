using DAL;
using Entities.JobSeeker;
using CommonUtil;

namespace BAL
{
    public class CurrentDesiredJobBAL
    {
       
        public int CurrentProfessionalDetailsBAL(CurrentDesiredJobEntity curentity)
        {
            CurrentDesiredJobDAL cdjDAL = new CurrentDesiredJobDAL();
            return cdjDAL.SaveCurrentProfessionalDetailsDAL(curentity);
        }

        public int DesiredJobDetailsBAL(CurrentDesiredJobEntity cdjEntity)
        {
            CurrentDesiredJobDAL cdjDAL = new CurrentDesiredJobDAL();
            return cdjDAL.DesiredJobDetailsDAL(cdjEntity);
        }

        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
            
        }

        public System.Data.DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        public System.Data.DataSet GetIndustry()
        {

            return Utility.GetIndustry();
            }

        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
    }
}