using System.ComponentModel.DataAnnotations;

namespace HiredProject.Domains
{
    public class Review
    {
        public Guid Id { get; set; }
        public int UserId {  get; set; }
        public User User { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public string ReviewContent { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
    }
}
