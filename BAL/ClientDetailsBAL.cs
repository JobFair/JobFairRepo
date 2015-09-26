using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using CommonUtil;

namespace BAL
{
    public class ClientDetailsBAL
    {

        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }

        public System.Data.DataSet GetState(int countryId)
        {
            return Utility.GetState(countryId);
        }

        public System.Data.DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }

        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        public System.Data.DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        

      
        public int SaveClientDetailsBAL(Entities.Recruiter.ClientDetailsEntity clientDetailsEntity)
        {
            ClientDetailsDAL clientDetailsDAL = new ClientDetailsDAL();
            return clientDetailsDAL.SaveClientDetailsDAL(clientDetailsEntity);
            
        }
    }
}
