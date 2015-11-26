using System;

namespace Entities.JobSeeker
{
    public class ViewProfileEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string CurrentCity { get; set; }
        public string PreferedCity { get; set; }
        public string CurrentWorkStatus { get; set; }
        public float CurrentCTC { get; set; }
        public float ExpectedCTC { get; set; }
        public String NoticePeriod { get; set; }
        public string AvailabilityForInterview { get; set; }
        public string EmployeeStatus { get; set; }
        public string JobType { get; set; }
        public string CompantType { get; set; }
        public string HighestQualification { get; set; }
        public string TotalExperience { get; set; }
        public string JobPostLookingFor { get; set; }

        public string ResumeTitle { get; set; }

        public string Skills { get; set; }

        public DateTime Birthdate { get; set; }

        public string Address { get; set; }
    }
}