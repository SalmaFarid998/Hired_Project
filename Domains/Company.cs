namespace HiredProject.Domains
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<GeoLocation> Locations { get; set; }

        public List<User> CurrentEmployees { get; set; }
    }
}
