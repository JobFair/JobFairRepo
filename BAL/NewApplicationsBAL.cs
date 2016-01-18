using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.JobSeeker;

namespace BAL
{
    public class NewApplicationsBAL
    {
        public System.Data.DataSet GetClientDetails(  long candidateId)
        {
            NewApplicationsDAL  newapplicationsDAL =  new NewApplicationsDAL();
            return newapplicationsDAL.GetCandidateDetails(candidateId);
        }
    }
}
