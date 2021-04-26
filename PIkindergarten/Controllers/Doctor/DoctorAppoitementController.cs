using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIkindergarten.Controllers
{
    public class DoctorAppoitementController : Controller
    {
        // GET: DoctorAppoitement
        public ActionResult Index()
        {
            return View();
        }

        // GET: DoctorAppoitement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorAppoitement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorAppoitement/Create
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

        // GET: DoctorAppoitement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorAppoitement/Edit/5
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

        // GET: DoctorAppoitement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorAppoitement/Delete/5
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
