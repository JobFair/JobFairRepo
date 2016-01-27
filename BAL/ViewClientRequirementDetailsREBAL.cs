using DAL;
using System;
using System.Data;

namespace BAL
{
    public class ViewClientRequirementDetailsREBAL
    {
        /// <summary>
        /// View client requirements bal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewClientRequirementBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewClientRequirementDAL(recruiterId);
        }

        /// <summary>
        /// view client requirement details bal
        /// </summary>
        /// <param name="clientId">clientId</param>
        /// <param name="clientRequirementId">clientRequirementId</param>
        /// <returns>dataset</returns>
        public DataSet ViewClientRequirementDetailsBAL(long clientId, long clientRequirementId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewClientRequirementDetailsDAL(clientId, clientRequirementId);
        }

        /// <summary>
        /// View active requirements bal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewActiveRequirementBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewActiveRequirementDAL(recruiterId);
        }

        /// <summary>
        /// View inactive requirement bal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>dataset</returns>
        public DataSet ViewInActiveRequirementsBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewInActiveRequirementsDAL(recruiterId);
        }

        /// <summary>
        /// Update requirement status bal
        /// </summary>
        /// <param name="clientRequirementId">clientRequirementId</param>
        /// <returns>System.Int32</returns>
        public int UpdateRequirementStatus(long clientRequirementId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.UpdateRequirementStatusDAL(clientRequirementId);
        }

        /// <summary>
        /// View search inactive requirements bal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="clientName">clientName</param>
        /// <param name="position">position</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <returns>dataset</returns>
        public DataSet ViewInActiveRequirementSearchBAL(long recruiterId, string clientName, string position, DateTime? fromDate, DateTime? toDate)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewInActiveRequiremntSearchDAL(recruiterId, clientName, position, fromDate, toDate);
        }

        /// <summary>
        /// View search active requirements bal
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <param name="clientName">clientName</param>
        /// <param name="position">position</param>
        /// <param name="toDate">toDate</param>
        /// <param name="fromDate">fromDate</param>
        /// <returns>dataset</returns>
        public DataSet ViewActiveRequirementSearchBAL(long recruiterId, string clientName, string position, DateTime? toDate, DateTime? fromDate)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewActiveRequirementSearchDAL(recruiterId, clientName, position, fromDate, toDate);
        }
    }
}