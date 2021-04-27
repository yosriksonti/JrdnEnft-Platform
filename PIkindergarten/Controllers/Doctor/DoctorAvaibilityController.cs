﻿using Newtonsoft.Json.Linq;
using PIkindergarten.Models.doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PIkindergarten.Controllers
{
    public class DoctorAvaibilityController : Controller
    {


        private static readonly HttpClient client = new HttpClient();
        private REST rest = new REST();


        public JArray sendGetRequest()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/getAllDoctorAvaibility").GetAwaiter().GetResult();
            var docAvai = JArray.Parse(response);
            return docAvai;
        }

        // GET: DoctorAvaibility
        public ActionResult Index()
        {
            JArray response = sendGetRequest();
            return View(response);
        }

        public ActionResult GetDoctorAvaibilityById(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JObject response = sendGetRequestDoctorID(id);

            if (response == null)
            {
                return HttpNotFound();
            }
            return View(response);


        }

        public JObject sendGetRequestDoctorID(int? id)
        {
            string response = client.GetStringAsync("http://localhost:8080/getCreneauById/" + id).GetAwaiter().GetResult();
            var doctors = JObject.Parse(response);


            return doctors;
        }






        // GET: DoctorAvaibility/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorAvaibility/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorAvaibility/Create
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

        // GET: DoctorAvaibility/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorAvaibility/Edit/5
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

        // GET: DoctorAvaibility/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorAvaibility/Delete/5
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
