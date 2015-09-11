using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
    public class CurrentDesiredJobBAL
    {
        public int CurrentProfessionalDetailsBAL(CurrentDesiredJobEntity curentity)
        {
            CurrentDesiredJobDAL cdjDAL = new CurrentDesiredJobDAL();
            return cdjDAL.CurrentProfessionalDetailsDAL(curentity);
            
        }
    }
}
