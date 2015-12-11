using DAL;
using System.Data;

namespace BAL
{
    public class RequestEmailJSBAL
    {
        /// <summary>
        /// Get email id bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet GetEmailBAL(string candidateId)
        {
            RequestEmailJSDAL requestEmailJSDAL = new RequestEmailJSDAL();
            return requestEmailJSDAL.GetEmailDAL(candidateId);
        }
    }
}