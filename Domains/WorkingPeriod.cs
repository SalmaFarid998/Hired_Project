namespace HiredProject.Domains
{
    public class WorkingPeriod
    {
        public Guid id { get; set; }
        public User Employee { get; set; }
        public Company Company { get; set; }
        public DateOnly StartDate  { get; set; }
        public DateOnly? EndDate { get; set; }
    }
}
