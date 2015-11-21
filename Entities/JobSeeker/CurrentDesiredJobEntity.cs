namespace Entities.JobSeeker
{
    //Currentjob job details object
    public class CurrentDesiredJobEntity
    {
        //current job details entities
        public string Candidateid { get; set; }

        public string ResumeHeadline { get; set; }
        public string TotalExperience { get; set; }
        public string ProfileSummary { get; set; }
        public string Objective { get; set; }
        public string CurrentEmployeedUnemployeed { get; set; }

        // desired job details entities
        public string CurrentWorkingStatus { get; set; }

        public double CurrentAnualSal { get; set; }
        public double ExpectedAnualSal { get; set; }
        public string NoticePeriod { get; set; }
        public string EmploymentStatus { get; set; }
        public string JobType { get; set; }
        public string CompanyType { get; set; }
        public string WorkArea { get; set; }

        public string PreferredCity { get; set; }

        public string Availabilityforinterview { get; set; }

        public string TimeInWeekdays { get; set; }

        public string PreferrefArea { get; set; }

        public string JobPostLookingFor { get; set; }

        public string Industry { get; set; }

        public string Department { get; set; }

        public string FunctionalRole { get; set; }

        public string RelevantExp { get; set; }
    }
}