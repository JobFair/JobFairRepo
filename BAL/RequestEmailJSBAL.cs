using DAL;
using System.Data;

namespace BAL
{
    public class RequestEmailJSBAL
    {
        public DataSet GetEmailBAL(string candidateId)
        {
            RequestEmailJSDAL requestEmailJSDAL = new RequestEmailJSDAL();
            return requestEmailJSDAL.GetEmailDAL(candidateId);
        }
    }
}