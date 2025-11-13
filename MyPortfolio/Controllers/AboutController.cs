using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        
        [HttpGet]
        public IActionResult Index()
        {
            var value = context.Abouts.FirstOrDefault();
            if (value == null)
            {
                value = new About();
            }

            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
