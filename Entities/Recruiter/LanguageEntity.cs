using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Recruiter
{
   public class LanguageEntity
    {
        //LanguageEntity
        public string ID { get; set; }
        public int LanguageId { get; set; }
        public string ProficiencyLevel { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Speak { get; set; }

        public int UserType { get; set; }

        public int CandidateId { get; set; }

        public int RecruiterId { get; set; }
    }
}
