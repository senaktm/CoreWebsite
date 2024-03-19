﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Add Service Page";
            ViewBag.v2 = "Service";
            ViewBag.v3 = "AddService";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            serviceManager.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetById(id);
            serviceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.v1 = "Edit Service Page";
            ViewBag.v2 = "Service";
            ViewBag.v3 = "EditService";
            var value = serviceManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditService(Service p)
        {
            serviceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
