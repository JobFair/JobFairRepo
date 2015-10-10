using System;

namespace Entities.JobSeeker
{
    public class ViewProfileEntity
    {
        public String FirstName { get; set; }

        public string LastName { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string ResumeTitle { get; set; }

        public string Skills { get; set; }

        public DateTime Birthdate { get; set; }

        public string Address { get; set; }

        public string CurrentEmployer { get; set; }

        public string WorkExperience { get; set; }

        public string DesignationCurrent { get; set; }

        public string AnnualSalary { get; set; }

        public string ExpectedSalary { get; set; }

        public string CompanyType { get; set; }
    }
}