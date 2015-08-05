using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CandidateDAL
    {
        public CandidateDAL()
        {

        }

       /// <summary>
       /// Method to get candidate data using id.
       /// </summary>
       /// <param name="candidateId">candidate ID</param>
       /// <returns>Dataset of candidate data</returns>
        public DataSet GetCandidateDataById(string candidateId)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                throw;
            }

            DataSet data = new DataSet();
            

            return data;

        }

        public bool InsertCandidateData(object candidate)
        {
            return true;
        }
        public DataSet GetPwdRecruiter(string mailid)
        { 
            DataSet data=new DataSet();
            return data;
        }
    }
}
