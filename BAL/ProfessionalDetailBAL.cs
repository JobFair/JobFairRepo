using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;

namespace BAL
{
 public   class ProfessionalDetailBAL
    {


        public   int InsertDetails(ProfessionalDetailsEntity professionaldetailentity)
        {
            ProfessionalDetailsDAL professionaldetailDAL = new ProfessionalDetailsDAL();
            return professionaldetailDAL.InsertDetails(professionaldetailentity);
           
        }

       
        public System.Data.DataSet GetTechnicalSkillsDetailsBAL()
        {
            ProfessionalDetailsDAL professionaldetailDAL = new ProfessionalDetailsDAL();
            return professionaldetailDAL.GetTechnicalSillsDetailsBAL();
        }

        public System.Data.DataSet ViewTechnicalSkillDetailsBAL(string RecruiterID)
        {
            ProfessionalDetailsDAL professionaldetailDAL = new ProfessionalDetailsDAL();
            return professionaldetailDAL.ViewTechnicalskillBAL(RecruiterID);
                 
        }
    }




}
