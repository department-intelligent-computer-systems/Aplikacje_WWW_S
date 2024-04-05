using Microsoft.AspNetCore.Mvc;
using AWWW_lab1_gr2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

public class LeaguesController:Controller{
    private readonly MyDbContext _context;

    public LeaguesController(MyDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index(){
        ViewBag.Title = "Lista lig";
        var data = await _context.Leagues.ToListAsync();
        return View(data);
    }
    
    [HttpPost]
    public async Task<IActionResult> UsunDane(int id)
    {
        var dane = await _context.Leagues.FindAsync(id);
        if (dane == null)
        {
            return NotFound();
        }

        _context.Leagues.Remove(dane);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index"); // Przekierowanie na widok po usunięciu danych
    }
}