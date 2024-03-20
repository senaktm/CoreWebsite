using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard Page";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "EditDashboard";
            return View();
        }
    }
}
