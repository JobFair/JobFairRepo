using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
   public class AffirmativeDetailsEntity
    {
       //AffirmativeDetailsEntity
        public string CandidateId { get; set; }
        public string PhysicallyChallenged { get; set; }
        public string Description { get; set; }
        public string Sports { get; set; }
        public string SportsDescription { get; set; }
        public string USAPermit { get; set; }
        public string OtherPermits { get; set; }
    }
}
