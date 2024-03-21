using AWWW_lab1_gr2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AWWW_lab1_gr2.Controllers
{
    public class TagController : Controller
    {
        private readonly MyDbContext _dbContext;

        public TagController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int id)
        {
            var tag = _dbContext.Tag.FirstOrDefault(a => a.Id == id);
            if (tag != null)
                return View(tag);
            return View("Error");
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tag tag)
        {
            _dbContext.Tag.Add(tag); 
            _dbContext.SaveChanges();
            return View("Added",tag); 
        }
    }
}
