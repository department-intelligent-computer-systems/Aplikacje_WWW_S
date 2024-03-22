using Microsoft.AspNetCore.Mvc;

using AWWW_lab1_gr2.Models;
using Microsoft.AspNetCore.Components.Web;

public class PositionController: Controller {
    private readonly DatabaseContext _context; 
    public PositionController(DatabaseContext context){
        _context = context; 
    }

    public IActionResult Index() {
        ViewBag.Title = "Pozycje"; 
        var positions = _context.Positions;
        return View(positions); 
    }

    public IActionResult Form() {
        ViewBag.Title = "Dodawanie pozycji"; 
        return View(); 
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Add(Position position) {
        if(ModelState.IsValid){

            _context.Positions.Add(position); 
            _context.SaveChanges(); 
            return RedirectToAction("Index"); 
        }
        return RedirectToAction("Index");  
    }

}