using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Experience Page";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "ExperienceList";
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Add Experience Page";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "AddExperience";

            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Edit Experience Page";
            ViewBag.v2 = "Experience";
            ViewBag.v3 = "EditExperience";
            var values = experienceManager.TGetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience p)
        {
            experienceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
