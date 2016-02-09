using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
    public class ForwordResumeBAL
    {
        public   DataSet GetClientName()
        {
            ForwardResumeDAL fowardResumeDAL = new ForwardResumeDAL();
              return fowardResumeDAL.GetClientName();
        }

        public DataSet GetEmailId(int clientid)
        {
            ForwardResumeDAL fowardResumeDAL = new ForwardResumeDAL();
            return fowardResumeDAL.GetEmailId(clientid);
        }
    }
}
