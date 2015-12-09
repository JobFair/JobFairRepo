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

        public int JobPostLookingId { get; set; }

        public string CurrentCompanyOrNot { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public string RolesResponsibility { get; set; }

        public string FromMonth { get; set; }

        public string FromYear { get; set; }

        public string TillMonth { get; set; }

        public string TillYear { get; set; }

        public string CurrentEmploymentStatus { get; set; }

        public string ReasonForJobChange { get; set; }

        public int ExpId { get; set; }

        public string PreferredState { get; set; }

        public string BeforeHours { get; set; }

        public string BeforeMinutes { get; set; }

        public string BeforeTime { get; set; }

        public string AfterHours { get; set; }

        public string AfterMinutes { get; set; }

        public string AfterTime { get; set; }

        public string TimeISTETE { get; set; }

        public string TechnicalSkills { get; set; }

        public string Proficiency { get; set; }

        public int SkillId { get; set; }

        public string FromDate { get; set; }

        public string TillDate { get; set; }

        public string RoleSkills { get; set; }

        public int PreferredCountry { get; set; }
    }
}