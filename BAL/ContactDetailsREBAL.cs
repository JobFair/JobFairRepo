using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;

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
            ContactDetailsREDAL contactDetailsREDAL = new ContactDetailsREDAL();
            return contactDetailsREDAL.SaveContactDetailsDAL(contactDetailsEntity);
        }
    }
}
