using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreWebsite.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " "+values.Surname;


            Context context = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}
