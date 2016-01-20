using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class AcceptApplicationsBAL
    {
        public System.Data.DataSet GetAcceptCandidate(string candidateId)
        {
            AcceptApplicationsDAL acceptapplicationDAL = new AcceptApplicationsDAL();
            return acceptapplicationDAL.GetAcceptCandidate(candidateId);
        }
    }
}
