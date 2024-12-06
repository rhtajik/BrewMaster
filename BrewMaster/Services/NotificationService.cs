using BrewMaster.Data;
using BrewMaster.Models;
using BrewMaster.Data;

public class NotificationService
{
    private readonly BrewMasterDbContext _context;

    public NotificationService(BrewMasterDbContext context) => _context = context;

    public void CheckNotifications()
    {
        var pending = _context.Notification
            .Where(n => !n.IsSent && n.NotificationDate <= DateTime.Now)
            .ToList();

        foreach (var notification in pending)
        {
            Send(notification);
            notification.IsSent = true;
        }
        _context.SaveChanges();
    }

    private void Send(Notification notification)
    {
        Console.WriteLine($"Notifikation sendt: {notification.Description}");
    }
}
