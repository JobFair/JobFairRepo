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
        ///   Load Country bal.
       /// </summary>
       /// <returns></returns>
       public DataSet LoadCountryAll()
       {
          return Utility.GetCountry();
           
           //PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           //return pdDAL.LoadCountryAll();
       }
       /// <summary>
       /// Load State bal
       /// </summary>
       /// <param name="CountryId"></param>
       /// <returns></returns>
       public DataTable LoadStateAll(int CountryId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.LoadStateAll(CountryId);
       }
       /// <summary>
       /// Load State bal
       /// </summary>
       /// <param name="StateId"></param>
       /// <returns></returns>
       public DataTable LoadCityAll(int StateId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.LoadCityAll(StateId);
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
