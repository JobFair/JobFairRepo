using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BAL
{
    public class RejectApplicationBAL
    {
        public System.Data.DataSet GetRejectApplication(string candidateId)
        {
            RejectApplicationDAL rejectapplicationDAL = new RejectApplicationDAL();
            return rejectapplicationDAL.GetRejectAplication(candidateId);
           
        }
    }
}
