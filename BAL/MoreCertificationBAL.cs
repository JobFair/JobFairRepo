using DAL;
using System.Data;

namespace BAL
{
    public class MoreCertificationBAL
    {
        /// <summary>
        /// Saving MoreCertification Deatils JobSeeker.
        /// </summary>
        /// <param name="certificationEntity">The Certification Entity.</param>
        /// <returns>System.Int32.</returns>
        public DataTable SaveMoreCertificationBAL(DataTable certificationEntity)
        {
            MoreCertificationDAL certDAL = new MoreCertificationDAL();
            return certDAL.SaveMoreCertificationDAL(certificationEntity);
        }
    }
}