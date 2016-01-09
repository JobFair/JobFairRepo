using System;

namespace Entities.HR
{
    public class ClientDetailsEntity
    {
        public int HrId { get; set; }
        public string ClientName { get; set; }
        public string ClientProfile { get; set; }
        public int Industry { get; set; }
        public int FunctionalArea { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int Pincode { get; set; }
        public string OfficialEmailId { get; set; }
        public string Website { get; set; }
        public string OfficialContact { get; set; }
        public string Status { get; set; }
        public DateTime AgreementDate { get; set; }
        public DateTime DueDate { get; set; }
        public string PaymentDetails { get; set; }
        public string PaymentTerms { get; set; }
        public string AddFunctionalArea { get; set; }
        public int PercentageAmount { get; set; }
    }
}