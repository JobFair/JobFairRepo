using DAL;
using Entities;

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
            try
            {
                ContactDetailsJSDAL contactDetailsDAL = new ContactDetailsJSDAL();
                return contactDetailsDAL.SaveContactDetailsDAL(contactDetailsEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}