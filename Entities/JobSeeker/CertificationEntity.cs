using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
    public class CertificationEntity
    {
        //Certification JobSeekerEntity
        public string CandidateId { get; set; }

        public string CertificationName { get; set; }
        public string Institute { get; set; }
        public string Duration { get; set; }
        public string YearOfCompletion { get; set; }
        public string Grade { get; set; }
    }
}
