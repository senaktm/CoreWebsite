﻿using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
