using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;
using Entities.HR;

namespace BAL
{
    // <summary>
    /// ClientRequirementsHRBAL class
    /// </summary>
    public class ClientRequirementsHRBAL
    {
        private ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();

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
        /// Get ClientName BAL
        /// </summary>
        /// <param name="HrId">HrId</param>
        /// /// <param name="ClientId">ClientId</param>
        /// <returns>dataset</returns>
        public DataSet GetClientNameBAL(long HrId, long ClientId)
        {
            ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();
            return clientRequirementsHRDAL.GetClientNameDAL(HrId, ClientId);
        }
        /// <summary>
        /// Get Recruiter BAL
        /// </summary>
        /// <param name="HrId">HrId</param>
        /// <returns>dataset</returns>
        public DataSet GetRecruiterBAL(int HrId)
        {
            ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();
            return clientRequirementsHRDAL.GetRecruiterDAL(HrId);
        }
        /// <summary>
        /// Save client requirements details method in ClientRequirementsHRBAL class
        /// </summary>
        /// <param name="clientRequirementsHREntity">Object of ClientRequirementsHREntity</param>
        /// <returns>System.Int32</returns>
        public int SaveClientRequirementsBAL(Entities.HR.ClientRequirementsHREntity clientRequirementsHREntity)
        {
            return clientRequirementsHRDAL.SaveClientRequirementsDAL(clientRequirementsHREntity);
        }
        /// <summary>
        /// Get ViewClientRequirementDetailsBAL
        /// </summary>
        /// <param name="HrId">HrId</param>
        /// <param name="ClientId">ClientId</param>
        /// <returns>dataset</returns>
        public DataSet ViewClientRequirementDetailsBAL(long HrId,long ClientId)
        {
            ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();
            return clientRequirementsHRDAL.ViewClientRequirementDetailsDAL(HrId, ClientId);
        }
        /// <summary>
        /// Update Client Requirement Details
        /// </summary>
        /// <param name="clientRequirementsHREntity">ClientRequirementsHREntity</param>
        /// <returns>system.Int32</returns>
        public int UpdateClientRequirementsBAL(ClientRequirementsHREntity clientRequirementsHREntity)
        {
            ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();
            return clientRequirementsHRDAL.UpdateClientRequirementsDAL(clientRequirementsHREntity);
        }
        /// <summary>
        /// Get ViewClientRequirementDetailsBAL
        /// </summary>
        /// <param name="HrId">HrId</param>
        /// <param name="ClientId">ClientId</param>
        /// <returns>dataset</returns>
        public DataSet SelectClientRequirementsForwardMailBAL(long HrId, long ClientId)
        {
            ClientRequirementsHRDAL clientRequirementsHRDAL = new ClientRequirementsHRDAL();
            return clientRequirementsHRDAL.SelectClientRequirementsForwardMailDAL(HrId, ClientId);
        }
    }
}
