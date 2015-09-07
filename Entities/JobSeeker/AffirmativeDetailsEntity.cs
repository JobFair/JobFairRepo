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
        public string candidateId { get; set; }
        public string language { get; set; }
        public string proficiencyLevel { get; set; }
        public byte read { get; set; }
        public byte write { get; set; }
        public byte speak { get; set; }
        public string physicallyChallenged { get; set; }
        public string description { get; set; }
        public string sports { get; set; }
        public string sportsDescription { get; set; }
        public string usaPermit { get; set; }
        public string otherPermits { get; set; }
    }
}
