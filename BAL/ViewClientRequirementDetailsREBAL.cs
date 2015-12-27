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

        public DataSet ViewInActiveRequirementsBAL(long recruiterId)
        {
            ViewClientRequirementDetailsREDAL viewClientRequirement = new ViewClientRequirementDetailsREDAL();
            return viewClientRequirement.ViewInActiveRequirementsDAL(recruiterId);
        }
    }
}