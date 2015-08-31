using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
   public class PersonalDetailsJSBAL
    {
       public DataTable LoadCountryAll()
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.LoadCountryAll();

       }
       public DataTable LoadStateAll(int CountryId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.LoadStateAll(CountryId);
       }
       public DataTable LoadCityAll(int StateId)
       {
           PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
           return pdDAL.LoadCityAll(StateId);
       }
    }
}
