using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BAL
{
  public class ContactDetailsJSBAL
    {
        /// <summary>
        /// Contact Details of job seeker
        /// </summary>
        /// <param name="cdEntity">ContactDetailsJobSeekerEntity</param>
        /// <returns>System.Int32</returns>
        public int ContactDetailsBAL(ContactDetailsEntity cdEntity)
        {
           ContactDetailsJSDAL cdDAL=new ContactDetailsJSDAL();
           return cdDAL.ContactDetailsDAL(cdEntity); 
        }
    }
}
