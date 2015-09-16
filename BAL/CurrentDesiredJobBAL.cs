using DAL;
using Entities.JobSeeker;

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
    }
}