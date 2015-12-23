using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;


namespace BAL
{
    // <summary>
    /// ClientRequirementsHRBAL class
    /// </summary>
    public class ClientRequirementsHRBAL
    {
        //private ClientRequirementsHRDAL ClientRequirementsHRDAL = new ClientRequirementsHRDAL();

        /// <summary>
        /// Method to get country
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="countryId">Parameter to get state</param>
        /// <returns></returns>
        public System.Data.DataSet GetState(int countryId)
        {
            return Utility.GetState(countryId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="stateId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <param name="areaId">Parameter for selection of city</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        /// <summary>
        /// Method in ClientDetailsBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }
        /// <summary>
        /// Load Client Name
        /// </summary>
        /// <returns></returns>
        public DataSet GetClientNameDAL()
        {
            return Utility.GetClientName();
        }
    }
}
