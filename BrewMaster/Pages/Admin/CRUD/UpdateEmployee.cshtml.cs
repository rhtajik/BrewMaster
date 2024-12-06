using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewMaster.Data;
using BrewMaster.Models;
using BrewMaster.Data;
using BrewMaster.Models;

public class UpdateEmployeeModel : PageModel
{
    private readonly BrewMasterDbContext _context;

    public UpdateEmployeeModel(BrewMasterDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Employee Employee { get; set; }

    public IActionResult OnGet(int id)
    {
        Employee = _context.Employee.FirstOrDefault(e => e.Id == id);
        if (Employee == null)
        {
            return RedirectToPage("/Admin/CRUD/Index");
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var employeeToUpdate = _context.Employee.Find(Employee.Id);
        if (employeeToUpdate == null)
        {
            return NotFound();
        }

        employeeToUpdate.Name = Employee.Name;
        employeeToUpdate.Password = Employee.Password;
        _context.SaveChanges();

        return RedirectToPage("/Admin/CRUD/Index");
    }
}
