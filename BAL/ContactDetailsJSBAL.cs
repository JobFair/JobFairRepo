using DAL;
using Entities;
using System.Data;

namespace BAL
{
    public class ContactDetailsJSBAL
    {
        /// <summary>
        /// Contact Details of job seeker
        /// </summary>
        /// <param name="contactDetailsEntity">ContactDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveContactDetailsBAL(ContactDetailsEntity contactDetailsEntity)
        {
            ContactDetailsJSDAL contactDetailsDAL = new ContactDetailsJSDAL();
            return contactDetailsDAL.SaveContactDetailsDAL(contactDetailsEntity);
        }

        /// <summary>
        /// Update ContactDetails of job seeker
        /// </summary>
        /// <param name="contactDetailsEntity">ContactDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int UpdateContactDetailsBAL(ContactDetailsEntity contactDetailsEntity)
        {
            ContactDetailsJSDAL contactDetailsDAL = new ContactDetailsJSDAL();
            return contactDetailsDAL.UpdateContactDetailsDAL(contactDetailsEntity);
        }

        /// <summary>
        /// View ContactDetails of job seeker.
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>DataSet</returns>
        public DataSet ViewContactDetailsBAL(string candidateId,int userType)
        {
            ContactDetailsJSDAL contactDetailsDAL = new ContactDetailsJSDAL();
            return contactDetailsDAL.ViewContactDetailsDAL(candidateId,userType);
        }
    }
}