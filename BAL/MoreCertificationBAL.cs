﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;
using System.Data;

namespace BAL
{
    public class MoreCertificationBAL
    {
        /// <summary>
        /// Saving MoreCertification Deatils JobSeeker.
        /// </summary>
        /// <param name="certificationEntity">The Certification Entity.</param>
        /// <returns>System.Int32.</returns>
        public bool SaveMoreCertificationBAL(List<CertificationEntity> certificationEntity)
        {
            MoreCertificationDAL certDAL = new MoreCertificationDAL();
            return certDAL.SaveMoreCertificationDAL(certificationEntity);
        }
    }
}
