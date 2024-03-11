using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutManager aboutManager = new AboutManager(new EfAboutDal());
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
