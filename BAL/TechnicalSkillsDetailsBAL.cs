using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class TechnicalSkillsDetailsBAL
    {
       TechnicalSkillsDetailsDAL technicalSkillsDAL = new TechnicalSkillsDetailsDAL();
       public DataSet TechnicalSkillsBAL()
       {
          return technicalSkillsDAL.TechnicalSkillDAL();
       }
    }
}
