using Microsoft.AspNetCore.Mvc;
public class ArticleController:Controller{
public IActionResult Index(){
    ViewBag.Title = "Home";
    return View();
}

}