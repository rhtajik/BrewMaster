using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewMaster.Data;
using BrewMaster.Models;
using BrewMaster.Data;
using Microsoft.AspNetCore.Mvc;

public class CleaningModel : PageModel
{
    private readonly BrewMasterDbContext _context;

    public CleaningModel(BrewMasterDbContext context)
    {
        _context = context;
    }

    public List<Machine> Machines { get; set; }

    public void OnGet()
    {
        Machines = _context.Machine.ToList();
    }

    public IActionResult OnPostClean(int id)
    {
        var machine = _context.Machine.Find(id);
        if (machine != null)
        {
            machine.LatestClean = DateTime.Now;
            _context.SaveChanges();
        }
        return RedirectToPage();
    }
}
