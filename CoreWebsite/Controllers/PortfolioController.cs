using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "PortfolioList";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Add Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "AddEPortfolio";

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            portfolioManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Edit Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "EdiPortfolio";
            var values = portfolioManager.TGetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            portfolioManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
