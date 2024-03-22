using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AWWW_lab1_gr2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AWWW_lab1_gr2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly DatabaseContext asd;
        public CategoryController(DatabaseContext databaseContext, ILogger<CategoryController> logger){
            asd = databaseContext;
            _logger = logger;
        }
        

        public IActionResult Index(){
            return View(asd.Categories.ToList()!);
        }
        public IActionResult Dodaj(int id = -1)
        {

            if (id != -1)
            {
                var category = asd.Categories!
                    .FirstOrDefault(a => a.Id == id);
                @ViewBag.Header = "Edytuj kategorię";
                @ViewBag.ButtonText = "Edytuj";
                return View(category);
            }
            else
            {
                @ViewBag.Header = "Dodaj kategorię";
                @ViewBag.ButtonText = "Dodaj";
                return View();
            }
            
        }

        [HttpPost]
        public IActionResult Dodaj(Category category)
        {
            if (category.Id != 0)
            {
                var a = asd.Categories!.FirstOrDefault(a => a.Id == category.Id);
                if (a != null)
                {
                    a.Name = category.Name;
                }
            }
            else
            {
                asd.Categories!.Add(category);
            }
            asd.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}