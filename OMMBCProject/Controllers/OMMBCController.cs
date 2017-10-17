using OMMBCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OMMBCProject.Controllers
{
    public class OMMBCController : Controller
    {
        // GET: OMMBC
        public ActionResult Index()
        {
            var entities = new OMMBCEntities();
            return View(entities.Problems.ToList());
        }

        // GET: OMMBC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OMMBC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OMMBC/Create
        [HttpPost]
        public ActionResult Create(Problem collection)
        {
            try
            {
                // TODO: Add insert logic here
                var entities = new OMMBCEntities();
                entities.Problems.Add(collection);
                entities.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        // GET: OMMBC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OMMBC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OMMBC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OMMBC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
