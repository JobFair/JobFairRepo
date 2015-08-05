using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace BAL
{
    public class CandidateBAL
    {
        string username = string.Empty;
        string password = string.Empty;
        string constr= ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
        
        
        public CandidateBAL()
        {

        }

        public DataSet GetCandidateDataById(string candidateId)
        {
            DataSet dt = new DataSet();
            CandidateDAL candidate = new CandidateDAL();
            dt = candidate.GetCandidateDataById(candidateId);
            return dt;
        }
       ///
        public DataSet GetPasswordRecruiter(string mail)
        {
            return null;
 
        }
    }
}
