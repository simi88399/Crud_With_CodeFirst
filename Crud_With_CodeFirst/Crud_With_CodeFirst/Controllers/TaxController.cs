using Crud_With_CodeFirst.Models;
using Crud_With_CodeFirst.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_With_CodeFirst.Controllers
{
    public class TaxController : Controller
    {
        // GET: Tax
        private readonly TaxRepositary _taxRepositary;

        
        public TaxController(TaxRepositary taxRepositary)
        {
            _taxRepositary = taxRepositary;
        }

        public ActionResult Index()
        {
            var tax = _taxRepositary.GetTax();
            return View(tax);
        }

        public ActionResult Details(int id)
        {
            var tax = _taxRepositary.GetTaxById(id);
            return View(tax);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tax tax)
        {
            if (ModelState.IsValid)
            {
                _taxRepositary.AddTax(tax);
                _taxRepositary.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var tax = _taxRepositary.GetTaxById(id);
            return View(tax);
        }

        [HttpPost]
        public ActionResult Edit(Tax employee)
        {
            if (ModelState.IsValid)
            {
                _taxRepositary.UpdateTax(employee);
                _taxRepositary.Save();
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(employee);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _taxRepositary.GetTaxById(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            _taxRepositary.DeleteTax(id);
            _taxRepositary.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}