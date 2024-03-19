﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "PortfolioList";
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Add Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "AddPortfolio";

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult validationResult = validations.Validate(p);
            if (validationResult.IsValid)
            {
                portfolioManager.TAdd(p); 
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
          
           
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Edit Portfolio Page";
            ViewBag.v2 = "Portfolio";
            ViewBag.v3 = "EdiPortfolio";
            var values = portfolioManager.TGetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult validationResult = validations.Validate(p);
            if (validationResult.IsValid)
            {
                portfolioManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
          
        }
    }
}
