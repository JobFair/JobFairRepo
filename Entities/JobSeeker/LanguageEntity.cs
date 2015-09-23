namespace Entities.JobSeeker
{
    public class LanguageEntity
    {
        //LanguageEntity
        public string CandidateId { get; set; }
        public int LanguageId { get; set; }
        public string ProficiencyLevel { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Speak { get; set; }
    }
}