using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class RegisterRecruiterBAL
    {

        public string NewRecruiterBAL(Entities.Recruiter.RegisterRecruiterEntity rrentity)
        {
            RegisterRecruiterDAL rrDAL = new RegisterRecruiterDAL();
            return rrDAL.NewRecruiterDAL(rrentity);
           
        }
    }
}
