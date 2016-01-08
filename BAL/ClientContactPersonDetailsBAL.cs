using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;

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
    }
}
