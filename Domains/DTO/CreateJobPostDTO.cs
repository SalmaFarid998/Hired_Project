namespace HiredProject.Domains.DTO
{
    public class CreateJobPostDTO
    {
        //public Guid Id { get; set; }
        public string JobType { get; set; }//remote, hybrid, etc...
        public Guid CompanyId { get; set; }
        //public Company Company { get; set; }
        //public List<User>? Applicants { get; set; }
        public string JobTitle { get; set; }
        public Requirements? Requirements { get; set; }
        public string Description { get; set; }
        public int? Salary {  get; set; }
    }
}
