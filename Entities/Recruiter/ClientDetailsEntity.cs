using System;

namespace Entities.Recruiter
{
    public class ClientDetailsEntity
    {
        public string ClientName { get; set; }
        public int Industry { get; set; }
        public int FunctionalArea { get; set; }
        public int Country { get; set; }
        public int State { get; set; }
        public int City { get; set; }
        public string OfficialEmailId { get; set; }
        public string Website { get; set; }
        public string ContactDetails { get; set; }
        public string OfficialAddress { get; set; }
        public DateTime AgreementDate { get; set; }
        public DateTime DueDate { get; set; }
        public string PaymentDetails { get; set; }
        public string PaymentTerms { get; set; }
    }
}