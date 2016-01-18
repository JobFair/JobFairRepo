using CommonUtil;
using DAL;
using System.Data;

namespace BAL
{
    /// <summary>
    /// ClientDetailsBAL class
    /// </summary>
    public class ClientDetailsBAL
    {
        private ClientDetailsDAL clientDetailsDAL = new ClientDetailsDAL();

        /// <summary>
        /// Method to get country
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="countryId">Parameter to get state</param>
        /// <returns></returns>
        public System.Data.DataSet GetState(int countryId)
        {
            return Utility.GetState(countryId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="stateId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="areaId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        /// <summary>
        /// Save client details method in ClientDetailsBAL class
        /// </summary>
        /// <param name="clientDetailsEntity">Object of ClientDetailsBAL</param>
        /// <returns>System.Int32</returns>
        public int SaveClientDetailsBAL(Entities.HR.ClientDetailsEntity clientDetailsEntity)
        {
            return clientDetailsDAL.SaveClientDetailsDAL(clientDetailsEntity);
        }

        /// <summary>
        /// To add functional area method in ClientDetailsBAL class
        /// </summary>
        /// <param name="clientDetailsEntity">Object of ClientDetailsEntity </param>
        public void AddFunctionalAreaBAL(Entities.HR.ClientDetailsEntity clientDetailsEntity)
        {
            clientDetailsDAL.AddFunctionalDAL(clientDetailsEntity);
        }

        public DataSet ViewClientDetailsBAL(long clientId, long hrId)
        {
            ClientDetailsDAL ViewclientDetailsDAL = new ClientDetailsDAL();
            return clientDetailsDAL.ViewClientDetailsDAL(clientId, hrId);
        }
    }
}