using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewMaster.Data;
using BrewMaster.Data;
using BrewMaster.Models;

public class NotificationsModel : PageModel
{
    private readonly BrewMasterDbContext _context;
    public NotificationsModel(BrewMasterDbContext context) => _context = context;

    public List<Notification> Notifications { get; set; }

    public void OnGet() => Notifications = _context.Notification.ToList();
}
