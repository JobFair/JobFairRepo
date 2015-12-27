using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using CommonUtil;

namespace BAL
{
    public class RegisterHrADBAL
    {   
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry(); 
        }

        public string SaveNewHrBAL(Entities.Common.RegisterEntity registerEntity)
        {
            RegisterHrADDAL registerHrADDAL = new RegisterHrADDAL();
            return registerHrADDAL.SaveNewHrDAL(registerEntity);
        }

        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }

        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }

        public System.Data.DataSet GetCountryCode()
        {
            return Utility.GetCountryCode();
        }
    }
}
