using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.Intrinsics.X86;

namespace CoreWebsite.ViewComponents.Dashboard
{
    public class AdminNotificationList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
