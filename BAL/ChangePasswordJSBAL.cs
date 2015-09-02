using DAL;
using Entities;
using System.Data.SqlClient;

namespace BAL
{
    public class ChangePasswordJSBAL
    {

        /// <summary>
        /// Changes the password bal.
        /// </summary>
        /// <param name="changePasswordEntity">The change password entity.</param>
        /// <returns>System.Int32.</returns>
        /// Jyoti
        public int ChangePasswordBAL(ChangePasswordEnitity changePasswordEntity)
        {
            ChangePasswordJSDAL jobSeekerDAL = new ChangePasswordJSDAL();
            return jobSeekerDAL.ChangePasswordDAL(changePasswordEntity);
        }
    }
}
