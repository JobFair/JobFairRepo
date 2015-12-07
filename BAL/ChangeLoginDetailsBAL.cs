using DAL;
using Entities.JobSeeker;

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
            ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
            return changeLoginDetailsDAL.GetLoginDetailsDAL(candidateId);
        }

        /// <summary>
        /// Method in ChangeLoginDetailsBAL class for changing Primary Mail ID
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMailIdBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
            changeLoginDetailsDAL.ChangePrimaryMailIdDAL(changeLoginDetailsEntity);
        }

        /// <summary>
        ///  Method in ChangeLoginDetailsBAL class for changing Primary Mobile Number
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        public void ChangePrimaryMobileNoBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
            changeLoginDetailsDAL.ChangePrimaryMobileNoDAL(changeLoginDetailsEntity);
        }

        /// <summary>
        /// Method to ChangeLoginDetailsBAL class for Adding new mail id
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMailIdBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
            return changeLoginDetailsDAL.NewMailIdDAL(changeLoginDetailsEntity);
        }

        /// <summary>
        /// Method to ChangeLoginDetailsBAL class for Adding new mobile number
        /// </summary>
        /// <param name="changeLoginDetailsEntity">Entity of of change login details</param>
        /// <returns>System.Int32</returns>
        public int NewMoblieNoBAL(ChangeLoginDetailsEntity changeLoginDetailsEntity)
        {
            ChangeLoginDetailsDAL changeLoginDetailsDAL = new ChangeLoginDetailsDAL();
            return changeLoginDetailsDAL.NewMoblieNoDAL(changeLoginDetailsEntity);
        }
    }
}