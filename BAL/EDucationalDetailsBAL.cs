using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;
using System.Data;
using CommonUtil;

namespace BAL
{
   public class EducationalDetailsBAL
    {
            /// <summary>
            /// Saving Educational Deatils JobSeeker.
            /// </summary>
            /// <param name="edEntity">The Educational Details entity.</param>
            /// <returns>System.Int32.</returns>
           public bool SaveEducationalDetailsBAL(List<EducationalDetailsEntity> edEntity)
           {
               EducationalDetailsDAL edDAL = new EducationalDetailsDAL();
               return edDAL.SaveEducationalDetailsDAL(edEntity);
           }
           /// <summary>
           /// Load Educational Degree Type
           /// </summary>
           /// <returns></returns>
           public DataSet GetEducationalDegreeTypeBAL()
           {
               return Utility.GetEducationalDegreeTypeDAL();
           }
       }
    }

