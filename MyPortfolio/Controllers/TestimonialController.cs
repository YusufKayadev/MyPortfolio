using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteTestomnial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestomnial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestomnial(Testimonial testomnial)
        {
            var value = context.Testimonials.Update(testomnial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> UpdateTestimonial(Testimonial testimonial, IFormFile ImageFile)
        //{
        //    if (ImageFile != null)
        //    {
        //        var resource = Directory.GetCurrentDirectory();
        //        var extension = Path.GetExtension(ImageFile.FileName);
        //        var imageName = Guid.NewGuid() + extension;
        //        var saveLocation = resource + "/wwwroot/images/testimonials/" + imageName;
        //        using (var stream = new FileStream(saveLocation, FileMode.Create))
        //        {
        //            await ImageFile.CopyToAsync(stream);
        //        }
        //        testimonial.ImageUrl = "/images/testimonials/" + imageName;
        //    }
        //    else
        //    {}
        //    context.Testimonials.Update(testimonial);
        //    context.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}
