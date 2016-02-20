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
        /// <summary>
        ///   Create method for  get  reject  appliaction
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetRejectApplication(int candidateId)
        {
            RejectApplicationDAL rejectapplicationDAL = new RejectApplicationDAL();
            return rejectapplicationDAL.GetRejectAplication(candidateId);
           
        }
    }
}
