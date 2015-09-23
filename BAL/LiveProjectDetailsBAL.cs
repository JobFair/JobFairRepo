using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class LiveProjectDetailsBAL
    {
        public DataTable GetRole()
        {
            LiveProjectDetailsDAL liveProjectDetailsDAL = new LiveProjectDetailsDAL();
            return liveProjectDetailsDAL.GetRole();
        }

        public int SaveLiveProjectBAL(LiveProjectDetailsEntity liveProjectDetailsEntity)
        {
            LiveProjectDetailsDAL liveProjectDAL = new LiveProjectDetailsDAL();
            return liveProjectDAL.SaveLiveProjectDAL(liveProjectDetailsEntity);
        }
    }
}