using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreWebsite.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        public IActionResult TestimonialDelete(int id)
        {
            var value = testimonialManager.TGetById(id);
            testimonialManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult TestimonialAdd()
        {

            return View();
        }
        [HttpPost]
        public IActionResult TestimonialAdd(int id)
        {
            var value = testimonialManager.TGetById(id);
            testimonialManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult TestimonialEdit(int id)
        {
            var value = testimonialManager.TGetById(id);
      
            return View(value);
        }
        [HttpPost]
        public IActionResult TestimonialEdit(Testimonial p)
        {
          testimonialManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
