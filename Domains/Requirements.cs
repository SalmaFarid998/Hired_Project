namespace HiredProject.Domains
{
    public class Requirements
    {
        public Guid Id { get; set; }
        public int? MinYearsOfExperience { get; set; }
        public int? MaxYearsOfExperience { get; set; }
        public List<string> RequiredSkills { get; set; }
        public List<string>? RequiredLanguages { get; set; }
        public List<string> RequiredCertifications { get; set; }
        public List<string> RequiredEducationLevel { get; set; }


    }
}
