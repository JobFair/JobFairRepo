namespace Entities.JobSeeker
{
    //Currentjob job details object
    public class CurrentDesiredJobEntity
    {
        public string Candidateid { get; set; }
        public string ResumeHeadline { get; set; }
        public string TotalExperience { get; set; }
        public int Industry { get; set; }
        public int Department { get; set; }
        public string CurrentJobRole { get; set; }
        public string PrimFunctionalRole { get; set; }
        public string PrimJobDescrip { get; set; }
        public string PrimTechSkills { get; set; }
        public string SecFunctionalRole { get; set; }
        public string SecJobDescrip { get; set; }
        public string SecTechSkills { get; set; }
        public string Designation { get; set; }
        public string CurrentEmployer { get; set; }
        public string ReasonforJobChange { get; set; }
        public string TechnicalSkills { get; set; }
    }
}