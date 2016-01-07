using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Common
{
    public class AffirmativeDetailsEntity
    {
        // AffirmativeDetailsEntity
        public Int64 ID { get; set; }
        public string PhysicallyChallenged { get; set; }
        public string Description { get; set; }
        public string Sports { get; set; }
        public string SportsDescription { get; set; }
        public string USAPermit { get; set; }
        public string OtherPermits { get; set; }
        public string Hobbies { get; set; }
        public string ExtraActivity { get; set; }

        public int UserType { get; set; }
    }
}
