using Newtonsoft.Json.Linq;
using PIkindergarten.Models.doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Host.SystemWeb;
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
        public ActionResult Create(DoctorAvailability doctorAvailability)
        {
            JArray doctors = rest.sendGetArrayRequest("http://localhost:8080/getAllDoctors");
            ViewBag.doctors = doctors;
            string values =
              "{"
               + "\"doctor\" : " + doctorAvailability.doctor + ","
               + "\"hdebut\" : " + doctorAvailability.hdebut + ","
               + "\"mdebut\" : " + doctorAvailability.mdebut + ","
               + "\"hfin\" : " + doctorAvailability.hfin + ","
               + "\"mfin\" : " + doctorAvailability.mfin 

               + "}";


            HttpResponseMessage resp = rest.sendPostRequest(values, "http://localhost:8080/addDoctorAvaibility");

            return View();
        }

        
    

        // GET: DoctorAvaibility/Edit/5
        public ActionResult Edit(int ? id)
        {
            ViewBag.doctorAvaibilityId = id;
            return View();
        }

        // POST: DoctorAvaibility/Edit/5
        [HttpPost]
        public ActionResult Edit(DoctorAvailability doctorAvailability, int? id)
        {
            string values =
               "{"
               + "\"id\" : \"" + doctorAvailability.id + "\","
               + "\"doctor\" : " + doctorAvailability.doctor + ","
               + "\"hdebut\" : " + doctorAvailability.hdebut + ","
               + "\"mdebut\" : " + doctorAvailability.mdebut + ","
               + "\"hfin\" : " + doctorAvailability.hfin + ","
               + "\"mfin\" : " + doctorAvailability.mfin
              + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8080//modifyDoctorAvaibility/" + id);
            Console.WriteLine(resp);



            return RedirectToAction("/Index");
        }

 
        public ActionResult Delete(int ? id)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://localhost:8080/deleteDoctorAvaibilityById/" + id);
            return RedirectToAction("Index", "DoctorAvaibility/Index");
        }
    }
}
