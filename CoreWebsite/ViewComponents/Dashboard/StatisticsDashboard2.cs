﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Services.Count();
         
            return View();
        }
    }
}
