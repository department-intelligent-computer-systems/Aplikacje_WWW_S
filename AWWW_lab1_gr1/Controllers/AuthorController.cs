﻿using AWWW_lab1_gr1.Data;
using AWWW_lab1_gr1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AWWW_lab1_gr1.Controllers
{
    public class AuthorController : Controller
    {
        private readonly MyDBContext _dbContext;

        public AuthorController(MyDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Author> authors = _dbContext.Authors!.ToList();
            return View(authors);
        }

        public IActionResult Details(int id) 
        {
            Author? author = _dbContext.Authors
                            .Include(a => a.Articles)
                            .FirstOrDefault(x => x.Id == id);
            return View(author);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Author author)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Authors!.Add(author);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
