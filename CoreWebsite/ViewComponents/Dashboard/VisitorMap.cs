using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.ViewComponents.Dashboard
{
    public class VisitorMap :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
