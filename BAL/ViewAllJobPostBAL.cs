using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
   public class ViewAllJobPostBAL
    {
       public DataSet ViewCandidateProfileForEmail(string candidateId)
       {
           ViewAllJobPostDAL viewAllJobPostDAL = new ViewAllJobPostDAL();
           return viewAllJobPostDAL.ViewCandidateProfileForEmail(candidateId);
       }
    }
}
