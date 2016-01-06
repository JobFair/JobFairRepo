using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class RegisterHrADBAL
    {
       

        public static string SaveNewRecruiterBAL(Entities.RegisterEntity registerEntity)
        {
            throw new NotImplementedException();
        }

        public static string SaveNewRecruiterBAL(Entities.Common.RegisterEntity registerEntity)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCountry()
        {
            throw new NotImplementedException();
        }

        public string SaveNewHrBAL(Entities.Common.RegisterEntity registerEntity)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetState(int CountryId)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCity(int StateId)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetArea(int cityId)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCountryCode()
        {
            throw new NotImplementedException();
        }
    }
}
