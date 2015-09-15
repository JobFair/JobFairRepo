using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entities;
using CommonUtil;

namespace BAL
{
   public class PersonalDetailsJSBAL
    {
        /// <summary>
        ///   Get Country bal.
       /// </summary>
       /// <returns></returns>
       public DataSet GetCountry()
       {
          return Utility.GetCountry();
           //PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           //return pdDAL.LoadCountryAll();
       }
       /// <summary>
       /// Get State bal
       /// </summary>
       /// <param name="CountryId"></param>
       /// <returns></returns>
       public DataTable GetState(int CountryId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.GetState(CountryId);
       }
       /// <summary>
       /// Get State bal
       /// </summary>
       /// <param name="StateId"></param>
       /// <returns></returns>
       public DataTable GetCity(int StateId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.GetCity(StateId);
       }

       /// <summary>
       ///  Personal Details of job seeker bal.
       /// </summary>
       /// <param name="pdEntity">The Personal Details entity.</param>
       /// <returns>System.Int32</returns>
       public int PersonalDetailsBAL(PersonalDetailsJSEntity pdEntity)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.PersonalDetailsInsert(pdEntity);
       }
    }
}
