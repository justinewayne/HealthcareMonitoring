namespace HealthcareMonitoring.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Double Temperature { get; set; }

        public Double PulseRate { get; set; }

        public Double HeartRate { get; set; }

        public Double PulseOximeter { get; set; }
    }
}
