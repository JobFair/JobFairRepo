using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
    public class ChangeLoginDetailsBAL
    {

        public System.Data.DataSet GetLoginDetailsBAL(string candidateId)
        {
            try
            {
                ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
                return changeLoginDetailsDAL.GetLoginDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }
}
