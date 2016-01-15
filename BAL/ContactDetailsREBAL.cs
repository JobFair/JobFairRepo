using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class ContactDetailsREBAL
    {
        /// <summary>
        /// Contact Details of recruiter
        /// </summary>
        /// <param name="contactDetailsEntity">ContactDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveContactDetailsBAL(ContactDetailsEntity contactDetailsEntity)
        {
            ContactDetailsREDAL contactDetailsDAL = new ContactDetailsREDAL();
            return contactDetailsDAL.SaveContactDetailsDAL(contactDetailsEntity);
        }

        /// <summary>
        /// View ContactDetails of recruiter.
        /// </summary>
        /// <param name="recruiterId">recruiterId</param>
        /// <returns>DataSet</returns>
        public DataSet ViewContactDetailsBAL(long recruiterId)
        {
            ContactDetailsREDAL contactDetailsDAL = new ContactDetailsREDAL();
            return contactDetailsDAL.ViewContactDetailsDAL(recruiterId);
        }

        /// <summary>
        /// Update contact details of recruiter.
        /// </summary>
        /// <param name="contactDetailsEntity">contactDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int UpdateContactDetailsBAL(ContactDetailsEntity contactDetailsEntity)
        {
            ContactDetailsREDAL contactDetailsDAL = new ContactDetailsREDAL();
            return contactDetailsDAL.UpdateContactDetailsDAL(contactDetailsEntity);
        }
    }
}