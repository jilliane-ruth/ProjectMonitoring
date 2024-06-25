namespace ProjectMonitoring.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectStarted { get; set; }

        public ICollection<Location> Locations { get; set; }

    }
}
