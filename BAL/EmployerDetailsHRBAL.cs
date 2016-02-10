using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;
using Entities.HR;

namespace BAL
{
    /// <summary>
    /// EmployerDetailsHRBAL class
    /// </summary>
    public class EmployerDetailsHRBAL
    {
        /// <summary>
        /// Method to get country
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="countryId">Parameter to get state</param>
        /// <returns></returns>
        public System.Data.DataSet GetState(int countryId)
        {
            return Utility.GetState(countryId);
        }
        /// <summary>
        /// Method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="stateId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }
        /// <summary>
        /// Method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="areaId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
       
        /// <summary>
        /// Save employer details method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="employerDetailsEntity">Object of EmployerDetailsHRBAL</param>
        /// <returns>System.Int32</returns>
        public int SaveEmployerDetailsBAL(EmployerDetailsHREntity employerDetailsHREntity)
        {
            EmployerDetailsHRDAL employerDetailsHRDAL = new EmployerDetailsHRDAL();
            return employerDetailsHRDAL.SaveEmployerDetailsDAL(employerDetailsHREntity);
        }

        /// <summary>
        /// Update employer details method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="employerDetailsEntity">Object of EmployerDetailsHRBAL</param>
        /// <returns>System.Int32</returns>
        public int UpdateEmployerDetailsBAL(EmployerDetailsHREntity employerDetailsHREntity)
        {
            EmployerDetailsHRDAL employerDetailsHRDAL = new EmployerDetailsHRDAL();
            return employerDetailsHRDAL.UpdateEmployerDetailsDAL(employerDetailsHREntity);
        }

        /// <summary>
        /// View employer details method in EmployerDetailsHRBAL class
        /// </summary>
        /// <param name="employerDetailsEntity">Object of EmployerDetailsHRBAL</param>
        /// <returns>System.Int32</returns>
        public DataSet ViewEmployerDetailsBAL(long employerId, long hrId)
        {
            EmployerDetailsHRDAL employerDetailsHRDAL = new EmployerDetailsHRDAL();
            return employerDetailsHRDAL.ViewEmployerDetailsDAL(employerId, hrId);
        }
    }
}
