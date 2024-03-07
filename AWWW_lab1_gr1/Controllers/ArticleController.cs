using Microsoft.AspNetCore.Mvc;
//using AWWW_lab1_gr1.Models;

public class ArticleController : Controller
{
    public IActionResult Index(int id = 1)
    {
        var articles = new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "Artykuł 1",
                Content = "Lorem ipsum...",
                CreationDate = DateTime.Now
            },
            new Article
            {
                Id = 2,
                Title = "Artykuł 2",
                Content = "Dolor sit amet...",
                CreationDate = DateTime.Now
            },
            new Article
            {
                Id = 3,
                Title = "Artykuł 3",
                Content = "Consectetur adipiscing elit...",
                CreationDate = DateTime.Now
            }
        };

        return View(articles[id - 1]);
    }
}
