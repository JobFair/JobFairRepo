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
        public DataSet ViewContactDetailsBAL(string candidateId)
        {
            try
            {
                ContactDetailsJSDAL contactDetailsDAL = new ContactDetailsJSDAL();
                return contactDetailsDAL.ViewContactDetailsDAL(candidateId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}