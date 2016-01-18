using DAL;
using System.Data;

namespace BAL
{
    public class ViewClientRequirementDetailsREBAL
    {
        public DataSet ViewClientRequirementBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewClientRequirementDAL(recruiterId);
        }

        public DataSet ViewClientRequirementDetailsBAL(long clientId, long clientRequirementId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewClientRequirementDetailsDAL(clientId, clientRequirementId);
        }

        public DataSet ViewActiveRequirementBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewActiveRequirementDAL(recruiterId);
        }

        public DataSet ViewActiveRequirementSearchBAL(long recruiterId, string clientName, string position)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewActiveRequirementSearchDAL(recruiterId, clientName, position);
        }

        public DataSet ViewInActiveRequirementsBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewInActiveRequirementsDAL(recruiterId);
        }

        public DataSet ViewInActiveRequirementSearchBAL(long recruiterId, string clientName, string position)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewInActiveRequiremntSearchDAL(recruiterId, clientName, position);
        }

        public int UpdateRequirementStatus(long clientRequirementId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.UpdateRequirementStatusDAL(clientRequirementId);
        }
    }
}