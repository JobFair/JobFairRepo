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
        /// <summary>
        ///  Create method for get  accept candidate
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetAcceptCandidate(int candidateId)
        {
            AcceptApplicationsDAL acceptapplicationDAL = new AcceptApplicationsDAL();
            return acceptapplicationDAL.GetAcceptCandidate(candidateId);
        }
    }
}
