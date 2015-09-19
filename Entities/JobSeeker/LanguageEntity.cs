using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
   public class LanguageEntity
    {
        //LanguageEntity
        public string CandidateId { get; set; }
        public int LanguageId { get; set; }
        public string ProficiencyLevel { get; set; }
        public Boolean Read { get; set; }
        public Boolean Write { get; set; }
        public Boolean Speak { get; set; }
    }
}
