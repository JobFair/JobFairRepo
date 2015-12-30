namespace Entities
{
    public class RegisterEntity
    {
        //RegisterJobSeekerEntity
        public string UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }

        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public int CityId { get; set; }
        public string CurrentAddress { get; set; }
        public string RefCandidateId { get; set; }
        public string UploadResumepath { get; set; }
        public string Candidateid { get; set; }

        public int Country { get; set; }

        public int State { get; set; }

        public int CityArea { get; set; }

        public string Pincode { get; set; }

        public bool IsMailSent { get; set; }
    }
}