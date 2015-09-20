using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;

namespace BAL
{
   public class EducationalDetailsBAL
    {
            /// <summary>
            /// Saving Educational Deatils JobSeeker.
            /// </summary>
            /// <param name="edEntity">The Educational Details entity.</param>
            /// <returns>System.Int32.</returns>
           public int SaveEducationalDetailsBAL(List<EducationalDetailsEntity> edEntity)
           {
               EducationalDetailsDAL edDAL = new EducationalDetailsDAL();
               return edDAL.SaveEducationalDetailsDAL(edEntity);

           }
       }
    }

