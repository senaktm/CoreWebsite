﻿using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
