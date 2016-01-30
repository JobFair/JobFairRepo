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
    /// <summary>
    /// ClientContactPersonDetailsBAL class
    /// </summary>
    public class ClientContactPersonDetailsBAL
    {
        /// <summary>
        /// Save client contact person details method in ClientContactPersonDetailsBAL class
        /// </summary>
        /// <param name="clientcontactpersondetailsEntity">Object of ClientContactPersonDetailsBAL</param>
        /// <returns>System.Int32.</returns>
        public DataTable SaveClientContactPersonDetailsBAL(DataTable clientContactPersonDetailsEntity)
        {
            ClientContactPersonDetailsDAL clientContactPersonDetailsDAL = new ClientContactPersonDetailsDAL();
            return clientContactPersonDetailsDAL.SaveClientContactPersonDetailsDAL(clientContactPersonDetailsEntity);
        }
        /// <summary>
        /// Save client contact person details method in ClientContactPersonDetailsBAL class
        /// </summary>
        /// <param name="clientcontactpersondetailsEntity">Object of ClientContactPersonDetailsBAL</param>
        /// <returns>System.Int32.</returns>
        public DataSet ViewClientContactPersonDetailsBAL(long clientId, long hrId)
        {
            ClientContactPersonDetailsDAL clientContactPersonDetailsDAL = new ClientContactPersonDetailsDAL();
            return clientContactPersonDetailsDAL.ViewClientContactPersonDetailsDAL(clientId, hrId);
        }

        /// <summary>
        /// Update client contact person details method in ClientContactPersonDetailsBAL class
        /// </summary>
        /// <param name="clientcontactpersondetailsEntity">Object of ClientContactPersonDetailsBAL</param>
        /// <returns>System.Int32</returns>
        public int UpdateClientContactPersonDetailsBAL(ClientContactPersonDetailsEntity clientContactPersonDetailsEntity)
        {
            ClientContactPersonDetailsDAL clientContactPersonDetailsDAL = new ClientContactPersonDetailsDAL();
            return clientContactPersonDetailsDAL.UpdateClientContactPersonDetailsDAL(clientContactPersonDetailsEntity);
        }
    }
}
