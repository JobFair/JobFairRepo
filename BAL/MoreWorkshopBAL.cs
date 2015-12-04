using DAL;
using System.Data;

namespace BAL
{
    public class MoreWorkshopBAL
    {
        /// <summary>
        /// Saving MoreWorkshop Deatils JobSeeker.
        /// </summary>
        /// <param name="workshopEntity">The Workshop Entity.</param>
        /// <returns>System.Int32.</returns>
        public DataTable SaveMoreCertificationBAL(DataTable workshopEntity)
        {
            MoreWorkshopDAL workDAL = new MoreWorkshopDAL();
            return workDAL.SaveMoreWorkshopDAL(workshopEntity);
        }
    }
}