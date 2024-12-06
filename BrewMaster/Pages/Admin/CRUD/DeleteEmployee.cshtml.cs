using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewMaster.Data;
using BrewMaster.Data;
using Microsoft.AspNetCore.Mvc;

public class DeleteEmployeeModel : PageModel
{
    private readonly BrewMasterDbContext _context;
    public DeleteEmployeeModel(BrewMasterDbContext context) => _context = context;

    public IActionResult OnPost(int id)
    {
        var employee = _context.Employee.Find(id);
        if (employee != null)
        {
            _context.Employee.Remove(employee);
            _context.SaveChanges();
        }
        return RedirectToPage("/Admin/CRUD/Index");
    }
}
