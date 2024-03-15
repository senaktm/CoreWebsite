using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial() 
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
    }
}
