﻿using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
