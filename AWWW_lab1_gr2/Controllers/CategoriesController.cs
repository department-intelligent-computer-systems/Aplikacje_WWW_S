using Microsoft.AspNetCore.Mvc;
using AWWW_lab1_gr2.Models;

public class CategoriesController:Controller{
    public IActionResult Index(){
        ViewBag.Title = "Kategorie";
        return View();
    }
}