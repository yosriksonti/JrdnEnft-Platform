using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;


using Microsoft.Owin.Host.SystemWeb;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PIkindergarten.Models.admin;
using PIkindergarten.Models.doctor;

namespace PIkindergarten.Controllers
{
    public class DoctorController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private REST rest = new REST();
        public JArray sendGetRequest()
        {
            string response = client.GetStringAsync("http://127.0.0.1:8080/getAllDoctors").GetAwaiter().GetResult();
            var doctors = JArray.Parse(response);
            return doctors;
        }
        // GET: Doctor
        public ActionResult Index()
        {
            JArray response = sendGetRequest();
            return View(response);
        }

        public ActionResult GetDoctorBy(int? id)
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
            string response = client.GetStringAsync("http://127.0.0.1:8080/Doctor/"+id).GetAwaiter().GetResult();
            var doctors = JObject.Parse(response);
           

            return doctors;
        }



        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Create(Doctor doctor)
        {
            string values =
              "{"
             + "\"address\" : \"" + doctor.Address + "\","
             + "\"password\" : \"" + doctor.Password + "\","
             + "\"cin\" : " + doctor.Cin + ","
             + "\"is_active\" :  true ,"
             + "\"phonenumber\" : " + doctor.phonenumber + ","
             + "\"email\" : \"" + doctor.Email + "\","
             + "\"name\" : \"" + doctor.Name + "\","
             + "\"lastname\" : \"" + doctor.Lastname + "\","
             + "\"roleA\" : " + 2 + ","
             + "\"login\" : \"" + doctor.Login + "\","
             + "\"birthday\" : \"" + doctor.Birthday.ToString("yyyy-MM-dd") + "\""
             + "}";
            HttpResponseMessage resp = rest.sendPostRequest(values, "http://localhost:8080/addDoctor");
          
            return View();
        }



            // GET: Doctor/Edit/5
            public ActionResult Edit(int? id)
            {

            ViewBag.doctorId = id;
            return View();
            }

            // POST: Doctor/Edit/5
            [HttpPost]
            public ActionResult Edit(Doctor doctor,int ? id)
            {
                string values =
                   "{"
                  + "\"id\" : \"" + doctor.id + "\","
                  + "\"address\" : \"" + doctor.Address + "\","
                  + "\"password\" : \"" + doctor.Password + "\","
                  + "\"cin\" : " + doctor.Cin + ","
                  + "\"is_active\" :  true ,"
                  + "\"phonenumber\" : " + doctor.phonenumber + ","
                  + "\"email\" : \"" + doctor.Email + "\","
                  + "\"name\" : \"" + doctor.Name + "\","
                  + "\"lastname\" : \"" + doctor.Lastname + "\","
                  + "\"roleA\" : " + 2 + ","
                  + "\"login\" : \"" + doctor.Login + "\","
                  + "\"birthday\" : \"" + doctor.Birthday.ToString("yyyy-MM-dd") + "\""
                  + "}";
            HttpResponseMessage resp = rest.sendPutRequest(values, "http://localhost:8080/ModifyDoctorById/"+id);
            Console.WriteLine(resp);
            

                
            return RedirectToAction("Index");
        }
            

   

        // POST: Doctor/Delete/5
      
        public ActionResult Delete(int? id)
        {
            HttpResponseMessage response = rest.sendDeleteRequest("http://localhost:8080/deleteDoctor/" + id);
            return RedirectToAction("Index", "Doctor");
        }
    }
}
