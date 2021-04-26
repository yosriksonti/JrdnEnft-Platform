using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIkindergarten.Controllers
{
    public class HealthRecordController : Controller
    {
        // GET: HealthRecord
        public ActionResult Index()
        {
            return View();
        }

        // GET: HealthRecord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HealthRecord/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthRecord/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HealthRecord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HealthRecord/Edit/5
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

        // GET: HealthRecord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HealthRecord/Delete/5
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
