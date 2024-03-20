using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
