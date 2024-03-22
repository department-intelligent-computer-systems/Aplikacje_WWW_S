using Microsoft.AspNetCore.Mvc;

using AWWW_lab1_gr2.Models;
using Microsoft.AspNetCore.Components.Web;

public class EventTypeController: Controller {
     private readonly DatabaseContext _context; 
    public EventTypeController(DatabaseContext context){
        _context = context; 
    }


    public IActionResult Index() {
        ViewBag.Title = "Rodzaje wydarzen"; 
        var eventTypes = _context.EventTypes;
        return View(eventTypes); 
    }

    public IActionResult Form() {
        ViewBag.Title = "Dodawanie rodzaju wydarzen"; 
        return View(); 
    }

    [HttpPost, ValidateAntiForgeryToken]
    public IActionResult Add(EventType eventType) {
        if(ModelState.IsValid){

            _context.EventTypes.Add(eventType); 
            _context.SaveChanges(); 
            return RedirectToAction("Index"); 
        }
        return RedirectToAction("Index");  
    }

}