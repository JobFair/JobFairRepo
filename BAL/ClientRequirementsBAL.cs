using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using CommonUtil;
using System.Data;

namespace BAL
{
    public class ClientRequirementsBAL
    {
        /// <summary>
        /// Saving Client Requirements Recruiter.
        /// </summary>
        /// <param name="edEntity">The Client Requirements entity.</param>
        /// <returns>System.Int32.</returns>
        public int SaveClientRequirementssBAL(Entities.Recruiter.ClientRequirementsEntitiy clientRequirementsEntity)
        {
            ClientRequirementsDAL clientRequirementsDAL = new ClientRequirementsDAL();
            return clientRequirementsDAL.SaveClientRequirementsDAL(clientRequirementsEntity);

        }
        /// <summary>
        /// Load Client Name
        /// </summary>
        /// <returns></returns>
        public DataSet GetClientNameDAL()
        {
            return Utility.GetClientName();
        }
    }
}
