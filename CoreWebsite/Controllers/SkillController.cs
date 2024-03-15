using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Skill Page";
            ViewBag.v2 = "Skill";
            ViewBag.v3 = "SkillList";
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill() 
        {
            ViewBag.v1 = "Add Skill Page";
            ViewBag.v2 = "Skill";
            ViewBag.v3 = "AddSkill";

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            skillManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = skillManager.TGetById(id);
            skillManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Edit Skill Page";
            ViewBag.v2 = "Skill";
            ViewBag.v3 = "EditSkill";
            var values = skillManager.TGetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill p)
        {
            skillManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
