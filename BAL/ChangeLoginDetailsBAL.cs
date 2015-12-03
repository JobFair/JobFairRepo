using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
    public class ChangeLoginDetailsBAL
    {
        /// <summary>
        /// Method in ChangeLoginDetailsBAL class to get Login details
        /// </summary>
        /// <param name="candidateId">String Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetLoginDetailsBAL(string candidateId)
        {
            try
            {
                ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
                return changeLoginDetailsDAL.GetLoginDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
        /// <summary>
        /// Method in ChangeLoginDetailsBAL class for changing Primary Mail ID
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMailIdBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
                changeLoginDetailsDAL.ChangePrimaryMailIdDAL(changeLoginDetailsEntity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        ///  Method in ChangeLoginDetailsBAL class for changing Primary Mobile Number
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMobileNoBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
                changeLoginDetailsDAL.ChangePrimaryMobileNoDAL(changeLoginDetailsEntity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Method to ChangeLoginDetailsBAL class for Adding new mail id
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMailIdBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                 ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
               return changeLoginDetailsDAL.NewMailIdDAL(changeLoginDetailsEntity);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Method to ChangeLoginDetailsBAL class for Adding new mobile number
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMoblieNoBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            try
            {
                 ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
               return changeLoginDetailsDAL.NewMoblieNoDAL(changeLoginDetailsEntity);
            }
            
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
