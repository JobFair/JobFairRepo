using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entities.JobSeeker;

namespace BAL
{
   public class LiveProjectDetailsBAL
    {
        public DataTable GetRole()
        {
            LiveProjectDetailsDAL liveDAL = new LiveProjectDetailsDAL();
            return liveDAL.GetRole();
        }
        public int LiveProjectBAL(LiveProjectDetailsEntity liveEntity)
        {
            LiveProjectDetailsDAL liveDAL = new LiveProjectDetailsDAL();
            return liveDAL.LiveProjectDAL(liveEntity);
        }
    }
}
