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
        ClientDetailsDAL clientDetailsDAL = new ClientDetailsDAL();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetState(int countryId)
        {
            return Utility.GetState(countryId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Data.DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        

      /// <summary>
      /// 
      /// </summary>
      /// <param name="clientDetailsEntity"></param>
      /// <returns></returns>
        public int SaveClientDetailsBAL(Entities.Recruiter.ClientDetailsEntity clientDetailsEntity)
        {
            
            return clientDetailsDAL.SaveClientDetailsDAL(clientDetailsEntity);
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientDetailsEntity"></param>
        public void AddFunctionalAreaBAL(Entities.Recruiter.ClientDetailsEntity clientDetailsEntity)
        {
            clientDetailsDAL.AddFunctionalDal(clientDetailsEntity);
        }
    }
}
