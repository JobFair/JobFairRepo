﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
    public class EducationalDetailsEntity
    {
        //EducationalDetails JobSeekerEntity
        public string CandidateId { get; set; }
        public int DegreeId { get; set; }

        public string MediumOfEducation { get; set; }
        public string Status { get; set; }
        public string Specialization { get; set; }
        public string YearOfCompletion { get; set; }
        public string University { get; set; }
        public string Percantage { get; set; }

    }
}
