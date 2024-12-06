using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewMaster.Models;
using BrewMaster.Data;
using BrewMaster.Data;
using BrewMaster.Models;
using Microsoft.AspNetCore.Mvc;


public class CreateEmployeeModel : PageModel
{
    private readonly BrewMasterDbContext _context;
    public CreateEmployeeModel(BrewMasterDbContext context) => _context = context;

    [BindProperty]
    public Employee Employee { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();
        _context.Employee.Add(Employee);
        _context.SaveChanges();
        return RedirectToPage("/Admin/CRUD/Index");
    }
}
