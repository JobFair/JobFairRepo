using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;
using System.Data;

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
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();
            return professionalDetailDAL.ViewTechnicalskillBAL(RecruiterID);
                 
        }

        public void AddTechnicalSkillBAL(ProfessionalDetailsEntity professionalDetailentity)
        {
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();
             professionalDetailDAL.AddTechnicalSkillDAL(professionalDetailentity);
        }

        public  DataTable SaveTechnicalSkillsBAL(DataTable dt)
        {
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();
             return  professionalDetailDAL.SaveTechnicalSkillDAL(dt);
        }

        public DataSet GetRoleSkillsBAL()
        {
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();

            return professionalDetailDAL.GetRoleSkillsDAL();
        }

        public  DataTable SaveRechnicalSkillsBAL(DataTable dt)
        {
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();
            return professionalDetailDAL.SaveRoleSkillsDAL(dt);
        }

        public void AddRoleSkills(ProfessionalDetailsEntity professionalDetailentity)
        {
            ProfessionalDetailsDAL professionalDetailDAL = new ProfessionalDetailsDAL();
           professionalDetailDAL.AddRoleSkills(professionalDetailentity);
        }
    }




}
