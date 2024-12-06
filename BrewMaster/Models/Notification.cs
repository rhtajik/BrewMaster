namespace BrewMaster.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string NotificationType { get; set; }
        public string Description { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsSent { get; set; }
        public string ResponsibleEmployee { get; set; }
    }
}
