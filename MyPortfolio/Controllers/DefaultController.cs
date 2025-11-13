using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(Message message)
        {
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
