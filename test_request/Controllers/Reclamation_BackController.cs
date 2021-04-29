using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using test_request.Models.admin;

namespace test_request.Controllers

{
    public class Reclamation_BackController : Controller

    {
        private REST rest = new REST();
        // GET: Reclamation
        public ActionResult Reclamations()
        {
            JArray response = rest.sendGetArrayRequest("http://127.0.0.1:8082/getAll");
            ViewBag.reclamations = response;
            return View();
        }

        // GET: Reclamation/Details/5
        public ActionResult Reclamation(int ? id)
        {
            JObject response = rest.sendGetObjectRequest("http://127.0.0.1:8082/Reclamation/" + id);
            ViewBag.reclamation = response;
            return View();
            
        }
        public IActionResult Add_Reclamation(int ? id)
        {
            return View();
        }
        // POST: Reclamation/Create
        [HttpPost]
        public IActionResult Add_Reclamation(Reclamation reclamation,int ? id)
        {
            string values =
              "{"
             + "\"recName\" : \"" + reclamation.RecName + "\","
             + "\"descripRec\" : \"" + reclamation.descripRec + "\","
             + "\"typeRec\" : 1,"
             + "\"dateRec\" : \"" + reclamation.DateRec.ToString("yyyy-MM-dd") + "\","
             + "\"daycare\" : { "
             + "\"id\" : \"" + id + "\" "
             + " },"
             + "\"parent\" : { "
             + "\"id\" : 1 "
             + " }"
             + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://localhost:8082/reclamation/add");

            return RedirectToAction("Reclamations");
        }
    }
}
