using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class ViewApplicationsBAL
    {


        public System.Data.DataSet GetCandidateDetails(string candidateId)
        {
            ViewApplicationsDAL viewapplicationsDAL = new ViewApplicationsDAL();
            return viewapplicationsDAL.GetCandidateDetails(candidateId);
        }
    }
}


